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
    public partial class LoginSC : Form
    {
        Users users; //declare user object
        public LoginSC()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            users = new Users();
            if (CheckInput()) //check user input
            {
                if (users.CheckUserExist(UserNameTextBox.Text, PassWordTextBox.Text)) //check user exist or not
                {
                    TextEditorSC TextEditorForm = new TextEditorSC(users.getCurrentLoginUser()); 
                    this.Hide();
                    TextEditorForm.Show();//if user exist in the file, open the TextEditor interface
                }
                else
                {
                    Error.Text = "Username and Password are incorrect, Please Re-enter the information"; //Else, not found, error messgae display
                }
            }
            else if (!CheckInput()) //not input for login will display the error messgae about Re-enter
            {
                Error.Text = "Username and Password are required for Login, Please Re-enter the information";
            }
        }

        public bool CheckInput() // Check user input method
        {
            if (PassWordTextBox.Text != string.Empty && UserNameTextBox.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void NewUserButton_Click(object sender, EventArgs e) //New user button
        {
            NewUserSC N = new NewUserSC();
            N.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e) //Exit button
        {
            Application.Exit();
        }
    }
}
