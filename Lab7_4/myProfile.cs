using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4
{
    class DatingProfile
    {
        public string FirstName;
        private string LastName;
        public int Age;
        public string Gender;
        public string Bio;
        private List<Messages> myMessages;

        public DatingProfile(string FirstName, string LastName, int Age, string Gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
            myMessages = new List<Messages>();
        }

        public void WriteBio(string text)
        {
            Bio = text;
        }

        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);
        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if(message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }


}
