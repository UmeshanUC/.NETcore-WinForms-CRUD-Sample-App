using Skill_International.Forms;
using Skill_International.Models;

namespace Skill_International
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //// Layouts
            //this.Size = new Size(400, 550);

            //LayoutManager.CenterHorizontally(pBx, this);
            //LayoutManager.CenterHorizontally(panel, grpBx);
            //LayoutManager.CenterHorizontally(grpBx, this);



            // Check for users

            using DatabaseContext db = new DatabaseContext();
        RETRY_INIT:
            if (!db.Logins.Any(l => l.Username == "Admin" && l.Password == "Skills@123"))
            {
                try
                {
                    db.Logins.Add(new LoginModel() { Username = "Admin", Password = "Skills@123" });
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    ActionsManager.ShowErrorMsg(ex.Message);
                    goto RETRY_INIT;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            using DatabaseContext db = new DatabaseContext();

            var loginCred = await db.Logins.FindAsync(txtUser.Text);

            if (loginCred?.Password == txtPass.Text)
            {
                ActionsManager.Navigate(typeof(Frm_StudentRegistration), this);
            }
            else
            {
                MessageBox.Show("Invalid login credentials, please check Username and Password. Then try again !",
                    "Invalid Login Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                txtUser.SelectAll();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActionsManager.ShowExitWarining(sender, e);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            ActionsManager.FocusNext(e, txtPass);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnLogin_Click(sender, e);
            }

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}