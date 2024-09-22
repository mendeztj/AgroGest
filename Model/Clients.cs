namespace Model
{
    public class Clients
    {
        #region VARIABLES
        private int clientId;
        private string name;
        private string cif;
        private string adress;
        private string telephone;
        private string email;
        #endregion // end VARIABLES

        #region CONSTRUCTOR
        public Clients() { }
        #endregion // end CONSTRUCTOR

        #region SETTERS AND SETTERS
        public int ClientId { get => clientId; set => clientId = value; }
        public string Name { get => name; set => name = value; }
        public string Cif { get => cif; set => cif = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        #endregion // end SETTERS AND SETTERS

        #region EQUALS AND HASHCODE
        public override bool Equals(object obj)
        {
            return obj is Clients clients &&
                   clientId == clients.clientId;
        }

        public override int GetHashCode()
        {
            return 212140475 + clientId.GetHashCode();
        }
        #endregion // end EQUALS AND HASHCODE
    }
}