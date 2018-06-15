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
    public partial class PaisyCiudad : Form
    {
        Pais objPais;
        Ciudad objCiudad;
        SrvCiudad srvCiudad = new SrvCiudad();
        SrvPais svrpais = new SrvPais();
        string pa = "";
        string ci = "";
        
        public PaisyCiudad()
        {
            InitializeComponent();
            
            
                
            
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            txtPais.Text = "";
            txtPais.ForeColor = Color.DimGray;
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            pa = txtPais.Text;
            if (pa.Equals("Nombre del País"))
            {
                txtPais.Text = "Nombre del País";
                txtPais.ForeColor = Color.DimGray;

            }
            else
            {
                if (pa.Equals(""))
                {

                    txtPais.Text = "Nombre del País";
                    txtPais.ForeColor = Color.DimGray;
                }
                else
                {
                    txtPais.Text = pa;
                    txtPais.ForeColor = Color.DimGray;
                }
            }
        }
        
private void PaisyCiudad_Load(object sender, EventArgs e)
        {
            
            ListarPais();
            ListarCiudad();
            txtPais.Text = "Nombre del País";
            txtPais.ForeColor = Color.DimGray;

            txtCiudad.Text = "Nombre de la Ciudad";
            txtCiudad.ForeColor = Color.DimGray;
            
            LlenandoCombo();
            cbo_Pais.PromptText = "Seleccionar País";
            
        }

        private void txtCiudad_Enter(object sender, EventArgs e)
        {
            txtCiudad.Text = "";
            txtCiudad.ForeColor = Color.DimGray;
        }

        private void txtCiudad_Leave(object sender, EventArgs e)
        {
            ci = txtCiudad.Text;
            if (ci.Equals("Nombre de la Ciudad"))
            {
                txtCiudad.Text = "Nombre de la Ciudad";
                txtCiudad.ForeColor = Color.DimGray;

            }
            else
            {
                if (ci.Equals(""))
                {

                    txtCiudad.Text = "Nombre de la Ciudad";
                    txtCiudad.ForeColor = Color.DimGray;
                }
                else
                {
                    txtCiudad.Text = ci;
                    txtCiudad.ForeColor = Color.DimGray;
                }
            }

        }
        public Pais interfasesDatosPais()
        {
            objPais = new Pais();

            objPais.Nombre_Pais = txtPais.Text.Trim();
          
            return objPais;


        }
        public Ciudad interfasesDatosCiudad()
        {
            objCiudad = new Ciudad();

            objCiudad.Nombre_Ciudad = txtCiudad.Text.Trim();
            objCiudad.Id_Pais = Convert.ToInt32(cbo_Pais.SelectedValue);

            return objCiudad;


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "Nombre del País")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(txtPais.Text == "")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                svrpais.AddPais(interfasesDatosPais());

            }

        }
        public void ListarPais()
        {
            dgvPais.AutoGenerateColumns = false;
            dgvPais.DataSource = svrpais.getListPais();


        }
        public void ListarCiudad()
        {
            dgvCiudad.AutoGenerateColumns = false;
            dgvCiudad.DataSource = srvCiudad.getListCiudad();


        }
        public void LlenandoCombo()
        {
            //sirve para el llenado del combo box con la lista de los paises
            var lista = svrpais.getListPais().ToList();
            
            if (lista.Count > 0)
            {



                cbo_Pais.DataSource = lista; 
                cbo_Pais.DisplayMember="Nombre_Pais";
                
                cbo_Pais.ValueMember = "Id_Pais";



                if (cbo_Pais.Items.Count > 0)
                {
                    cbo_Pais.SelectedIndex = -1;


                }





            }

        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "Nombre de la Ciudad")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtCiudad.Text == "")
            {
                MessageBox.Show("Llena todos los Campos", "AeroJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
            else
            {
                srvCiudad.AddCiudad(interfasesDatosCiudad());

            }
        }
    }


}
