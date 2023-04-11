using Microsoft.EntityFrameworkCore;
using Skill_International.Models;
using System.Data;

namespace Skill_International.Forms
{
    public partial class Frm_StudentRegistration : Form
    {
        public Frm_StudentRegistration()
        {
            InitializeComponent();
        }

        private void Frm_StudentRegistration_Load(object sender, EventArgs e)
        {
            // Layouts
            LayoutManager.CenterHorizontally(lblHeader, this);

            cmbRegNo.Focus();
            UpdateRegNoCmbBox();
        }

        private async void UpdateRegNoCmbBox()
        {
            // Loading RegNo
            DatabaseContext db = new DatabaseContext();
            var regNumbers = await db.Registration.Select(s => s.regNo).ToListAsync();
            cmbRegNo.Text = "";
            cmbRegNo.DataSource = regNumbers;
        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to logout ?", "Loggin out", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ActionsManager.Navigate(typeof(FrmLogin), this);
            }
        }


        private void Frm_StudentRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActionsManager.ShowExitWarining(sender, e);
        }

        // Add record - Register
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var newStudent = new StudentModel()
                {
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    address = txtAddress.Text,
                    mobilePhone = int.Parse(txtMobile.Text),
                    homePhone = int.Parse(txtHome.Text),
                    contactNo = int.Parse(txtParentMobile.Text),
                    dateOfBirth = dpDob.Value.Date,
                    email = txtEmail.Text,
                    nic = txtParentsNic.Text,
                    parentName = txtParentName.Text,
                    gender = opBtnMale.Checked ? "male" : "female"
                };

                using DatabaseContext db = new DatabaseContext();
                db.Registration.Add(newStudent);
                await db.SaveChangesAsync();
                MessageBox.Show("Record added Successfully", "Successfull !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActionsManager.ClearAllTextBoxes(this);

                UpdateRegNoCmbBox();
            }
            catch (Exception ex)
            {
                ActionsManager.ShowErrorMsg("Adding Record Failed: " + ex.Message);
            }

        }

        // Update record
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using DatabaseContext db = new DatabaseContext();

                int regNo;
                bool success = int.TryParse(cmbRegNo.SelectedItem?.ToString()?.Trim(), out regNo);
                if (!success)
                {
                    ActionsManager.ShowErrorMsg($"Error in parsing RegNo: {regNo} to {typeof(int)}");
                    return;
                }

                var record = await db.Registration.FindAsync(regNo);

                if (record is null)
                {
                    ActionsManager.ShowErrorMsg($"Cannot find a student record for RegNo. : {regNo}.");
                    return;
                }
                db.Registration.Attach(record);

                record.firstName = txtFirstName.Text;
                record.lastName = txtLastName.Text;
                record.address = txtAddress.Text;
                record.mobilePhone = int.Parse(txtMobile.Text);
                record.homePhone = int.Parse(txtHome.Text);
                record.contactNo = int.Parse(txtParentMobile.Text);
                record.dateOfBirth = dpDob.Value.Date;
                record.email = txtEmail.Text;
                record.nic = txtParentsNic.Text;
                record.parentName = txtParentName.Text;
                record.gender = opBtnMale.Checked ? "male" : "female";

                await db.SaveChangesAsync();

                MessageBox.Show("Record updated successfully.", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                UpdateRegNoCmbBox();

            }
            catch (Exception ex)
            {
                ActionsManager.ShowErrorMsg("Error in updating the record: " + ex.Message);
            }
        }


        // Load record
        private async void cmbRegNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int regNo;
                bool success = int.TryParse(cmbRegNo.Text, out regNo);
                if (!success)
                {
                    ActionsManager.ShowErrorMsg($"Error in parsing RegNo: {regNo} to {typeof(int)}");
                    ActionsManager.ClearAllTextBoxes(this);
                    return;
                }

                using DatabaseContext db = new DatabaseContext();

                var registeredStudent = await db.Registration.FindAsync(regNo);

                if (registeredStudent is null) throw new Exception($"Cannot find a student record for RegNo. : {regNo}");

                txtFirstName.Text = registeredStudent.firstName;
                txtLastName.Text = registeredStudent.lastName;
                txtAddress.Text = registeredStudent.address;
                txtMobile.Text = registeredStudent.mobilePhone.ToString();
                txtHome.Text = registeredStudent.homePhone.ToString();
                txtParentMobile.Text = registeredStudent.contactNo.ToString();
                dpDob.Value = registeredStudent.dateOfBirth;
                txtEmail.Text = registeredStudent.email;
                txtParentsNic.Text = registeredStudent.nic;
                txtParentName.Text = registeredStudent.parentName;
                opBtnMale.Checked = (registeredStudent.gender == "male");
                optBtnFemale.Checked = (registeredStudent.gender == "female");

                cmbRegNo.Focus();
            }
            catch (Exception ex)
            {
                ActionsManager.ShowErrorMsg("Error in loading the student record: " + ex.Message);
            }
        }


        // Clear texts
        private void button3_Click(object sender, EventArgs e)
        {
            ActionsManager.ClearAllTextBoxes(this);
            cmbRegNo.Text = "";
        }

        // Delete record
        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int regNo;
                bool success = int.TryParse(cmbRegNo.SelectedItem?.ToString()?.Trim(), out regNo);
                if (!success)
                {
                    ActionsManager.ShowErrorMsg($"Error in parsing RegNo: {regNo} to {typeof(int)}");
                    return;
                }

                using DatabaseContext db = new DatabaseContext();

                var studentRecord = await db.Registration.FindAsync(regNo);
                if (studentRecord is null) throw new Exception($"Cannot find a student record for RegNo. : {regNo}");

                // Prompt delete confirmation
                var result = MessageBox.Show($"Are you sure, deleting the record with RegNo. : {regNo} ?", "Confirm Delete !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (!(result == DialogResult.Yes)) return;

                db.Registration.Remove(studentRecord);
                await db.SaveChangesAsync();

                MessageBox.Show("Record deleted successfully.", "Delete Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                ActionsManager.ClearAllTextBoxes(this);
                UpdateRegNoCmbBox();
            }
            catch (Exception ex)
            {
                ActionsManager.ShowErrorMsg("Error in deleting the record: " + ex.Message);
            }
        }

        // Load record - Keypress
        private void cmbRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int regNo = int.Parse(cmbRegNo.Text);
                    int selectedIndex = cmbRegNo.Items.IndexOf(regNo);
                    cmbRegNo.SelectedIndex = selectedIndex;
                    cmbRegNo_SelectedValueChanged(sender, e);
                }
                catch (Exception ex)
                {
                    ActionsManager.ShowErrorMsg("Error in loading the student record: " + ex.Message);

                }
            }
        }
    }
}
