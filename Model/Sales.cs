using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sales
    {
        #region VARIABLES
        private int userId;
        private int invoiceId;
        private int clientId;
        #endregion // end VARIABLES

        public Sales(){}

        #region CONSTRUCTOR
        public Sales(int userId, int invoiceId, int clientId)
        {
            this.userId = userId;
            this.invoiceId = invoiceId;
            this.clientId = clientId;
        }
        #endregion // end CONSTRUCTOR

        #region PROPERTIES
        public int UserId { get => userId; set => userId = value; }
        public int InvoiceId { get => invoiceId; set => invoiceId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        #endregion // end PROPERTIES
    }
}
