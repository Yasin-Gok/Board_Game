namespace Prelab
{
    public class User
    {
        private static User myUser;
   
        private string Username;
        private string Password;
        private string Name;
        private string Lastname;
        private string Phone;
        private string Adress;
        private string City;
        private string Country;
        private string Mail;

        private User()
        {

        }

        public static User LoginedUser()
        {
            if (myUser == null)
            {
                myUser = new User();
            }

            return myUser;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Adress1 { get => Adress; set => Adress = value; }
        public string City1 { get => City; set => City = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string Mail1 { get => Mail; set => Mail = value; }
    }
}