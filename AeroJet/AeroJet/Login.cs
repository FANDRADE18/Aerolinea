using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirFly
{
    public partial class login : Form
    {
        string user = "";
        string pass = "";
        string nom = "";
        string apepat = "";
        string apemat = "";
        string direc = "";
        string cp = "";
        string tel = "";
        string email = "";
        string contra = "";


        public login()
        {
            InitializeComponent();
            this.Size = new Size(310, 585);

        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = "Ejemplo@mail.com";
            txt_Usuario.ForeColor = Color.SteelBlue;

            txt_Contrasenia.PasswordChar = '\0';
            txt_Contrasenia.Text = "Contraseña";
            txt_Contrasenia.ForeColor = Color.SteelBlue;

            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.White;

            txtApePaterno.Text = "Apellido Paterno";
            txtApePaterno.ForeColor = Color.White;

            txtApeMaterno.Text = "Apellido Materno";
            txtApeMaterno.ForeColor = Color.White;

            txtDireccion.Text = "Dirección";
            txtDireccion.ForeColor = Color.White;

            txtCodigoPostal.Text = "Código Postal";
            txtCodigoPostal.ForeColor = Color.White;

            txtTelefono.Text = "Teléfono";
            txtTelefono.ForeColor = Color.White;

            txtEmail.Text = "E-Mail";
            txtEmail.ForeColor = Color.White;

            txtContrasena.Text = "Contraseña";
            txtContrasena.ForeColor = Color.White;
        }
        
        private void btn_irIniciarsesion_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ir_registrarse_Click_1(object sender, EventArgs e)
        {
            separador2.LineColor = Color.RoyalBlue;
            separador1.LineColor = Color.Silver;
            hide_iniciar.HideSync(pnl_iniciar);
            show_registrar.ShowSync(pnl_registrar);
            

        }

        private void btn_irIniciarsesion_Click_1(object sender, EventArgs e)
        {
            separador1.LineColor = Color.RoyalBlue;
            separador2.LineColor = Color.Silver;
            hide_registrar.HideSync(pnl_registrar);
            show_iniciar.ShowSync(pnl_iniciar);
            


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Iniciarsesion_Click(object sender, EventArgs e)
        {
            MenuAdministrador menadmin = new MenuAdministrador();
            
            menadmin.Show();
            this.Hide();
        }

        private void pnl_iniciar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Usuario_Enter_1(object sender, EventArgs e)
        {
            txt_Usuario.Text = "";
            txt_Usuario.ForeColor = Color.SteelBlue;
        }

        private void txt_Usuario_Leave_1(object sender, EventArgs e)
        {
            user = txt_Usuario.Text;
            if (user.Equals("Ejemplo@mail.com"))
            {
                txt_Usuario.Text = "Ejemplo@mail.com";
                txt_Usuario.ForeColor = Color.SteelBlue;

            }
            else
            {
                if (user.Equals(""))
                {

                    txt_Usuario.Text = "Ejemplo@mail.com";
                    txt_Usuario.ForeColor = Color.SteelBlue;
                }
                else
                {
                    txt_Usuario.Text = user;
                    txt_Usuario.ForeColor = Color.SteelBlue;
                }
            }
        }

        private void txt_Contrasenia_Enter_1(object sender, EventArgs e)
        {
            txt_Contrasenia.Text = "";
            txt_Contrasenia.ForeColor = Color.SteelBlue;
            txt_Contrasenia.PasswordChar = '•';
        }

        private void txt_Contrasenia_Leave_1(object sender, EventArgs e)
        {
            pass = txt_Contrasenia.Text;
            if (pass.Equals("Contraseña"))
            {
                txt_Contrasenia.Text = "Contraseña";
                txt_Contrasenia.ForeColor = Color.SteelBlue;

            }
            else
            {
                if (pass.Equals(""))
                {
                    txt_Contrasenia.PasswordChar = '\0';
                    txt_Contrasenia.Text = "Contraseña";
                    txt_Contrasenia.ForeColor = Color.SteelBlue;
                }
                else
                {
                    txt_Contrasenia.PasswordChar = '•';
                    txt_Contrasenia.Text = pass;
                    txt_Contrasenia.ForeColor = Color.SteelBlue;
                }
            }
        }

        private void btn_Ver_Click_1(object sender, EventArgs e)
        {
            if (txt_Contrasenia.PasswordChar == '•')
            {
                txt_Contrasenia.PasswordChar = '\0';
            }
            else
            {
                txt_Contrasenia.PasswordChar = '•';
            }
            txt_Contrasenia.Focus();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.White;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            nom = txtNombre.Text;
            if (nom.Equals("Nombre"))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.White;

            }
            else
            {
                if (nom.Equals(""))
                {

                    txtNombre.Text = "Nombre";
                    txtNombre.ForeColor = Color.White;
                }
                else
                {
                    txtNombre.Text = nom;
                    txtNombre.ForeColor = Color.White;
                }
            }
        }
        private void txtApePaterno_Enter(object sender, EventArgs e)
        {
            txtApePaterno.Text = "";
            txtApePaterno.ForeColor = Color.White;
        }
        private void txtApePaterno_Leave(object sender, EventArgs e)
        {
            apepat = txtApePaterno.Text;
            if (apepat.Equals("Apellido Paterno"))
            {
                txtApePaterno.Text = "Apellido Paterno";
                txtApePaterno.ForeColor = Color.White;

            }
            else
            {
                if (apepat.Equals(""))
                {

                    txtApePaterno.Text = "Apellido Paterno";
                    txtApePaterno.ForeColor = Color.White;
                }
                else
                {
                    txtApePaterno.Text = apepat;
                    txtApePaterno.ForeColor = Color.White;
                }
            }
        }

        private void txtApeMaterno_Enter(object sender, EventArgs e)
        {
            txtApeMaterno.Text = "";
            txtApeMaterno.ForeColor = Color.White;

        }

        private void txtApeMaterno_Leave(object sender, EventArgs e)
        {
            apemat = txtApeMaterno.Text;
            if (apemat.Equals("Apellido Materno"))
            {
                txtApeMaterno.Text = "Apellido Materno";
                txtApeMaterno.ForeColor = Color.White;

            }
            else
            {
                if (apemat.Equals(""))
                {

                    txtApeMaterno.Text = "Apellido Materno";
                    txtApeMaterno.ForeColor = Color.White;
                }
                else
                {
                    txtApeMaterno.Text = apemat;
                    txtApeMaterno.ForeColor = Color.White;
                }
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtDireccion.ForeColor = Color.White;

        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            direc = txtDireccion.Text;
            if (direc.Equals("Dirección"))
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.White;

            }
            else
            {
                if (direc.Equals(""))
                {

                    txtDireccion.Text = "Dirección";
                    txtDireccion.ForeColor = Color.White;
                }
                else
                {
                    txtDireccion.Text = direc;
                    txtDireccion.ForeColor = Color.White;
                }
            }
        }

        private void txtCodigoPostal_Enter(object sender, EventArgs e)
        {
            txtCodigoPostal.Text = "";
            txtCodigoPostal.ForeColor = Color.White;
        }

        private void txtCodigoPostal_Leave(object sender, EventArgs e)
        {
            cp = txtCodigoPostal.Text;
            if (cp.Equals("Código Postal"))
            {
                txtCodigoPostal.Text = "Código Postal";
                txtCodigoPostal.ForeColor = Color.White;

            }
            else
            {
                if (cp.Equals(""))
                {

                    txtCodigoPostal.Text = "Código Postal";
                    txtCodigoPostal.ForeColor = Color.White;
                }
                else
                {
                    txtCodigoPostal.Text = cp;
                    txtCodigoPostal.ForeColor = Color.White;
                }
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
            txtTelefono.ForeColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.White;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtContrasena.ForeColor = Color.White;

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            tel = txtTelefono.Text;
            if (tel.Equals("Teléfono"))
            {
                txtTelefono.Text = "Teléfono";
                txtTelefono.ForeColor = Color.White;

            }
            else
            {
                if (tel.Equals(""))
                {

                    txtTelefono.Text = "Teléfono";
                    txtTelefono.ForeColor = Color.White;
                }
                else
                {
                    txtTelefono.Text = tel;
                    txtTelefono.ForeColor = Color.White;
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            if (email.Equals("E-Mail"))
            {
                txtEmail.Text = "E-Mail";
                txtEmail.ForeColor = Color.White;

            }
            else
            {
                if (email.Equals(""))
                {

                    txtEmail.Text = "E-Mail";
                    txtEmail.ForeColor = Color.White;
                }
                else
                {
                    txtEmail.Text = email;
                    txtEmail.ForeColor = Color.White;
                }
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            contra = txtContrasena.Text;
            if (contra.Equals("Contraseña"))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.White;

            }
            else
            {
                if (contra.Equals(""))
                {

                    txtContrasena.Text = "Contraseña";
                    txtContrasena.ForeColor = Color.White;
                }
                else
                {
                    txtContrasena.Text = contra;
                    txtContrasena.ForeColor = Color.White;
                }
            }
        }
    } 
} 

