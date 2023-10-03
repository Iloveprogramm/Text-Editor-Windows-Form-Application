using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class Users
    {
        private LinkedList<User> UsersList = new LinkedList<User>(); //stores the user information together
        private User CurrentloginUser;


        public Users()
        {
            string[] accounts = File.ReadAllLines("login.txt");
            foreach (string element in accounts)
            {
                string[] NewUserInformation = element.Split(',');
                UsersList.AddLast(new User(                         //add user into .txt
                   NewUserInformation[0],
                   NewUserInformation[1],
                   NewUserInformation[2],
                   NewUserInformation[3],
                   NewUserInformation[4],
                   NewUserInformation[5]));
            }
        }

        public User getCurrentLoginUser() // get the current login user
        {
            return CurrentloginUser;  
        }

        public void AddNewUser(User user)  //add new user information into .txt by using method appendalltext
        {
            File.AppendAllText("login.txt", String.Format("\n{0},{1},{2},{3},{4},{5}", user.UserName, user.Password, user.UserType, user.FirstName, user.LastName, user.DateOfBirth));
        }
        public bool CheckUserNameExist(string username) //check the username exist by loops UsersList
        {
            foreach (User user in UsersList)
            {

                if (user.UserName == (username))
                {
                    return true;  //found, return true
                }
            }
            return false; //not found, return false
        }


        public bool CheckUserExist(String username, String password) //check user
        {
            foreach (User user in UsersList)
            {
                if (user.UserName == (username) && user.Password == (password))
                {
                    this.CurrentloginUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}
