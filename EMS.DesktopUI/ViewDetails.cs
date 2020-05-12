using EMS.Data;
using System;
using System.Windows.Forms;

namespace EMS.DesktopUI
{
    public partial class ViewDetails : Form
    {
        public ViewDetails(string mail , string pass)
        { 
            InitializeComponent();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
            txt6.Text = mail;
            txt7.Text = pass;
        }

        private void ViewDetails_Load(object sender , EventArgs e)
        {

        }

        private void btn6_Click(object sender , EventArgs e)
        {
            string email = txt6.Text;
            string pass = txt7.Text;

            EditDetails edit = new EditDetails(email , pass);
            edit.ShowDialog();
        }

        private void btn7_Click(object sender , EventArgs e)
        {
            EMSContext _db = new EMSContext();
            EmailDetail ed = new EmailDetail();
            Student std = new Student();
            User use = new User();
            ed.Email = txt6.Text;
            ed.Password = txt7.Text;
            //ed.StudentID = Convert.ToInt32(std.StudentID);
            //ed.StudentUserID = Convert.ToInt32(use.UserID);

            _db.EmailDetails.Add(ed);
            _db.SaveChanges();


            this.Close();
        }
    }
}
