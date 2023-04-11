namespace Skill_International
{
    public static class ActionsManager
    {
        public static void Navigate(Type destination, Form current)
        {
            GlobalStates.IsNavigating = true;

            // Create an instance of the destination form using Activator.CreateInstance
            Form? destinationInstance = (Form?)Activator.CreateInstance(destination);

            // Show the destination form and hide the current form
            destinationInstance?.Show();
            current.Close();
        }
        public static void ShowExitWarining(object sender, FormClosingEventArgs e)
        {
            if (GlobalStates.IsNavigating)
            {
                GlobalStates.IsNavigating = false;
                return;
            };

            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            var result = MessageBox.Show("Are you sure, you want to exit ?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit(e);
            }
        }

        public static void ShowErrorMsg(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        public static void ClearAllTextBoxes(Control parent)
        {
            if (parent is TextBox) parent.GetType().GetMethod("Clear")?.Invoke(parent, null);

            foreach (Control child in parent.Controls)
            {
                ClearAllTextBoxes(child);
            }
        }

        public static void FocusNext(KeyPressEventArgs e, Control nextControl)
        {
            if (e.KeyChar == ((char)Keys.Return))
            {
                nextControl.Focus();
                (nextControl as TextBoxBase)?.SelectAll();
            }
        }
    }
}
