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
    public partial class Usuarios : Form
    {
        string nom = "";
        string apepat = "";
        string apemat = "";
        string direc = "";
        string cp = "";
        string email2 = "";
        string contra = "";
        string tele = "";
        public Usuarios()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GRB_DATOSUS_Enter(object sender, EventArgs e)
        {
            

        }

       
        private void GRB_DATOSUS_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.DimGray;

            txtApePaterno.Text = "Apellido Paterno";
            txtApePaterno.ForeColor = Color.DimGray;

            txtApeMaterno.Text = "Apellido Materno";
            txtApeMaterno.ForeColor = Color.DimGray;

            txtDireccion.Text = "Dirección";
            txtDireccion.ForeColor = Color.DimGray;

            txtCodigoPostal.Text = "Código Postal";
            txtCodigoPostal.ForeColor = Color.DimGray;

            txtTelefono.Text = "Teléfono";
            txtTelefono.ForeColor = Color.DimGray;

            txtEmail.Text = "E-Mail";
            txtEmail.ForeColor = Color.DimGray;

            txtContrasena.Text = "Contraseña";
            txtContrasena.ForeColor = Color.DimGray;
        }

        private void pnl_Usuarios_Paint(object sender, PaintEventArgs e)
        {

        }
       


       

        private void txtNombre1_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.DimGray;

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            nom = txtNombre.Text;
            if (nom.Equals("Nombre"))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;

            }
            else
            {
                if (nom.Equals(""))
                {

                    txtNombre.Text = "Nombre";
                    txtNombre.ForeColor = Color.DimGray;
                }
                else
                {
                    txtNombre.Text = nom;
                    txtNombre.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtApePaterno_Enter(object sender, EventArgs e)
        {
            txtApePaterno.Text = "";
            txtApePaterno.ForeColor = Color.DimGray;
        }

        private void txtApePaterno_Leave(object sender, EventArgs e)
        {
            apepat = txtApePaterno.Text;
            if (apepat.Equals("Apellido Paterno"))
            {
                txtApePaterno.Text = "Apellido Paterno";
                txtApePaterno.ForeColor = Color.DimGray;

            }
            else
            {
                if (apepat.Equals(""))
                {

                    txtApePaterno.Text = "Apellido Paterno";
                    txtApePaterno.ForeColor = Color.DimGray;
                }
                else
                {
                    txtApePaterno.Text = apepat;
                    txtApePaterno.ForeColor = Color.DimGray;
                }
            }
        }

      

       

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtDireccion.ForeColor = Color.DimGray;
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            direc = txtDireccion.Text;
            if (direc.Equals("Dirección"))
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.DimGray;

            }
            else
            {
                if (direc.Equals(""))
                {

                    txtDireccion.Text = "Dirección";
                    txtDireccion.ForeColor = Color.DimGray;
                }
                else
                {
                    txtDireccion.Text = direc;
                    txtDireccion.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtCodigoPostal_Enter(object sender, EventArgs e)
        {
            txtCodigoPostal.Text = "";
            txtCodigoPostal.ForeColor = Color.DimGray;
        }

        private void txtCodigoPostal_Leave(object sender, EventArgs e)
        {
            cp = txtCodigoPostal.Text;
            if (cp.Equals("Código Postal"))
            {
                txtCodigoPostal.Text = "Código Postal";
                txtCodigoPostal.ForeColor = Color.DimGray;

            }
            else
            {
                if (cp.Equals(""))
                {

                    txtCodigoPostal.Text = "Código Postal";
                    txtCodigoPostal.ForeColor = Color.DimGray;
                }
                else
                {
                    txtCodigoPostal.Text = cp;
                    txtCodigoPostal.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtApeMaterno_Leave(object sender, EventArgs e)
        {
            apemat = txtApeMaterno.Text;
            if (apemat.Equals("Apellido Materno"))
            {
                txtApeMaterno.Text = "Apellido Materno";
                txtApeMaterno.ForeColor = Color.DimGray;

            }
            else
            {
                if (apemat.Equals(""))
                {

                    txtApeMaterno.Text = "Apellido Materno";
                    txtApeMaterno.ForeColor = Color.DimGray;
                }
                else
                {
                    txtApeMaterno.Text = apemat;
                    txtApeMaterno.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtApeMaterno_Enter(object sender, EventArgs e)
        {
            txtApeMaterno.Text = "";
            txtApeMaterno.ForeColor = Color.DimGray;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
            txtTelefono.ForeColor = Color.DimGray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.DimGray;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtContrasena.ForeColor = Color.White;
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            tele = txtTelefono.Text;
            if (tele.Equals("Teléfono"))
            {
                txtTelefono.Text = "Teléfono";
                txtTelefono.ForeColor = Color.White;

            }
            else
            {
                if (tele.Equals(""))
                {

                    txtTelefono.Text = "Teléfono";
                    txtTelefono.ForeColor = Color.DimGray;
                }
                else
                {
                    txtTelefono.Text = tele;
                    txtTelefono.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            email2 = txtEmail.Text;
            if (email2.Equals("E-Mail"))
            {
                txtEmail.Text = "E-Mail";
                txtEmail.ForeColor = Color.DimGray;

            }
            else
            {
                if (email2.Equals(""))
                {

                    txtEmail.Text = "E-Mail";
                    txtEmail.ForeColor = Color.DimGray;
                }
                else
                {
                    txtEmail.Text = email2;
                    txtEmail.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            contra = txtContrasena.Text;
            if (contra.Equals("Contraseña"))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.DimGray;

            }
            else
            {
                if (contra.Equals(""))
                {

                    txtContrasena.Text = "Contraseña";
                    txtContrasena.ForeColor = Color.DimGray;
                }
                else
                {
                    txtContrasena.Text = contra;
                    txtContrasena.ForeColor = Color.DimGray;
                }
            }
        }
    }
}
