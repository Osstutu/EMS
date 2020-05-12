using System;
using System.Windows.Forms;

namespace EMS.DesktopUI
{
    public partial class EditDetails : Form
    {
        string email;
        string password;
        public EditDetails(string mail , string pass)
        {
            InitializeComponent();
            email = mail;
            password = pass;
        }

        private void btn8_Click(object sender , EventArgs e)
        {
            string altmail = txt8.Text;
            string changePass = mtxt.Text;

            password = changePass;

            MessageBox.Show("An alternate mail " + altmail + " has being added to " + email + "\n Your new password: " + password);
            this.Close();
        }

        private void btn9_Click(object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
