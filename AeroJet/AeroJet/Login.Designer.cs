namespace AirFly
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.redondeo_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.separador1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.separador2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_Perfil = new MetroFramework.Controls.MetroComboBox();
            this.btn_Salir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_registrar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_RegistrarseUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbo_ciudad = new MetroFramework.Controls.MetroComboBox();
            this.cbo_Pais = new MetroFramework.Controls.MetroComboBox();
            this.btn_irIniciarsesion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApeMaterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApePaterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnl_iniciar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_ir_registrarse = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Ver = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Iniciarsesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hide_iniciar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.show_iniciar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.hide_registrar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.show_registrar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_registrar.SuspendLayout();
            this.pnl_iniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ver)).BeginInit();
            this.SuspendLayout();
            // 
            // redondeo_Form
            // 
            this.redondeo_Form.ElipseRadius = 25;
            this.redondeo_Form.TargetControl = this;
            // 
            // separador1
            // 
            this.separador1.BackColor = System.Drawing.Color.Transparent;
            this.show_registrar.SetDecoration(this.separador1, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.separador1, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.separador1, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.separador1, BunifuAnimatorNS.DecorationType.None);
            this.separador1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.separador1.LineThickness = 5;
            this.separador1.Location = new System.Drawing.Point(45, 29);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(105, 3);
            this.separador1.TabIndex = 2;
            this.separador1.Transparency = 255;
            this.separador1.Vertical = false;
            // 
            // separador2
            // 
            this.separador2.BackColor = System.Drawing.Color.Transparent;
            this.show_registrar.SetDecoration(this.separador2, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.separador2, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.separador2, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.separador2, BunifuAnimatorNS.DecorationType.None);
            this.separador2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.separador2.LineThickness = 5;
            this.separador2.Location = new System.Drawing.Point(150, 29);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(105, 3);
            this.separador2.TabIndex = 3;
            this.separador2.Transparency = 255;
            this.separador2.Vertical = false;
            this.separador2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_Perfil);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.separador2);
            this.panel1.Controls.Add(this.separador1);
            this.show_registrar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 153);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbo_Perfil
            // 
            this.cbo_Perfil.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Perfil.BackColor = System.Drawing.Color.White;
            this.show_registrar.SetDecoration(this.cbo_Perfil, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.cbo_Perfil, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.cbo_Perfil, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.cbo_Perfil, BunifuAnimatorNS.DecorationType.None);
            this.cbo_Perfil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Perfil.FormattingEnabled = true;
            this.cbo_Perfil.ItemHeight = 23;
            this.cbo_Perfil.Location = new System.Drawing.Point(381, 103);
            this.cbo_Perfil.Name = "cbo_Perfil";
            this.cbo_Perfil.Size = new System.Drawing.Size(215, 29);
            this.cbo_Perfil.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Perfil.TabIndex = 113;
            this.cbo_Perfil.UseCustomBackColor = true;
            this.cbo_Perfil.UseCustomForeColor = true;
            this.cbo_Perfil.UseSelectable = true;
            this.cbo_Perfil.UseStyleColors = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.hide_registrar.SetDecoration(this.btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.btn_Salir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_Salir.Location = new System.Drawing.Point(283, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(23, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "X";
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.hide_registrar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::AirFly.Properties.Resources.AeroJet;
            this.pictureBox1.Location = new System.Drawing.Point(0, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_registrar);
            this.panel2.Controls.Add(this.pnl_iniciar);
            this.show_registrar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 432);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnl_registrar
            // 
            this.pnl_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.pnl_registrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_registrar.BackgroundImage")));
            this.pnl_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_registrar.Controls.Add(this.btn_RegistrarseUsuario);
            this.pnl_registrar.Controls.Add(this.cbo_ciudad);
            this.pnl_registrar.Controls.Add(this.cbo_Pais);
            this.pnl_registrar.Controls.Add(this.btn_irIniciarsesion);
            this.pnl_registrar.Controls.Add(this.txtEmail);
            this.pnl_registrar.Controls.Add(this.txtContrasena);
            this.pnl_registrar.Controls.Add(this.txtTelefono);
            this.pnl_registrar.Controls.Add(this.txtCodigoPostal);
            this.pnl_registrar.Controls.Add(this.txtDireccion);
            this.pnl_registrar.Controls.Add(this.txtApeMaterno);
            this.pnl_registrar.Controls.Add(this.txtApePaterno);
            this.pnl_registrar.Controls.Add(this.txtNombre);
            this.show_registrar.SetDecoration(this.pnl_registrar, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.pnl_registrar, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.pnl_registrar, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.pnl_registrar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_registrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_registrar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.pnl_registrar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.pnl_registrar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.pnl_registrar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.pnl_registrar.Location = new System.Drawing.Point(310, 0);
            this.pnl_registrar.Name = "pnl_registrar";
            this.pnl_registrar.Quality = 10;
            this.pnl_registrar.Size = new System.Drawing.Size(328, 432);
            this.pnl_registrar.TabIndex = 3;
            // 
            // btn_RegistrarseUsuario
            // 
            this.btn_RegistrarseUsuario.Activecolor = System.Drawing.Color.Transparent;
            this.btn_RegistrarseUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_RegistrarseUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegistrarseUsuario.BorderRadius = 0;
            this.btn_RegistrarseUsuario.ButtonText = "Registrar";
            this.btn_RegistrarseUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_registrar.SetDecoration(this.btn_RegistrarseUsuario, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_RegistrarseUsuario, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_RegistrarseUsuario, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.btn_RegistrarseUsuario, BunifuAnimatorNS.DecorationType.None);
            this.btn_RegistrarseUsuario.DisabledColor = System.Drawing.Color.White;
            this.btn_RegistrarseUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarseUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_RegistrarseUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarseUsuario.Iconimage")));
            this.btn_RegistrarseUsuario.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarseUsuario.Iconimage_right")));
            this.btn_RegistrarseUsuario.Iconimage_right_Selected = global::AirFly.Properties.Resources.icons8_Add_User_Male_64;
            this.btn_RegistrarseUsuario.Iconimage_Selected = null;
            this.btn_RegistrarseUsuario.IconMarginLeft = 0;
            this.btn_RegistrarseUsuario.IconMarginRight = 0;
            this.btn_RegistrarseUsuario.IconRightVisible = false;
            this.btn_RegistrarseUsuario.IconRightZoom = 0D;
            this.btn_RegistrarseUsuario.IconVisible = false;
            this.btn_RegistrarseUsuario.IconZoom = 60D;
            this.btn_RegistrarseUsuario.IsTab = false;
            this.btn_RegistrarseUsuario.Location = new System.Drawing.Point(100, 341);
            this.btn_RegistrarseUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RegistrarseUsuario.Name = "btn_RegistrarseUsuario";
            this.btn_RegistrarseUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_RegistrarseUsuario.OnHovercolor = System.Drawing.Color.White;
            this.btn_RegistrarseUsuario.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_RegistrarseUsuario.selected = false;
            this.btn_RegistrarseUsuario.Size = new System.Drawing.Size(119, 39);
            this.btn_RegistrarseUsuario.TabIndex = 115;
            this.btn_RegistrarseUsuario.Text = "Registrar";
            this.btn_RegistrarseUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RegistrarseUsuario.Textcolor = System.Drawing.Color.White;
            this.btn_RegistrarseUsuario.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbo_ciudad
            // 
            this.cbo_ciudad.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_ciudad.BackColor = System.Drawing.Color.White;
            this.show_registrar.SetDecoration(this.cbo_ciudad, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.cbo_ciudad, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.cbo_ciudad, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.cbo_ciudad, BunifuAnimatorNS.DecorationType.None);
            this.cbo_ciudad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_ciudad.FormattingEnabled = true;
            this.cbo_ciudad.ItemHeight = 23;
            this.cbo_ciudad.Location = new System.Drawing.Point(48, 208);
            this.cbo_ciudad.Name = "cbo_ciudad";
            this.cbo_ciudad.Size = new System.Drawing.Size(229, 29);
            this.cbo_ciudad.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_ciudad.TabIndex = 114;
            this.cbo_ciudad.UseCustomBackColor = true;
            this.cbo_ciudad.UseCustomForeColor = true;
            this.cbo_ciudad.UseSelectable = true;
            this.cbo_ciudad.UseStyleColors = true;
            // 
            // cbo_Pais
            // 
            this.cbo_Pais.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Pais.BackColor = System.Drawing.Color.White;
            this.show_registrar.SetDecoration(this.cbo_Pais, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.cbo_Pais, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.cbo_Pais, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.cbo_Pais, BunifuAnimatorNS.DecorationType.None);
            this.cbo_Pais.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Pais.FormattingEnabled = true;
            this.cbo_Pais.ItemHeight = 23;
            this.cbo_Pais.Location = new System.Drawing.Point(48, 141);
            this.cbo_Pais.Name = "cbo_Pais";
            this.cbo_Pais.Size = new System.Drawing.Size(229, 29);
            this.cbo_Pais.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Pais.TabIndex = 113;
            this.cbo_Pais.UseCustomBackColor = true;
            this.cbo_Pais.UseCustomForeColor = true;
            this.cbo_Pais.UseSelectable = true;
            this.cbo_Pais.UseStyleColors = true;
            // 
            // btn_irIniciarsesion
            // 
            this.btn_irIniciarsesion.AutoSize = true;
            this.btn_irIniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.hide_registrar.SetDecoration(this.btn_irIniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_irIniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.btn_irIniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_irIniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.btn_irIniciarsesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_irIniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btn_irIniciarsesion.Location = new System.Drawing.Point(114, 393);
            this.btn_irIniciarsesion.Name = "btn_irIniciarsesion";
            this.btn_irIniciarsesion.Size = new System.Drawing.Size(105, 18);
            this.btn_irIniciarsesion.TabIndex = 13;
            this.btn_irIniciarsesion.Text = "Iniciar Sesión";
            this.btn_irIniciarsesion.Click += new System.EventHandler(this.btn_irIniciarsesion_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtEmail, BunifuAnimatorNS.DecorationType.None);
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.White;
            this.txtEmail.LineIdleColor = System.Drawing.Color.White;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtEmail.LineThickness = 1;
            this.txtEmail.Location = new System.Drawing.Point(48, 265);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 30);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "E-Mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtContrasena, BunifuAnimatorNS.DecorationType.None);
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.HintForeColor = System.Drawing.Color.Empty;
            this.txtContrasena.HintText = "";
            this.txtContrasena.isPassword = false;
            this.txtContrasena.LineFocusedColor = System.Drawing.Color.White;
            this.txtContrasena.LineIdleColor = System.Drawing.Color.White;
            this.txtContrasena.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtContrasena.LineThickness = 1;
            this.txtContrasena.Location = new System.Drawing.Point(48, 293);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(229, 30);
            this.txtContrasena.TabIndex = 10;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtTelefono, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtTelefono, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtTelefono, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtTelefono, BunifuAnimatorNS.DecorationType.None);
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.White;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.White;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtTelefono.LineThickness = 1;
            this.txtTelefono.Location = new System.Drawing.Point(48, 233);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 30);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Text = "Teléfono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtCodigoPostal, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtCodigoPostal, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtCodigoPostal, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtCodigoPostal, BunifuAnimatorNS.DecorationType.None);
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostal.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoPostal.HintText = "";
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.White;
            this.txtCodigoPostal.LineIdleColor = System.Drawing.Color.White;
            this.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCodigoPostal.LineThickness = 1;
            this.txtCodigoPostal.Location = new System.Drawing.Point(48, 171);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(229, 30);
            this.txtCodigoPostal.TabIndex = 7;
            this.txtCodigoPostal.Text = "Código Postal";
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoPostal.Enter += new System.EventHandler(this.txtCodigoPostal_Enter);
            this.txtCodigoPostal.Leave += new System.EventHandler(this.txtCodigoPostal_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtDireccion, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtDireccion, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtDireccion, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtDireccion, BunifuAnimatorNS.DecorationType.None);
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDireccion.HintText = "";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.White;
            this.txtDireccion.LineIdleColor = System.Drawing.Color.White;
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtDireccion.LineThickness = 1;
            this.txtDireccion.Location = new System.Drawing.Point(48, 102);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 30);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtApeMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtApeMaterno, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtApeMaterno, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtApeMaterno, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtApeMaterno, BunifuAnimatorNS.DecorationType.None);
            this.txtApeMaterno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApeMaterno.ForeColor = System.Drawing.Color.White;
            this.txtApeMaterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApeMaterno.HintText = "";
            this.txtApeMaterno.isPassword = false;
            this.txtApeMaterno.LineFocusedColor = System.Drawing.Color.White;
            this.txtApeMaterno.LineIdleColor = System.Drawing.Color.White;
            this.txtApeMaterno.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtApeMaterno.LineThickness = 1;
            this.txtApeMaterno.Location = new System.Drawing.Point(48, 69);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(229, 30);
            this.txtApeMaterno.TabIndex = 3;
            this.txtApeMaterno.Text = "Apellido Materno";
            this.txtApeMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApeMaterno.Enter += new System.EventHandler(this.txtApeMaterno_Enter);
            this.txtApeMaterno.Leave += new System.EventHandler(this.txtApeMaterno_Leave);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtApePaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtApePaterno, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtApePaterno, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtApePaterno, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtApePaterno, BunifuAnimatorNS.DecorationType.None);
            this.txtApePaterno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApePaterno.ForeColor = System.Drawing.Color.White;
            this.txtApePaterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApePaterno.HintText = "";
            this.txtApePaterno.isPassword = false;
            this.txtApePaterno.LineFocusedColor = System.Drawing.Color.White;
            this.txtApePaterno.LineIdleColor = System.Drawing.Color.White;
            this.txtApePaterno.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtApePaterno.LineThickness = 1;
            this.txtApePaterno.Location = new System.Drawing.Point(48, 36);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(229, 30);
            this.txtApePaterno.TabIndex = 2;
            this.txtApePaterno.Text = "Apellido Paterno";
            this.txtApePaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApePaterno.Enter += new System.EventHandler(this.txtApePaterno_Enter);
            this.txtApePaterno.Leave += new System.EventHandler(this.txtApePaterno_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.txtNombre, BunifuAnimatorNS.DecorationType.None);
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.White;
            this.txtNombre.LineIdleColor = System.Drawing.Color.White;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtNombre.LineThickness = 1;
            this.txtNombre.Location = new System.Drawing.Point(48, 4);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // pnl_iniciar
            // 
            this.pnl_iniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_iniciar.BackgroundImage")));
            this.pnl_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iniciar.Controls.Add(this.btn_ir_registrarse);
            this.pnl_iniciar.Controls.Add(this.btn_Ver);
            this.pnl_iniciar.Controls.Add(this.btn_Iniciarsesion);
            this.pnl_iniciar.Controls.Add(this.txt_Contrasenia);
            this.pnl_iniciar.Controls.Add(this.bunifuMaterialTextbox2);
            this.pnl_iniciar.Controls.Add(this.txt_Usuario);
            this.pnl_iniciar.Controls.Add(this.bunifuMaterialTextbox1);
            this.show_registrar.SetDecoration(this.pnl_iniciar, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.pnl_iniciar, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.pnl_iniciar, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.pnl_iniciar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_iniciar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_iniciar.GradientBottomLeft = System.Drawing.Color.White;
            this.pnl_iniciar.GradientBottomRight = System.Drawing.Color.White;
            this.pnl_iniciar.GradientTopLeft = System.Drawing.Color.White;
            this.pnl_iniciar.GradientTopRight = System.Drawing.Color.White;
            this.pnl_iniciar.Location = new System.Drawing.Point(0, 0);
            this.pnl_iniciar.Name = "pnl_iniciar";
            this.pnl_iniciar.Quality = 10;
            this.pnl_iniciar.Size = new System.Drawing.Size(310, 432);
            this.pnl_iniciar.TabIndex = 2;
            this.pnl_iniciar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_iniciar_Paint);
            // 
            // btn_ir_registrarse
            // 
            this.btn_ir_registrarse.AutoSize = true;
            this.hide_registrar.SetDecoration(this.btn_ir_registrarse, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_ir_registrarse, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.btn_ir_registrarse, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_ir_registrarse, BunifuAnimatorNS.DecorationType.None);
            this.btn_ir_registrarse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ir_registrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_ir_registrarse.Location = new System.Drawing.Point(108, 362);
            this.btn_ir_registrarse.Name = "btn_ir_registrarse";
            this.btn_ir_registrarse.Size = new System.Drawing.Size(87, 18);
            this.btn_ir_registrarse.TabIndex = 0;
            this.btn_ir_registrarse.Text = "Registrarse";
            this.btn_ir_registrarse.Click += new System.EventHandler(this.btn_ir_registrarse_Click_1);
            // 
            // btn_Ver
            // 
            this.btn_Ver.BackColor = System.Drawing.Color.FloralWhite;
            this.show_registrar.SetDecoration(this.btn_Ver, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_Ver, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_Ver, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.btn_Ver, BunifuAnimatorNS.DecorationType.None);
            this.btn_Ver.Image = global::AirFly.Properties.Resources.icons8_Invisible_32;
            this.btn_Ver.ImageActive = global::AirFly.Properties.Resources.icons8_Eye_32;
            this.btn_Ver.Location = new System.Drawing.Point(236, 167);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(28, 30);
            this.btn_Ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Ver.TabIndex = 38;
            this.btn_Ver.TabStop = false;
            this.btn_Ver.Zoom = 10;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click_1);
            // 
            // btn_Iniciarsesion
            // 
            this.btn_Iniciarsesion.ActiveBorderThickness = 1;
            this.btn_Iniciarsesion.ActiveCornerRadius = 20;
            this.btn_Iniciarsesion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_Iniciarsesion.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Iniciarsesion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_Iniciarsesion.BackColor = System.Drawing.Color.White;
            this.btn_Iniciarsesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Iniciarsesion.BackgroundImage")));
            this.btn_Iniciarsesion.ButtonText = "Iniciar Sesión";
            this.btn_Iniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_registrar.SetDecoration(this.btn_Iniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.btn_Iniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.btn_Iniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.btn_Iniciarsesion, BunifuAnimatorNS.DecorationType.None);
            this.btn_Iniciarsesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciarsesion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Iniciarsesion.IdleBorderThickness = 1;
            this.btn_Iniciarsesion.IdleCornerRadius = 20;
            this.btn_Iniciarsesion.IdleFillColor = System.Drawing.Color.White;
            this.btn_Iniciarsesion.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_Iniciarsesion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.btn_Iniciarsesion.Location = new System.Drawing.Point(43, 265);
            this.btn_Iniciarsesion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Iniciarsesion.Name = "btn_Iniciarsesion";
            this.btn_Iniciarsesion.Size = new System.Drawing.Size(212, 47);
            this.btn_Iniciarsesion.TabIndex = 4;
            this.btn_Iniciarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Iniciarsesion.Click += new System.EventHandler(this.btn_Iniciarsesion_Click);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hide_registrar.SetDecoration(this.txt_Contrasenia, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.txt_Contrasenia, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txt_Contrasenia, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txt_Contrasenia, BunifuAnimatorNS.DecorationType.None);
            this.txt_Contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contrasenia.Location = new System.Drawing.Point(35, 175);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(229, 20);
            this.txt_Contrasenia.TabIndex = 3;
            this.txt_Contrasenia.Text = "Contraseña";
            this.txt_Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Contrasenia.Enter += new System.EventHandler(this.txt_Contrasenia_Enter_1);
            this.txt_Contrasenia.Leave += new System.EventHandler(this.txt_Contrasenia_Leave_1);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Enabled = false;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(35, 177);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(229, 27);
            this.bunifuMaterialTextbox2.TabIndex = 2;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hide_registrar.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.txt_Usuario, BunifuAnimatorNS.DecorationType.None);
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Usuario.Location = new System.Drawing.Point(35, 79);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(229, 20);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.Text = "Ejemplo@mail.com";
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Usuario.Enter += new System.EventHandler(this.txt_Usuario_Enter_1);
            this.txt_Usuario.Leave += new System.EventHandler(this.txt_Usuario_Leave_1);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.show_registrar.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.hide_registrar.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(180)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(35, 79);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(229, 30);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // hide_iniciar
            // 
            this.hide_iniciar.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.hide_iniciar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.hide_iniciar.DefaultAnimation = animation3;
            this.hide_iniciar.MaxAnimationTime = 1000;
            // 
            // show_iniciar
            // 
            this.show_iniciar.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.show_iniciar.Cursor = null;
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
            this.show_iniciar.DefaultAnimation = animation2;
            this.show_iniciar.MaxAnimationTime = 1000;
            // 
            // hide_registrar
            // 
            this.hide_registrar.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.hide_registrar.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.hide_registrar.DefaultAnimation = animation4;
            this.hide_registrar.MaxAnimationTime = 1000;
            // 
            // show_registrar
            // 
            this.show_registrar.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.show_registrar.Cursor = null;
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
            this.show_registrar.DefaultAnimation = animation1;
            this.show_registrar.MaxAnimationTime = 1000;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.hide_registrar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.show_registrar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.hide_iniciar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.show_iniciar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(-1, 48);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_registrar.ResumeLayout(false);
            this.pnl_registrar.PerformLayout();
            this.pnl_iniciar.ResumeLayout(false);
            this.pnl_iniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse redondeo_Form;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator separador2;
        private Bunifu.Framework.UI.BunifuSeparator separador1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_registrar;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_irIniciarsesion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContrasena;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApeMaterno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApePaterno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_iniciar;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_ir_registrarse;
        private Bunifu.Framework.UI.BunifuImageButton btn_Ver;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Iniciarsesion;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private BunifuAnimatorNS.BunifuTransition hide_registrar;
        private BunifuAnimatorNS.BunifuTransition hide_iniciar;
        private BunifuAnimatorNS.BunifuTransition show_iniciar;
        private BunifuAnimatorNS.BunifuTransition show_registrar;
        private System.Windows.Forms.Label btn_Salir;
        private MetroFramework.Controls.MetroComboBox cbo_ciudad;
        private MetroFramework.Controls.MetroComboBox cbo_Pais;
        private Bunifu.Framework.UI.BunifuFlatButton btn_RegistrarseUsuario;
        private MetroFramework.Controls.MetroComboBox cbo_Perfil;
    }
}

