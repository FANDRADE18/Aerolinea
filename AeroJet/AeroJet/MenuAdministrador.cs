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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void pnl_SubConsulVuelos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Catalogos_Click(object sender, EventArgs e)
        {
            if (pnl_Catalogos.Visible)
            {
                hide_Catalogos.HideSync(pnl_Catalogos);
            }
            else
            {
                Show_Catalogos.ShowSync(pnl_Catalogos);

            }
        }

        private void pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Op1 = MessageBox.Show("¿ Desea Cerrar Su Sesión ?", "AereoMayab", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Op1 == DialogResult.OK)
            {
                login log = new login();
                this.Hide();
                log.Show();


            }
        }

        public void AbrirFormComoPanel(object FormPanel)
        {
            //es un metodo que servira para abrir forms en el panel contenedor 
            if (this.pnl_Contenedor.Controls.Count > 0)
                this.pnl_Contenedor.Controls.RemoveAt(0);
            Form Panel = FormPanel as Form;
            Panel.TopLevel = false;
            Panel.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(Panel);
            this.pnl_Contenedor.Tag = Panel;
            Panel.Show();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormComoPanel(new Usuarios());
        }

        private void btn_AerolineayAvion_Click(object sender, EventArgs e)
        {
            AbrirFormComoPanel(new AerolineaYAvion());
            hide_Catalogos.HideSync(pnl_Catalogos);
        }

        private void btn_PaisyCiudad_Click(object sender, EventArgs e)
        {
            AbrirFormComoPanel(new PaisyCiudad());
            hide_Catalogos.HideSync(pnl_Catalogos);
        }

        private void btn_AeropuertoyRuta_Click(object sender, EventArgs e)
        {
            AbrirFormComoPanel(new AeropuertoYRuta());
            hide_Catalogos.HideSync(pnl_Catalogos);
        }

        private void btn_Piloto_Click(object sender, EventArgs e)
        {
            AbrirFormComoPanel(new Piloto());
            hide_Catalogos.HideSync(pnl_Catalogos);
        }
    }
}
