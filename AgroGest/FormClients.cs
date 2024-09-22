using AgroGest.formAdditional.client;
using Model;
using Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AgroGest
{
    public partial class FormClients : Form
    {
        #region VARIABLES
        Clients client = new Clients();
        ClientsDAO clientDAO = new ClientsDAO();
        Style style = new Style();
        FormClientTabControl_Visual formClientTabControl_Visual = new FormClientTabControl_Visual();
        FormClientTabControl_Markdown formClientTabControl_Markdown = new FormClientTabControl_Markdown();
        #endregion // end VARIABLES

        public FormClients()
        {
            InitializeComponent();
            this.TopLevel = false;
            initButtonBoderRadius();
            initColumnsInDataGridView();

            selectFirstOptionInFilterMenuRight();

            //loadClientsData();

            Image iamge1 = Image.FromFile("..\\..\\images\\assets\\edit.png");
            Image iamge2 = Image.FromFile("..\\..\\images\\assets\\remove.png");
            pictureBoxSearch.Image = iamge2;
        }

        #region INIT COMPONENTS
        private void initColumnsInDataGridView()
        {
            // Agregar las columnas al control DataGridView
            dataGridViewClients.Columns.Add("name", "Name");
            dataGridViewClients.Columns.Add("email", "Email");
            dataGridViewClients.Columns.Add("telephone", "Telephone");
            dataGridViewClients.Columns.Add("adress", "Adress");

            // Añadir la columna "action" como una columna de imagen al DataGridView
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column.Name = "action";
            column.HeaderText = "Action";
            dataGridViewClients.Columns.Add(column);
        }

        private void initButtonBoderRadius()
        {
            style.SetButtonBorderRadius(buttonAddClient, 5);
            style.SetButtonBorderRadius(buttonApply, 5);
            style.SetButtonBorderRadius(buttonReset, 5);
        }
        #endregion // end INIT COMPONENTS

        #region MAINFRAME COMPONENTS
        private void menuLeftActionListener(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Image i = b.Image;
                string option = b.Tag.ToString();

                setInvisibleAllForms();

                if (option != null)
                {
                    switch (option.ToLower())
                    {
                        case "visual":
                            if (formClientTabControl_Visual != null)
                            {
                                // Muestra el "formUser"
                                formClientTabControl_Visual.Visible = true;

                                // Añadir el formulario "FormClientTabControl_Visual" al panel "panelFilterMainFrame"
                                panelFilterMainFrame.Controls.Clear();
                                panelFilterMainFrame.Controls.Add(formClientTabControl_Visual);
                                formClientTabControl_Visual.Show();
                                formClientTabControl_Visual.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("The panel " + formClientTabControl_Visual.Tag + " not exist");
                            }
                            break;
                        case "markdown":
                            if (formClientTabControl_Markdown != null)
                            {
                                // Muestra el "formUser"
                                formClientTabControl_Markdown.Visible = true;

                                // Añadir el formulario "FormClientTabControl_Markdown" al panel "panelFilterMainFrame"
                                panelFilterMainFrame.Controls.Clear();
                                panelFilterMainFrame.Controls.Add(formClientTabControl_Markdown);
                                formClientTabControl_Markdown.Show();
                                formClientTabControl_Markdown.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("The panel " + formClientTabControl_Markdown.Tag + " not exist");
                            }
                            break;
                        default:
                            MessageBox.Show("button tag is invalid");
                            break;
                    }
                    menuLeftActionColorButton(option);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion // end MAINFRAME COMPONENTS

        #region METHODS
        private void selectFirstOptionInFilterMenuRight()
        {
            try
            {
                if (formClientTabControl_Visual != null)
                {
                    // Muestra el "formUser"
                    formClientTabControl_Visual.Visible = true;

                    // Añadir el formulario "FormClientTabControl_Visual" al panel "panelFilterMainFrame"
                    panelFilterMainFrame.Controls.Clear();
                    panelFilterMainFrame.Controls.Add(formClientTabControl_Visual);
                    formClientTabControl_Visual.Show();
                    formClientTabControl_Visual.Dock = DockStyle.Fill;

                    menuLeftActionColorButton("visual");
                }
                else
                {
                    MessageBox.Show("The panel " + formClientTabControl_Visual.Tag + " not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuLeftActionColorButton(string option)
        {
            try
            {
                if (option != null)
                {
                    setInvisibleOptionButtons();

                    switch (option.ToLower())
                    {
                        case "visual":
                            pictureBoxVisual.Visible = true;
                            panelTabPage1.BackColor = Color.FromArgb(99, 33, 75);
                            buttonVisual.ForeColor = Color.FromArgb(249, 122, 153);
                            break;
                        case "markdown":
                            pictureBoxMarkdown.Visible = true;
                            panelTabPage2.BackColor = Color.FromArgb(99, 33, 75);
                            buttonMarkdown.ForeColor = Color.FromArgb(249, 122, 153);
                            break;
                        default:
                            MessageBox.Show("button color tag is invalid");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setInvisibleOptionButtons()
        {
            // Oculta todos las imagenes del tabControl
            pictureBoxVisual.Visible = false;
            pictureBoxMarkdown.Visible = false;

            // Cambia el color de todos los botones al mismo color que el fondo
            panelTabPage1.BackColor = Color.FromArgb(35, 20, 85);
            panelTabPage2.BackColor = Color.FromArgb(35, 20, 85);

            // Cambia al color del texto por defecto de los boton del menu lateral
            buttonVisual.ForeColor = Color.DarkGray;
            buttonMarkdown.ForeColor = Color.DarkGray;
        }

        private void setInvisibleAllForms()
        {
            // Oculta todos los Form
            formClientTabControl_Visual.Visible = false;
            formClientTabControl_Markdown.Visible = false;
        }

        private async void loadClientsData()
        {
            // Obtener la lista de clientes
            List<Clients> clientList = await clientDAO.getAllClients();

            // Limpiar las filas del DataGridView
            dataGridViewClients.Rows.Clear();

            if (clientList != null)
            {
                // Añadir las filas con los datos de los clientes
                foreach (Clients c in clientList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewClients);
                    row.Cells[0].Value = c.Name;
                    row.Cells[1].Value = c.Email;
                    row.Cells[2].Value = c.Telephone;
                    row.Cells[3].Value = c.Adress;

                    // Crear el control TableLayoutPanel y los PictureBox
                    TableLayoutPanel imagePanel = new TableLayoutPanel();
                    imagePanel.ColumnCount = 2;
                    PictureBox pictureBox1 = new PictureBox();
                    PictureBox pictureBox2 = new PictureBox();
                    imagePanel.Controls.Add(pictureBox1, 0, 0);
                    imagePanel.Controls.Add(pictureBox2, 1, 0);

                    // Cargar las imágenes desde archivos
                    Image image1 = Image.FromFile("..\\..\\images\\assets\\edit.png");
                    Image image2 = Image.FromFile("..\\..\\images\\assets\\remove.png");
                    pictureBox1.Image = image1;
                    pictureBox2.Image = image2;

                    // Crear la celda y asignar el control TableLayoutPanel a ella
                    DataGridViewCell cell = new DataGridViewImageCell();
                    cell.Value = imagePanel;

                    // Asignar la celda a la fila
                    row.Cells[dataGridViewClients.ColumnCount] = cell;

                    dataGridViewClients.Rows.Add(row);
                }
            }
        }
        #endregion // end METHODS
    }
}
