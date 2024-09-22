using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Buys
    {
        #region VARIABLES
        private int comercialId;
        private int supplyId;
        private int userId;
        private DateTime date;
        private decimal totalPrice;
        #endregion // end VARIABLES

        public Buys(){}

        #region CONSTRUCTOR
        public Buys(int comercialId, int supplyId, int userId, DateTime date, decimal totalPrice)
        {
            this.comercialId = comercialId;
            this.supplyId = supplyId;
            this.userId = userId;
            this.date = date;
            this.totalPrice = totalPrice;
        }
        #endregion // end CONSTRUCTOR

        #region PROPERTIES
        public int ComercialId { get => comercialId; set => comercialId = value; }
        public int SupplyId { get => supplyId; set => supplyId = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
        #endregion // end PROPERTIES
    }
}
