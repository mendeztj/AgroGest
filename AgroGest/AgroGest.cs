using Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AgroGest
{
    public partial class AgroGest : Form
    {
        #region VARIABLES
        Users user = new Users();
        FormUsers formUsers = new FormUsers();
        FormClients formClients = new FormClients();
        FormSettings formSettings = new FormSettings();
        #endregion // end VARIABLES

        #region DLL
        // Sirve para poder arrastrar la ventada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion // end DLL

        public AgroGest()
        {
            InitializeComponent();
            menuLeftActionColorButton("Home");
            initUserPanel();
        }

        public AgroGest(Users miUser)
        {
            InitializeComponent();
            this.user = miUser;
            menuLeftActionColorButton("Home");
            initUserPanel();
        }

        #region INIT COMPONENTS
        /// <summary>
        /// Dibuja una linea horizontal arriba del buttonLogOut en un panelLogOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMenuLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void initUserPanel()
        {
            if (user.Email != null)
            {
                labelUser.Text = user.Email;
            }
        }
        #endregion // end INIT COMPONENTS

        #region MAINFRAME COMPONENTS
        private void menuBarActionListener(object sender, EventArgs e)
        {
            try
            {
                PictureBox pb = (PictureBox)sender;
                string option = pb.Tag.ToString();

                if (option != null)
                {
                    switch (option.ToLower())
                    {
                        case "exit":
                            //this.DialogResult = DialogResult.Cancel;
                            //this.Close();
                            Application.Exit();
                            break;
                        case "maximize":
                            if (this.WindowState == FormWindowState.Maximized)
                            {
                                this.WindowState = FormWindowState.Normal;
                            }
                            else if (this.WindowState == FormWindowState.Normal)
                            {
                                this.WindowState = FormWindowState.Maximized;
                            }
                            break;
                        case "minimize":
                            this.WindowState = FormWindowState.Minimized;
                            break;
                        default:
                            MessageBox.Show("pictureBox tag is invalid");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            // Selecciona el panel panelMain
            panelInfoMenu.Focus();
        }

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
                        case "home":

                            break;
                        case "users":
                            if (formUsers != null)
                            {
                                // Muestra el "formUser"
                                formUsers.Visible = true;

                                // Añadir el formulario "FormUsers" al panel "panelMain"
                                panelMain.Controls.Clear();
                                panelMain.Controls.Add(formUsers);
                                formUsers.Show();
                                formUsers.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("The panel 'Users' not exist");
                            }
                            break;
                        case "clients":
                            if (formClients != null)
                            {
                                // Muestra el "formUser"
                                formClients.Visible = true;

                                // Añadir el formulario "formClients" al panel "panelMain"
                                panelMain.Controls.Clear();
                                panelMain.Controls.Add(formClients);
                                formClients.Show();
                                formClients.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("The panel 'Users' not exist");
                            }
                            break;
                        case "products":

                            break;
                        case "buys":

                            break;
                        case "sales":

                            break;
                        case "alerts":

                            break;
                        case "settings":
                            if (formSettings != null)
                            {
                                // Muestra el "formUser"
                                formSettings.Visible = true;

                                // Añadir el formulario "formSettings" al panel "panelMain"
                                panelMain.Controls.Clear();
                                panelMain.Controls.Add(formSettings);
                                formSettings.Show();
                                formSettings.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                MessageBox.Show("The panel 'Users' not exist");
                            }
                            break;
                        case "log out":
                            this.DialogResult = DialogResult.Cancel;
                            //this.Close();
                            //Application.Exit();
                            setInvisibleAllForms();
                            break;
                        default:
                            MessageBox.Show("button tag is invalid");
                            break;
                    }
                    menuLeftActionColorButton(option);
                    setPanelMenuInfo(option, i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion // end MAINFRAME COMPONENTS

        #region METHODS
        private void menuLeftActionColorButton(string option)
        {
            try
            {
                if (option != null)
                {
                    setInvisibleOptionButtons();

                    switch (option.ToLower())
                    {
                        case "home":
                            pictureBoxHome.Visible = true;
                            panelHome.BackColor = Color.FromArgb(88, 33, 99);
                            buttonHome.ForeColor = Color.FromArgb(235, 146, 222);
                            break;
                        case "users":
                            pictureBoxUsers.Visible = true;
                            panelUsers.BackColor = Color.FromArgb(42, 33, 99);
                            buttonUsers.ForeColor = Color.FromArgb(120, 92, 255);
                            break;
                        case "clients":
                            pictureBoxClients.Visible = true;
                            panelClients.BackColor = Color.FromArgb(99, 33, 75);
                            buttonClients.ForeColor = Color.FromArgb(249, 122, 153);
                            break;
                        case "products":
                            pictureBoxProducts.Visible = true;
                            panelProduct.BackColor = Color.FromArgb(33, 72, 99);
                            buttonProducts.ForeColor = Color.FromArgb(62, 208, 243);
                            break;
                        case "buys":
                            pictureBoxBuys.Visible = true;
                            panelBuys.BackColor = Color.FromArgb(98, 33, 99);
                            buttonBuys.ForeColor = Color.FromArgb(255, 104, 157);
                            break;
                        case "sales":
                            pictureBoxSales.Visible = true;
                            panelSales.BackColor = Color.FromArgb(33, 36, 99);
                            buttonSales.ForeColor = Color.FromArgb(128, 136, 255);
                            break;
                        case "alerts":
                            pictureBoxAlerts.Visible = true;
                            panelAlert.BackColor = Color.FromArgb(99, 87, 33);
                            buttonAlerts.ForeColor = Color.FromArgb(255, 191, 69);
                            break;
                        case "settings":
                            pictureBoxSettings.Visible = true;
                            panelSettings.BackColor = Color.FromArgb(33, 41, 99);
                            buttonSettings.ForeColor = Color.FromArgb(109, 159, 241);
                            break;
                        case "log out":
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

        private void setPanelMenuInfo(string textButton, Image imageIcon)
        {
            try
            {
                if (textButton != null && imageIcon != null)
                {
                    buttonInfo.Text = textButton;
                    buttonInfo.Image = imageIcon;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setInvisibleOptionButtons()
        {
            // Oculta todos las imagenes del menu lateral
            pictureBoxHome.Visible = false;
            pictureBoxUsers.Visible = false;
            pictureBoxClients.Visible = false;
            pictureBoxProducts.Visible = false;
            pictureBoxBuys.Visible = false;
            pictureBoxSales.Visible = false;
            pictureBoxAlerts.Visible = false;
            pictureBoxSettings.Visible = false;

            // Cambia el color de todos los botones al mismo color que el fondo
            panelHome.BackColor = Color.FromArgb(32, 18, 78);
            panelUsers.BackColor = Color.FromArgb(32, 18, 78);
            panelClients.BackColor = Color.FromArgb(32, 18, 78);
            panelProduct.BackColor = Color.FromArgb(32, 18, 78);
            panelBuys.BackColor = Color.FromArgb(32, 18, 78);
            panelSales.BackColor = Color.FromArgb(32, 18, 78);
            panelAlert.BackColor = Color.FromArgb(32, 18, 78);
            panelSettings.BackColor = Color.FromArgb(32, 18, 78);

            // Cambia al color del texto por defecto de los boton del menu lateral
            buttonHome.ForeColor = Color.DarkGray;
            buttonUsers.ForeColor = Color.DarkGray;
            buttonClients.ForeColor = Color.DarkGray;
            buttonProducts.ForeColor = Color.DarkGray;
            buttonBuys.ForeColor = Color.DarkGray;
            buttonBuys.ForeColor = Color.DarkGray;
            buttonAlerts.ForeColor = Color.DarkGray;
            buttonSettings.ForeColor = Color.DarkGray;
        }

        private void setInvisibleAllForms()
        {
            // Oculta todos los Form
            formUsers.Visible = false;
            formClients.Visible = false;
            formSettings.Visible = false;
        }
        #endregion // end METHODS
    }
}
