namespace Model
{
    public class Users
    {
        #region VARIABLES
        private int userId;
        private string role;
        private string dni;
        private string name;
        private string cif;
        private string address;
        private string password;
        private string email;
        #endregion // end VARIABLES

        #region CONSTRUCTOR
        public Users() { }
        #endregion // end CONSTRUCTOR

        #region SETTERS AND SETTERS
        public int UserId { get => userId; set => userId = value; }
        public string Role { get => role; set => role = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Cif { get => cif; set => cif = value; }
        public string Address { get => address; set => address = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        #endregion // end SETTERS AND SETTERS

        #region EQUALS AND HASHCODE
        public override bool Equals(object obj)
        {
            return obj is Users user &&
                   userId == user.userId;
        }

        public override int GetHashCode()
        {
            return -394678857 + userId.GetHashCode();
        }
        #endregion // end EQUALS AND HASHCODE
    }
}
