using Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// tutorial del diseño del login https://youtu.be/en_eqatpDEo?list=PLqjdFmR_HdQRJrDT1cfa8e1TzuPcNw5Q6&t=180
// paleta de iconos https://www.flaticon.es/icon-fonts-mas-descargados
// todos los iconos https://www.flaticon.es
// todos los colores https://htmlcolorcodes.com/es/

// *** PALETA DE COLORES ***
// -fuente = Century Gothic; 10
// -texto normal = web -> LightGray
// -texto oscuro = web -> DimGray
// -texto acierto = 130; 193; 25
// -texto alerta = 203; 208; 54
// -texto fallido = 193; 48; 25
// -principal = 64; 169; 114 (Verde claro <decoracion>)
// -secundario = 8; 20; 14 (Verde oscuro <fondo>)
// -terciario = 43; 48; 42 (verde grisaceo <acciones>)
// -cuaternario = 75; 83; 73 (verde grisaceo claro <acciones hover>)
// -quintanarroense =  ( <>)

namespace AgroGest
{
    public partial class AgroGest_Login : Form
    {
        #region VARIABLES
        Users user = new Users();
        #endregion // end VARIABLES

        #region DLL
        // Sirve para poder arrastrar la ventada
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion // end DLL

        public AgroGest_Login()
        {
            InitializeComponent();
        }

        #region INIT COMPONENTS

        #endregion // end INIT COMPONENTS

        #region LOGIN COMPONENTS
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "EMAIL")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.LightGray;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "EMAIL";
                textBoxEmail.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "PASSWORD")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "PASSWORD";
                textBoxPassword.ForeColor = Color.DimGray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            // Selecciona el panel panelMain
            panelMain.Focus();
        }
        #endregion // end LOGIN COMPONENTS

        #region METHODS
        private void setStatusIcon(string message, string typeIcon)
        {
            try
            {
                switch (typeIcon.ToLower())
                {
                    case "success":
                        labelStatus.Visible = true;
                        setInvisibleAllIcon();
                        pictureBoxSuccess.Visible = true;
                        break;
                    case "alert":
                        labelStatus.Visible = true;
                        setInvisibleAllIcon();
                        pictureBoxAlert.Visible = true;
                        break;
                    case "error":
                        labelStatus.Visible = true;
                        setInvisibleAllIcon();
                        pictureBoxError.Visible = true;
                        break;
                    default:
                        MessageBox.Show("icon type is invalid");
                        break;
                }
                labelStatus.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Pone todos los iconos del estado en invisible
        /// </summary>
        private void setInvisibleAllIcon()
        {
            try
            {
                pictureBoxSuccess.Visible = false;
                pictureBoxAlert.Visible = false;
                pictureBoxError.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //setStatusIcon("The credentials are correct", "SUCCESS");
                //setStatusIcon("Error in the DB, try again", "ALERT");
                //setStatusIcon("The credentials are wrong", "ERROR");

                //var email = textBoxEmail.Text;
                //var password = textBoxPassword.Text;

                setStatusIcon("Loanding...", "ALERT");

                user.Email = textBoxEmail.Text;
                user.Password = textBoxPassword.Text;

                var json = $"{{\"email\":\"{user.Email}\",\"password\":\"{user.Password}\"}}";

                var userClient = new UsersDAO();
                var success = await userClient.checkLogin(json);

                if (success)
                {
                    setStatusIcon("The credentials are correct", "SUCCESS");

                    this.Hide();
                    AgroGest agroGest = new AgroGest(user);

                    if (agroGest.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else
                {
                    setStatusIcon("The credentials are wrong", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion // end METHODS
    }
}
