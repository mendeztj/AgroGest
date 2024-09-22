using Model;
using Styles;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AgroGest
{
    public partial class FormUsers : Form
    {
        #region VARIABLES
        Users user = new Users();
        UsersDAO userDAO = new UsersDAO();
        Style style = new Style();
        #endregion // end VARIABLES

        public FormUsers()
        {
            InitializeComponent();
            this.TopLevel = false;
            initColumnsInDataGridView();
            loadUsersData();
        }

        #region INIT COMPONENTS
        private void initColumnsInDataGridView()
        {
            // Agregar las columnas al control DataGridView
            dataGridViewUsers.Columns.Add("name", "Name");
            dataGridViewUsers.Columns.Add("role", "Role");
            dataGridViewUsers.Columns.Add("email", "Email");
            dataGridViewUsers.Columns.Add("cif", "Cif");

            // Añadir la columna "action" como una columna de imagen al DataGridView
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "action";
            column.HeaderText = "Action";
            dataGridViewUsers.Columns.Add(column);
        }
        #endregion // end INIT COMPONENTS

        #region MAINFRAME COMPONENTS

        #endregion // end MAINFRAME COMPONENTS

        #region METHODS
        private async void loadUsersData()
        {
            // Obtener la lista de usuarios
            List<Users> userList = await userDAO.getAllUsers();

            // Limpiar las filas del DataGridView
            dataGridViewUsers.Rows.Clear();

            if (userList != null)
            {
                // Añadir las filas con los datos de los usuarios
                foreach (Users u in userList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewUsers);
                    row.Cells[0].Value = u.Name;
                    row.Cells[1].Value = u.Role;
                    row.Cells[2].Value = u.Email;
                    row.Cells[3].Value = u.Email;
                    row.Cells[4].Value = u.Dni;
                    row.Cells[5].Value = u.Address;
                    row.Cells[6].Value = u.Password;

                    // Cargar la imagen y asignarla a una nueva celda de imagen
                    Image image = Image.FromFile("C:\\Users\\ivanb\\Documents\\Visual Studio Comunity\\AgroGest\\AgroGest\\images\\AgroGest_Logo.png");
                    DataGridViewImageCell cell = new DataGridViewImageCell();
                    cell.Value = image;

                    row.Cells[7] = cell; // Asignar la celda de imagen a la columna "action"

                    dataGridViewUsers.Rows.Add(row);
                }
            }
        }
        #endregion // end METHODS
    }
}
