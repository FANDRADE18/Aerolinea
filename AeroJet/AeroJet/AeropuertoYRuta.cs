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
    public partial class AeropuertoYRuta : Form
    {
        string ar = "";
        Aeropuerto objAeropuerto;
        SrvAeropuerto srvaero = new SrvAeropuerto();

        public AeropuertoYRuta()
        {
            InitializeComponent();
        }

        private void AeropuertoYRuta_Load(object sender, EventArgs e)
        {
            txtAeropuerto.Text = "Nombre del Aeropuerto";
            txtAeropuerto.ForeColor = Color.DimGray;

            ListarAeropuerto();
            LlenandoCombo();
            cbo_Ciudad.PromptText = "Seleccionar Ciudad";
        }

        private void pnl_AeroRuta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAeropuerto_Enter(object sender, EventArgs e)
        {
            txtAeropuerto.Text = "";
            txtAeropuerto.ForeColor = Color.DimGray;
        }

        private void txtAeropuerto_Leave(object sender, EventArgs e)
        {
            ar = txtAeropuerto.Text;
            if (ar.Equals("Nombre del Aeropuerto"))
            {
                txtAeropuerto.Text = "Nombre del Aeropuerto";
                txtAeropuerto.ForeColor = Color.DimGray;

            }
            else
            {
                if (ar.Equals(""))
                {

                    txtAeropuerto.Text = "Nombre del Aeropuerto";
                    txtAeropuerto.ForeColor = Color.DimGray;
                }
                else
                {
                    txtAeropuerto.Text = ar;
                    txtAeropuerto.ForeColor = Color.DimGray;
                }
            }
        }

        public void ListarAeropuerto()
        {
            dgv_Aeropuerto.AutoGenerateColumns = false;
            dgv_Aeropuerto.DataSource = srvaero.getListAeropuerto();


        }
        public void LlenandoCombo()
        {
            SrvCiudad srvciu = new SrvCiudad();
            //sirve para el llenado del combo box con la lista de los paises
            var lista = srvciu.getListCiudad().ToList();

            if (lista.Count > 0)
            {



                cbo_Ciudad.DataSource = lista;
                cbo_Ciudad.DisplayMember = "Nombre_Ciudad";

                cbo_Ciudad.ValueMember = "Id_Ciudad";



                if (cbo_Ciudad.Items.Count > 0)
                {
                    cbo_Ciudad.SelectedIndex = -1;


                }





            }

        }
        public Aeropuerto interfasesDatosAeropuerto()
        {
            objAeropuerto = new Aeropuerto();

            objAeropuerto.Nombre_Aeropuerto = txtAeropuerto.Text.Trim();
            objAeropuerto.Id_Ciudad = Convert.ToInt32(cbo_Ciudad.SelectedValue);

            return objAeropuerto;


        }

        private void btn_AgregarAeropuerto_Click(object sender, EventArgs e)
        {
            if (txtAeropuerto.Text == "Nombre del Aeropuerto")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtAeropuerto.Text == "")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                srvaero.AddAeropuerto(interfasesDatosAeropuerto());

            }
        }
    }
}
