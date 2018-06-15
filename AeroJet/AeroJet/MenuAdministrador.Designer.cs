namespace AirFly
{
    partial class MenuAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.hide_Catalogos = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menuadmin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_CerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Catalogos = new System.Windows.Forms.Panel();
            this.btn_Vuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Tarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AeropuertoyRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Secciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Piloto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_PaisyCiudad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AerolineayAvion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Catalogos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Usuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show_Catalogos = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_menuadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Catalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // hide_Catalogos
            // 
            this.hide_Catalogos.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.hide_Catalogos.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.hide_Catalogos.DefaultAnimation = animation1;
            // 
            // pnl_Contenedor
            // 
            this.Show_Catalogos.SetDecoration(this.pnl_Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.pnl_Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor.Location = new System.Drawing.Point(226, 51);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(924, 584);
            this.pnl_Contenedor.TabIndex = 2;
            this.pnl_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Contenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.Show_Catalogos.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(226, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 51);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.hide_Catalogos.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(406, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fernando Andrade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.hide_Catalogos.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO ADMINISTRADOR:";
            // 
            // panel_menuadmin
            // 
            this.panel_menuadmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_menuadmin.BackgroundImage")));
            this.panel_menuadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menuadmin.Controls.Add(this.piclogo);
            this.panel_menuadmin.Controls.Add(this.pictureBox2);
            this.panel_menuadmin.Controls.Add(this.btn_CerrarSesion);
            this.panel_menuadmin.Controls.Add(this.pnl_Catalogos);
            this.panel_menuadmin.Controls.Add(this.btn_Catalogos);
            this.panel_menuadmin.Controls.Add(this.btn_Usuarios);
            this.panel_menuadmin.Controls.Add(this.pictureBox1);
            this.Show_Catalogos.SetDecoration(this.panel_menuadmin, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.panel_menuadmin, BunifuAnimatorNS.DecorationType.None);
            this.panel_menuadmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menuadmin.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel_menuadmin.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.panel_menuadmin.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(152)))), ((int)(((byte)(217)))));
            this.panel_menuadmin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panel_menuadmin.Location = new System.Drawing.Point(0, 0);
            this.panel_menuadmin.Name = "panel_menuadmin";
            this.panel_menuadmin.Quality = 10;
            this.panel_menuadmin.Size = new System.Drawing.Size(226, 635);
            this.panel_menuadmin.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.hide_Catalogos.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Activecolor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CerrarSesion.BorderRadius = 0;
            this.btn_CerrarSesion.ButtonText = "Cerrar Sesión";
            this.btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_CerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_CerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btn_CerrarSesion.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.Iconimage = global::AirFly.Properties.Resources.icons8_Paper_Plane_64;
            this.btn_CerrarSesion.Iconimage_right = global::AirFly.Properties.Resources.icons8_Exit_64;
            this.btn_CerrarSesion.Iconimage_right_Selected = global::AirFly.Properties.Resources.icons8_Exit_64;
            this.btn_CerrarSesion.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Paper_Plane_64;
            this.btn_CerrarSesion.IconMarginLeft = 0;
            this.btn_CerrarSesion.IconMarginRight = 0;
            this.btn_CerrarSesion.IconRightVisible = true;
            this.btn_CerrarSesion.IconRightZoom = 0D;
            this.btn_CerrarSesion.IconVisible = false;
            this.btn_CerrarSesion.IconZoom = 60D;
            this.btn_CerrarSesion.IsTab = false;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 591);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CerrarSesion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_CerrarSesion.selected = false;
            this.btn_CerrarSesion.Size = new System.Drawing.Size(226, 44);
            this.btn_CerrarSesion.TabIndex = 16;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CerrarSesion.Textcolor = System.Drawing.Color.White;
            this.btn_CerrarSesion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // pnl_Catalogos
            // 
            this.pnl_Catalogos.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Catalogos.Controls.Add(this.btn_Vuelo);
            this.pnl_Catalogos.Controls.Add(this.btn_Tarifa);
            this.pnl_Catalogos.Controls.Add(this.btn_AeropuertoyRuta);
            this.pnl_Catalogos.Controls.Add(this.btn_Secciones);
            this.pnl_Catalogos.Controls.Add(this.btn_Piloto);
            this.pnl_Catalogos.Controls.Add(this.btn_PaisyCiudad);
            this.pnl_Catalogos.Controls.Add(this.btn_AerolineayAvion);
            this.Show_Catalogos.SetDecoration(this.pnl_Catalogos, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.pnl_Catalogos, BunifuAnimatorNS.DecorationType.None);
            this.pnl_Catalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Catalogos.Location = new System.Drawing.Point(0, 201);
            this.pnl_Catalogos.Name = "pnl_Catalogos";
            this.pnl_Catalogos.Size = new System.Drawing.Size(226, 327);
            this.pnl_Catalogos.TabIndex = 7;
            this.pnl_Catalogos.Visible = false;
            this.pnl_Catalogos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SubConsulVuelos_Paint);
            // 
            // btn_Vuelo
            // 
            this.btn_Vuelo.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Vuelo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Vuelo.BorderRadius = 0;
            this.btn_Vuelo.ButtonText = "Vuelo";
            this.btn_Vuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Vuelo, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Vuelo, BunifuAnimatorNS.DecorationType.None);
            this.btn_Vuelo.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Vuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Vuelo.Iconimage = global::AirFly.Properties.Resources.icons8_Paper_Plane_64;
            this.btn_Vuelo.Iconimage_right = null;
            this.btn_Vuelo.Iconimage_right_Selected = null;
            this.btn_Vuelo.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Paper_Plane_64;
            this.btn_Vuelo.IconMarginLeft = 0;
            this.btn_Vuelo.IconMarginRight = 0;
            this.btn_Vuelo.IconRightVisible = true;
            this.btn_Vuelo.IconRightZoom = 0D;
            this.btn_Vuelo.IconVisible = true;
            this.btn_Vuelo.IconZoom = 60D;
            this.btn_Vuelo.IsTab = false;
            this.btn_Vuelo.Location = new System.Drawing.Point(25, 275);
            this.btn_Vuelo.Name = "btn_Vuelo";
            this.btn_Vuelo.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Vuelo.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Vuelo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Vuelo.selected = false;
            this.btn_Vuelo.Size = new System.Drawing.Size(201, 44);
            this.btn_Vuelo.TabIndex = 15;
            this.btn_Vuelo.Text = "Vuelo";
            this.btn_Vuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Vuelo.Textcolor = System.Drawing.Color.White;
            this.btn_Vuelo.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Tarifa
            // 
            this.btn_Tarifa.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Tarifa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Tarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tarifa.BorderRadius = 0;
            this.btn_Tarifa.ButtonText = "Tarifa del Asiento";
            this.btn_Tarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Tarifa, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Tarifa, BunifuAnimatorNS.DecorationType.None);
            this.btn_Tarifa.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Tarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Tarifa.Iconimage = global::AirFly.Properties.Resources.icons8_Pricing_64;
            this.btn_Tarifa.Iconimage_right = null;
            this.btn_Tarifa.Iconimage_right_Selected = null;
            this.btn_Tarifa.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Pricing_64;
            this.btn_Tarifa.IconMarginLeft = 0;
            this.btn_Tarifa.IconMarginRight = 0;
            this.btn_Tarifa.IconRightVisible = true;
            this.btn_Tarifa.IconRightZoom = 0D;
            this.btn_Tarifa.IconVisible = true;
            this.btn_Tarifa.IconZoom = 60D;
            this.btn_Tarifa.IsTab = false;
            this.btn_Tarifa.Location = new System.Drawing.Point(25, 229);
            this.btn_Tarifa.Name = "btn_Tarifa";
            this.btn_Tarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Tarifa.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Tarifa.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Tarifa.selected = false;
            this.btn_Tarifa.Size = new System.Drawing.Size(201, 44);
            this.btn_Tarifa.TabIndex = 13;
            this.btn_Tarifa.Text = "Tarifa del Asiento";
            this.btn_Tarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tarifa.Textcolor = System.Drawing.Color.White;
            this.btn_Tarifa.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AeropuertoyRuta
            // 
            this.btn_AeropuertoyRuta.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AeropuertoyRuta.BackColor = System.Drawing.Color.Transparent;
            this.btn_AeropuertoyRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AeropuertoyRuta.BorderRadius = 0;
            this.btn_AeropuertoyRuta.ButtonText = "Aeropuerto Y Ruta";
            this.btn_AeropuertoyRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_AeropuertoyRuta, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_AeropuertoyRuta, BunifuAnimatorNS.DecorationType.None);
            this.btn_AeropuertoyRuta.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_AeropuertoyRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AeropuertoyRuta.Iconimage = global::AirFly.Properties.Resources.icons8_Airport_32;
            this.btn_AeropuertoyRuta.Iconimage_right = null;
            this.btn_AeropuertoyRuta.Iconimage_right_Selected = null;
            this.btn_AeropuertoyRuta.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Airport_32;
            this.btn_AeropuertoyRuta.IconMarginLeft = 0;
            this.btn_AeropuertoyRuta.IconMarginRight = 0;
            this.btn_AeropuertoyRuta.IconRightVisible = true;
            this.btn_AeropuertoyRuta.IconRightZoom = 0D;
            this.btn_AeropuertoyRuta.IconVisible = true;
            this.btn_AeropuertoyRuta.IconZoom = 60D;
            this.btn_AeropuertoyRuta.IsTab = false;
            this.btn_AeropuertoyRuta.Location = new System.Drawing.Point(25, 91);
            this.btn_AeropuertoyRuta.Name = "btn_AeropuertoyRuta";
            this.btn_AeropuertoyRuta.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_AeropuertoyRuta.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AeropuertoyRuta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_AeropuertoyRuta.selected = false;
            this.btn_AeropuertoyRuta.Size = new System.Drawing.Size(201, 44);
            this.btn_AeropuertoyRuta.TabIndex = 12;
            this.btn_AeropuertoyRuta.Text = "Aeropuerto Y Ruta";
            this.btn_AeropuertoyRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AeropuertoyRuta.Textcolor = System.Drawing.Color.White;
            this.btn_AeropuertoyRuta.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AeropuertoyRuta.Click += new System.EventHandler(this.btn_AeropuertoyRuta_Click);
            // 
            // btn_Secciones
            // 
            this.btn_Secciones.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Secciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_Secciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Secciones.BorderRadius = 0;
            this.btn_Secciones.ButtonText = "Secciones Y Asientos";
            this.btn_Secciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Secciones, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Secciones, BunifuAnimatorNS.DecorationType.None);
            this.btn_Secciones.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Secciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Secciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Secciones.Iconimage")));
            this.btn_Secciones.Iconimage_right = null;
            this.btn_Secciones.Iconimage_right_Selected = null;
            this.btn_Secciones.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btn_Secciones.Iconimage_Selected")));
            this.btn_Secciones.IconMarginLeft = 0;
            this.btn_Secciones.IconMarginRight = 0;
            this.btn_Secciones.IconRightVisible = true;
            this.btn_Secciones.IconRightZoom = 0D;
            this.btn_Secciones.IconVisible = true;
            this.btn_Secciones.IconZoom = 60D;
            this.btn_Secciones.IsTab = false;
            this.btn_Secciones.Location = new System.Drawing.Point(25, 183);
            this.btn_Secciones.Name = "btn_Secciones";
            this.btn_Secciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Secciones.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Secciones.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Secciones.selected = false;
            this.btn_Secciones.Size = new System.Drawing.Size(201, 44);
            this.btn_Secciones.TabIndex = 11;
            this.btn_Secciones.Text = "Secciones Y Asientos";
            this.btn_Secciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Secciones.Textcolor = System.Drawing.Color.White;
            this.btn_Secciones.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Piloto
            // 
            this.btn_Piloto.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Piloto.BackColor = System.Drawing.Color.Transparent;
            this.btn_Piloto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Piloto.BorderRadius = 0;
            this.btn_Piloto.ButtonText = "Piloto";
            this.btn_Piloto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Piloto, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Piloto, BunifuAnimatorNS.DecorationType.None);
            this.btn_Piloto.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Piloto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Piloto.Iconimage = global::AirFly.Properties.Resources.icons8_Autopilot_64;
            this.btn_Piloto.Iconimage_right = null;
            this.btn_Piloto.Iconimage_right_Selected = null;
            this.btn_Piloto.Iconimage_Selected = null;
            this.btn_Piloto.IconMarginLeft = 0;
            this.btn_Piloto.IconMarginRight = 0;
            this.btn_Piloto.IconRightVisible = true;
            this.btn_Piloto.IconRightZoom = 0D;
            this.btn_Piloto.IconVisible = true;
            this.btn_Piloto.IconZoom = 60D;
            this.btn_Piloto.IsTab = false;
            this.btn_Piloto.Location = new System.Drawing.Point(25, 137);
            this.btn_Piloto.Name = "btn_Piloto";
            this.btn_Piloto.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Piloto.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Piloto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Piloto.selected = false;
            this.btn_Piloto.Size = new System.Drawing.Size(201, 44);
            this.btn_Piloto.TabIndex = 10;
            this.btn_Piloto.Text = "Piloto";
            this.btn_Piloto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Piloto.Textcolor = System.Drawing.Color.White;
            this.btn_Piloto.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Piloto.Click += new System.EventHandler(this.btn_Piloto_Click);
            // 
            // btn_PaisyCiudad
            // 
            this.btn_PaisyCiudad.Activecolor = System.Drawing.Color.Transparent;
            this.btn_PaisyCiudad.BackColor = System.Drawing.Color.Transparent;
            this.btn_PaisyCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PaisyCiudad.BorderRadius = 0;
            this.btn_PaisyCiudad.ButtonText = "País Y Ciudad";
            this.btn_PaisyCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_PaisyCiudad, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_PaisyCiudad, BunifuAnimatorNS.DecorationType.None);
            this.btn_PaisyCiudad.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_PaisyCiudad.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_PaisyCiudad.Iconimage = global::AirFly.Properties.Resources.icons8_Flag_2_32;
            this.btn_PaisyCiudad.Iconimage_right = null;
            this.btn_PaisyCiudad.Iconimage_right_Selected = null;
            this.btn_PaisyCiudad.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Flag_2_32;
            this.btn_PaisyCiudad.IconMarginLeft = 0;
            this.btn_PaisyCiudad.IconMarginRight = 0;
            this.btn_PaisyCiudad.IconRightVisible = true;
            this.btn_PaisyCiudad.IconRightZoom = 0D;
            this.btn_PaisyCiudad.IconVisible = true;
            this.btn_PaisyCiudad.IconZoom = 60D;
            this.btn_PaisyCiudad.IsTab = false;
            this.btn_PaisyCiudad.Location = new System.Drawing.Point(25, 46);
            this.btn_PaisyCiudad.Name = "btn_PaisyCiudad";
            this.btn_PaisyCiudad.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_PaisyCiudad.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_PaisyCiudad.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_PaisyCiudad.selected = false;
            this.btn_PaisyCiudad.Size = new System.Drawing.Size(201, 44);
            this.btn_PaisyCiudad.TabIndex = 7;
            this.btn_PaisyCiudad.Text = "País Y Ciudad";
            this.btn_PaisyCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PaisyCiudad.Textcolor = System.Drawing.Color.White;
            this.btn_PaisyCiudad.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PaisyCiudad.Click += new System.EventHandler(this.btn_PaisyCiudad_Click);
            // 
            // btn_AerolineayAvion
            // 
            this.btn_AerolineayAvion.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AerolineayAvion.BackColor = System.Drawing.Color.Transparent;
            this.btn_AerolineayAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AerolineayAvion.BorderRadius = 0;
            this.btn_AerolineayAvion.ButtonText = "Aerolínea Y Avión";
            this.btn_AerolineayAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_AerolineayAvion, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_AerolineayAvion, BunifuAnimatorNS.DecorationType.None);
            this.btn_AerolineayAvion.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_AerolineayAvion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AerolineayAvion.Iconimage = global::AirFly.Properties.Resources.icons8_Airplane_Take_Off_64;
            this.btn_AerolineayAvion.Iconimage_right = null;
            this.btn_AerolineayAvion.Iconimage_right_Selected = null;
            this.btn_AerolineayAvion.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Airplane_Take_Off_64;
            this.btn_AerolineayAvion.IconMarginLeft = 0;
            this.btn_AerolineayAvion.IconMarginRight = 0;
            this.btn_AerolineayAvion.IconRightVisible = true;
            this.btn_AerolineayAvion.IconRightZoom = 0D;
            this.btn_AerolineayAvion.IconVisible = true;
            this.btn_AerolineayAvion.IconZoom = 60D;
            this.btn_AerolineayAvion.IsTab = false;
            this.btn_AerolineayAvion.Location = new System.Drawing.Point(19, 6);
            this.btn_AerolineayAvion.Name = "btn_AerolineayAvion";
            this.btn_AerolineayAvion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_AerolineayAvion.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AerolineayAvion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_AerolineayAvion.selected = false;
            this.btn_AerolineayAvion.Size = new System.Drawing.Size(201, 44);
            this.btn_AerolineayAvion.TabIndex = 6;
            this.btn_AerolineayAvion.Text = "Aerolínea Y Avión";
            this.btn_AerolineayAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AerolineayAvion.Textcolor = System.Drawing.Color.White;
            this.btn_AerolineayAvion.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AerolineayAvion.Click += new System.EventHandler(this.btn_AerolineayAvion_Click);
            // 
            // btn_Catalogos
            // 
            this.btn_Catalogos.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Catalogos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Catalogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Catalogos.BorderRadius = 0;
            this.btn_Catalogos.ButtonText = "Catálogos";
            this.btn_Catalogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Catalogos, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Catalogos, BunifuAnimatorNS.DecorationType.None);
            this.btn_Catalogos.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Catalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Catalogos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Catalogos.Iconimage = global::AirFly.Properties.Resources.icons8_Open_32;
            this.btn_Catalogos.Iconimage_right = null;
            this.btn_Catalogos.Iconimage_right_Selected = null;
            this.btn_Catalogos.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Open_32;
            this.btn_Catalogos.IconMarginLeft = 0;
            this.btn_Catalogos.IconMarginRight = 0;
            this.btn_Catalogos.IconRightVisible = true;
            this.btn_Catalogos.IconRightZoom = 0D;
            this.btn_Catalogos.IconVisible = true;
            this.btn_Catalogos.IconZoom = 60D;
            this.btn_Catalogos.IsTab = false;
            this.btn_Catalogos.Location = new System.Drawing.Point(0, 161);
            this.btn_Catalogos.Name = "btn_Catalogos";
            this.btn_Catalogos.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Catalogos.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Catalogos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Catalogos.selected = false;
            this.btn_Catalogos.Size = new System.Drawing.Size(226, 40);
            this.btn_Catalogos.TabIndex = 6;
            this.btn_Catalogos.Text = "Catálogos";
            this.btn_Catalogos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Catalogos.Textcolor = System.Drawing.Color.White;
            this.btn_Catalogos.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Catalogos.Click += new System.EventHandler(this.btn_Catalogos_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Usuarios.BorderRadius = 0;
            this.btn_Usuarios.ButtonText = "Usuarios";
            this.btn_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Catalogos.SetDecoration(this.btn_Usuarios, BunifuAnimatorNS.DecorationType.None);
            this.hide_Catalogos.SetDecoration(this.btn_Usuarios, BunifuAnimatorNS.DecorationType.None);
            this.btn_Usuarios.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Usuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.Iconimage = global::AirFly.Properties.Resources.icons8_User_Account_32;
            this.btn_Usuarios.Iconimage_right = null;
            this.btn_Usuarios.Iconimage_right_Selected = null;
            this.btn_Usuarios.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_User_Account_32;
            this.btn_Usuarios.IconMarginLeft = 0;
            this.btn_Usuarios.IconMarginRight = 0;
            this.btn_Usuarios.IconRightVisible = true;
            this.btn_Usuarios.IconRightZoom = 0D;
            this.btn_Usuarios.IconVisible = true;
            this.btn_Usuarios.IconZoom = 60D;
            this.btn_Usuarios.IsTab = false;
            this.btn_Usuarios.Location = new System.Drawing.Point(0, 121);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Usuarios.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Usuarios.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Usuarios.selected = false;
            this.btn_Usuarios.Size = new System.Drawing.Size(226, 40);
            this.btn_Usuarios.TabIndex = 5;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Usuarios.Textcolor = System.Drawing.Color.White;
            this.btn_Usuarios.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hide_Catalogos.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Show_Catalogos
            // 
            this.Show_Catalogos.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.Show_Catalogos.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Show_Catalogos.DefaultAnimation = animation2;
            // 
            // piclogo
            // 
            this.piclogo.BackColor = System.Drawing.Color.Transparent;
            this.hide_Catalogos.SetDecoration(this.piclogo, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this.piclogo, BunifuAnimatorNS.DecorationType.None);
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(82, 7);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(76, 62);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 18;
            this.piclogo.TabStop = false;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 635);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menuadmin);
            this.hide_Catalogos.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Show_Catalogos.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_menuadmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Catalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel panel_menuadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Usuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Catalogos;
        private System.Windows.Forms.Panel pnl_Catalogos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Secciones;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Piloto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_PaisyCiudad;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AerolineayAvion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AeropuertoyRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Vuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Tarifa;
        private BunifuAnimatorNS.BunifuTransition Show_Catalogos;
        private BunifuAnimatorNS.BunifuTransition hide_Catalogos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CerrarSesion;
        private System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox piclogo;
    }
}