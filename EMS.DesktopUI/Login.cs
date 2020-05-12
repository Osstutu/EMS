using EMS.Repository;
using System;
using System.Windows.Forms;

namespace EMS.DesktopUI
{
    public partial class Login : Form
    {
        private UserRepository _db;
        public Login()
        {
            InitializeComponent();
            _db = new UserRepository();
        }

        private void btn1_Click(object sender , EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Please enter your username and password");
                return;
            }

            bool isSuccess = _db.isValidPassword(txt1.Text , txt2.Text);

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("username and password is not correct, try again");
            }

        }

        private void btn2_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender , EventArgs e)
        {

        }
    }
}
