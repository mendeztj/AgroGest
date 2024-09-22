namespace Model
{
    public class Products
    {
        #region VARIABLES
        private int productId;
        private string name;
        private string type;
        private int stock;
        #endregion // end VARIABLES

        #region CONSTRUCTOR
        public Products() { }

        public Products(int productId, string name, string type, int stock)
        {
            this.productId = productId;
            this.name = name;
            this.type = type;
            this.stock = stock;
        }
        #endregion // end CONSTRUCTOR

        #region PROPERTIES
        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Stock { get => stock; set => stock = value; }
        #endregion // end PROPERTIES

        #region METHODS
        public void AddStock(int quantity)
        {
            stock += quantity;
        }

        public bool RemoveStock(int quantity)
        {
            if (stock >= quantity)
            {
                stock -= quantity;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion // end METHODS
    }
}
