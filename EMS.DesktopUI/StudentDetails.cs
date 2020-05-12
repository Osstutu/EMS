using EMS.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EMS.DesktopUI
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender , EventArgs e)
        {

            Student std = new Student();
            std.Firstname = txt3.Text;
            std.Surname = txt4.Text;
            std.Department = combo.Text;


            EMSContext _db = new EMSContext();
            _db.Students.Add(std);
            _db.SaveChanges();
        }

        private void btn5_Click(object sender , EventArgs e)
        {
            string Firstname = txt3.Text;
            string Surname = txt4.Text;
            string Department = combo.Text;
            string passLength = txt5.Text;


            string institutionSuffix = "umat.com";
            string email;
            string Password;
            try
            {

                int convertor = Convert.ToInt16(passLength);

                string setDepartment(string department)
                {
                    if (department == "Computer Science and Engineering")
                    {
                        return "cse";
                    }

                    else if (department == "Mathematical Science")
                    {
                        return "mathematics";
                    }

                    else if (department == "Electrical Engineering")
                    {
                        return "electrical";
                    }

                    else if (department == "Mechanical Engineering")
                    {
                        return "mechanical";
                    }

                    else if (department == "Renewable Engineering")
                    {
                        return "renewable";
                    }

                    else
                    {
                        return "";
                    }
                }

                string randomPassword(int length)
                {
                    Random random = new Random();
                    string passwordSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%";
                    char [] password = new char [length];
                    for (int i = 0 ; i < length ; i++)
                    {
                        int rand = Convert.ToInt16(random.NextDouble() * passwordSet.Length);
                        password [i] = passwordSet.ElementAt(rand);
                    }

                    return new string(password);
                }

                Password = randomPassword(convertor);
                email = Firstname.ToLower() + "." + Surname.ToLower() + "@" + setDepartment(Department) + "." + institutionSuffix;

                string det1 = email;
                string det2 = Password;
                ViewDetails vd = new ViewDetails(det1 , det2);

                vd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btn4_Click(object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
