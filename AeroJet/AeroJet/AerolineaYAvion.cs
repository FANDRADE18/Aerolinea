using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Model;
using Datos.Servicios;

namespace AirFly
{
    public partial class AerolineaYAvion : Form
    {
        Aerolinea objAero;
        Avion objAvion;
        SrvAerolinea srvAero = new SrvAerolinea();
        SrvAvion srvAvion = new SrvAvion();
        string aer = "";
        string cla = "";
        string asi = "";
        string sel = "";
        string nom = "";
        public AerolineaYAvion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AerolineaYAvion_Load(object sender, EventArgs e)
        {
            ListarAerolinea();
            ListarAvion();
            txtAerolinea.Text = "Nombre de la Aerolínea";
            txtAerolinea.ForeColor = Color.DimGray;

            txtClase.Text = "Clase";
            txtClase.ForeColor = Color.DimGray;

            txtAsiento.Text = "Número de Asientos";
            txtAsiento.ForeColor = Color.DimGray;

            txtSeccion.Text = "Sección";
            txtSeccion.ForeColor = Color.DimGray;

            txtNomAvion.Text = "Nombre del Avión";
            txtNomAvion.ForeColor = Color.DimGray;

            LlenandoCombo();

            

            cbo_Aerolinea.PromptText = "Seleccionar Aerolinea";

            

        }

        public Aerolinea interfasesDatosAerolinea()
        {
            objAero = new Aerolinea();

            objAero.Nombre_Aerolinea = txtAerolinea.Text.Trim();

            return objAero;


        }

        public Avion interfasesDatosAvion()
        {
            objAvion = new Avion();

            objAvion.Nombre_Avion = txtNomAvion.Text.Trim();
            objAvion.Clase_Avion = txtClase.Text.Trim();
            objAvion.NumAsientos_Avion = Convert.ToInt32(txtAsiento.Text.Trim());
            objAvion.Secciones_Avion = txtSeccion.Text.Trim();
            objAvion.Id_Aerolinea = Convert.ToInt32(cbo_Aerolinea.SelectedValue);


            return objAvion;


        }
        public void ListarAerolinea()
        {
            dgv_Aerolinea.AutoGenerateColumns = false;
            dgv_Aerolinea.DataSource = srvAero.getListAerolinea();


        }
        public void ListarAvion()
        {
            dgv_Avion.AutoGenerateColumns = false;
            dgv_Avion.DataSource = srvAvion.getListAvion();


        }
        private void txtAerolinea_Enter(object sender, EventArgs e)
        {
            txtAerolinea.Text = "";
            txtAerolinea.ForeColor = Color.DimGray;
        }

        private void txtAerolinea_Leave(object sender, EventArgs e)
        {
            aer = txtAerolinea.Text;
            if (aer.Equals("Nombre de la Aerolínea"))
            {
                txtAerolinea.Text = "Nombre de la Aerolínea";
                txtAerolinea.ForeColor = Color.White;

            }
            else
            {
                if (aer.Equals(""))
                {

                    txtAerolinea.Text = "Nombre de la Aerolínea";
                    txtAerolinea.ForeColor = Color.DimGray;
                }
                else
                {
                    txtAerolinea.Text = aer;
                    txtAerolinea.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtClase_Enter(object sender, EventArgs e)
        {
            txtClase.Text = "";
            txtClase.ForeColor = Color.DimGray;
        }

        private void txtClase_Leave(object sender, EventArgs e)
        {
            cla = txtClase.Text;
            if (cla.Equals("Clase"))
            {
                txtClase.Text = "Clase";
                txtClase.ForeColor = Color.White;

            }
            else
            {
                if (cla.Equals(""))
                {

                    txtClase.Text = "Clase";
                    txtClase.ForeColor = Color.DimGray;
                }
                else
                {
                    txtClase.Text = cla;
                    txtClase.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtAsiento_Enter(object sender, EventArgs e)
        {
            txtAsiento.Text = "";
            txtAsiento.ForeColor = Color.DimGray;
        }

        private void txtAsiento_Leave(object sender, EventArgs e)
        {
            asi = txtAsiento.Text;
            if (asi.Equals("Número de Asientos"))
            {
                txtAsiento.Text = "Número de Asientos";
                txtAsiento.ForeColor = Color.White;

            }
            else
            {
                if (asi.Equals(""))
                {

                    txtAsiento.Text = "Número de Asientos";
                    txtAsiento.ForeColor = Color.DimGray;
                }
                else
                {
                    txtAsiento.Text = asi;
                    txtAsiento.ForeColor = Color.DimGray;
                }
            }
        }

        private void txtSeccion_Enter(object sender, EventArgs e)
        {
            txtSeccion.Text = "";
            txtSeccion.ForeColor = Color.DimGray;
        }

        private void txtSeccion_Leave(object sender, EventArgs e)
        {
            sel = txtSeccion.Text;
            if (sel.Equals("Sección"))
            {
                txtSeccion.Text = "Sección";
                txtSeccion.ForeColor = Color.White;

            }
            else
            {
                if (sel.Equals(""))
                {

                    txtSeccion.Text = "Sección";
                    txtSeccion.ForeColor = Color.DimGray;
                }
                else
                {
                    txtSeccion.Text = sel;
                    txtSeccion.ForeColor = Color.DimGray;
                }
            }
        }

        private void btn_AgregarAerolinea_Click(object sender, EventArgs e)
        {
            if (txtAerolinea.Text == "Nombre de la Aerolínea")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtAerolinea.Text == "")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                srvAero.AddAeroline(interfasesDatosAerolinea());

            }
        }

        public void LlenandoCombo()
        {
            //sirve para el llenado del combo box con la lista de los paises
            var lista = srvAero.getListAerolinea().ToList();

            if (lista.Count > 0)
            {
                
                cbo_Aerolinea.DataSource = lista;
                cbo_Aerolinea.DisplayMember = "Nombre_Aerolinea";

                cbo_Aerolinea.ValueMember = "Id_Aerolinea";
                if (cbo_Aerolinea.Items.Count > 0)
                {
                    cbo_Aerolinea.SelectedIndex = -1;


                }


            }
        }

            private void pnl_AerolineayAvion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarAvion_Click(object sender, EventArgs e)
        {
            if (txtNomAvion.Text == "Nombre del Avión" && txtClase.Text == "Clase" && txtAsiento.Text == "Número de Asientos" && txtSeccion.Text == "Sección")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtNomAvion.Text == "" && txtClase.Text == "" && txtAsiento.Text == "" && txtSeccion.Text == "")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                srvAvion.AddAvion(interfasesDatosAvion());
                
            }
        }

        private void txtNomAvion_Enter(object sender, EventArgs e)
        {
            txtNomAvion.Text = "";
            txtNomAvion.ForeColor = Color.DimGray;
        }

        private void txtNomAvion_Leave(object sender, EventArgs e)
        {
            nom = txtNomAvion.Text;
            if (nom.Equals("Nombre del Avión"))
            {
                txtNomAvion.Text = "Nombre del Avión";
                txtNomAvion.ForeColor = Color.White;

            }
            else
            {
                if (nom.Equals(""))
                {

                    txtNomAvion.Text = "Nombre del Avión";
                    txtNomAvion.ForeColor = Color.DimGray;
                }
                else
                {
                    txtNomAvion.Text = nom;
                    txtNomAvion.ForeColor = Color.DimGray;
                }
            }

        }
    }
}
