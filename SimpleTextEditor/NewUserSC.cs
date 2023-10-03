using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class NewUserSC : Form
    {
        Users users;
        public NewUserSC()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now; //this is to restrict the maxdate when user input the DOB, not future DOB allowed
        }

        private void BackButton_Click(object sender, EventArgs e) //Back button
        {
            LoginSC L = new LoginSC();
            L.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e) //Submit button
        {
            users = new Users();
            if (CheckInput() != true) //not input found, error message display "Please enter all create account details"
            {
                ErrorMessage.Text = "Please enter all create account details";
            }
            else if (NewRePassword.Text != (NewPassword.Text)) //Password and Re-enter password not match will display error message of "Please keep your password consistent"
            {
                ErrorMessage.Text = "Please keep your password consistent";
            }
            else if(CheckInput() == true) //else if all input correct
            {
                if (users.CheckUserNameExist(NewUserName.Text)) //check user name
                {
                    ErrorMessage.Text = "Please change account name. This UserName has been used";
                }
                else // else the name is not exist , allow to add new user
                {
                    users.AddNewUser(new User(NewUserName.Text.Trim(),NewPassword.Text.Trim(),UserType.Text,FirstName.Text.Trim(),LastName.Text.Trim(),dateTimePicker1.Value.ToShortDateString().Replace("/", "-")));
                    MessageBox.Show("New Account Have Been Successfully Created \nBack to Login Screen", "New User Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginSC LoginForm = new LoginSC();
                    LoginForm.Show(); // the login interface will show up
                    this.Hide();
                }
            }
        }
        public bool CheckInput() //check user input method
        {
            if (UserType.SelectedItem != null && LastName.Text != string.Empty && FirstName.Text != string.Empty && NewPassword.Text != string.Empty && NewUserName.Text != string.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
