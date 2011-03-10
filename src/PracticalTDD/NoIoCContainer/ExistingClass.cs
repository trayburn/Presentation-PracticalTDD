using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticalTDD.NoIoCContainer
{
    public class ExistingClass
    {
        public void SendMailToAllUsers()
        {
            var users = new DatabaseGateway().GetAllUsers();

            foreach (var user in users)
            {
                var smtp = new SmtpGateway();
                smtp.SendMail(user.UserName, "The quick brown fox jumped over the lazy dog.");
            }
        } 
    }

    public class DatabaseGateway
    {
        public List<User> GetAllUsers()
        {
            // large amounts of ADO.NET code goes here.
            return new List<User>()
            {
                new User() 
                { 
                    FirstName = "Tim", 
                    LastName = "Rayburn", 
                    UserName = "loser" 
                },
                new User() 
                { 
                    FirstName = "James", 
                    LastName = "Rayburn", 
                    UserName = "brat" 
                }
            };
        }
    }

    public class SmtpGateway
    {
        public void SendMail(string userName, string bodyText)
        {
            Console.WriteLine("Sent email to {0} with body of length {1}", userName, bodyText.Count());
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    } 
}
