namespace AirFly
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Usuarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EditarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtContrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_Usuario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paiscolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudadcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApeMaterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApePaterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbo_Perfil = new MetroFramework.Controls.MetroComboBox();
            this.cbo_Pais = new MetroFramework.Controls.MetroComboBox();
            this.cbo_Ciudad = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonocolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Usuarios
            // 
            this.pnl_Usuarios.Controls.Add(this.label2);
            this.pnl_Usuarios.Controls.Add(this.btnEliminarUsuario);
            this.pnl_Usuarios.Controls.Add(this.btn_EditarUsuario);
            this.pnl_Usuarios.Controls.Add(this.btn_AgregarUsuario);
            this.pnl_Usuarios.Controls.Add(this.txtContrasena);
            this.pnl_Usuarios.Controls.Add(this.txtEmail);
            this.pnl_Usuarios.Controls.Add(this.dgv_Usuario);
            this.pnl_Usuarios.Controls.Add(this.txtTelefono);
            this.pnl_Usuarios.Controls.Add(this.txtCodigoPostal);
            this.pnl_Usuarios.Controls.Add(this.txtDireccion);
            this.pnl_Usuarios.Controls.Add(this.txtApeMaterno);
            this.pnl_Usuarios.Controls.Add(this.txtApePaterno);
            this.pnl_Usuarios.Controls.Add(this.txtNombre);
            this.pnl_Usuarios.Controls.Add(this.cbo_Perfil);
            this.pnl_Usuarios.Controls.Add(this.cbo_Pais);
            this.pnl_Usuarios.Controls.Add(this.cbo_Ciudad);
            this.pnl_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.pnl_Usuarios.Name = "pnl_Usuarios";
            this.pnl_Usuarios.Size = new System.Drawing.Size(924, 594);
            this.pnl_Usuarios.TabIndex = 0;
            this.pnl_Usuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Usuarios_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 150;
            this.label2.Text = "USUARIOS";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUsuario.BorderRadius = 0;
            this.btnEliminarUsuario.ButtonText = "Eliminar";
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.DisabledColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btnEliminarUsuario.Iconimage_right = null;
            this.btnEliminarUsuario.Iconimage_right_Selected = null;
            this.btnEliminarUsuario.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btnEliminarUsuario.IconMarginLeft = 0;
            this.btnEliminarUsuario.IconMarginRight = 0;
            this.btnEliminarUsuario.IconRightVisible = true;
            this.btnEliminarUsuario.IconRightZoom = 0D;
            this.btnEliminarUsuario.IconVisible = true;
            this.btnEliminarUsuario.IconZoom = 70D;
            this.btnEliminarUsuario.IsTab = false;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(549, 501);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnEliminarUsuario.selected = false;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(147, 39);
            this.btnEliminarUsuario.TabIndex = 145;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnEliminarUsuario.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Activecolor = System.Drawing.Color.Transparent;
            this.btn_EditarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarUsuario.BorderRadius = 0;
            this.btn_EditarUsuario.ButtonText = "Editar";
            this.btn_EditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarUsuario.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_EditarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EditarUsuario.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarUsuario.Iconimage_right = null;
            this.btn_EditarUsuario.Iconimage_right_Selected = null;
            this.btn_EditarUsuario.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarUsuario.IconMarginLeft = 0;
            this.btn_EditarUsuario.IconMarginRight = 0;
            this.btn_EditarUsuario.IconRightVisible = true;
            this.btn_EditarUsuario.IconRightZoom = 0D;
            this.btn_EditarUsuario.IconVisible = true;
            this.btn_EditarUsuario.IconZoom = 70D;
            this.btn_EditarUsuario.IsTab = false;
            this.btn_EditarUsuario.Location = new System.Drawing.Point(352, 501);
            this.btn_EditarUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EditarUsuario.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_EditarUsuario.selected = false;
            this.btn_EditarUsuario.Size = new System.Drawing.Size(147, 39);
            this.btn_EditarUsuario.TabIndex = 144;
            this.btn_EditarUsuario.Text = "Editar";
            this.btn_EditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditarUsuario.Textcolor = System.Drawing.Color.White;
            this.btn_EditarUsuario.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarUsuario.BorderRadius = 0;
            this.btn_AgregarUsuario.ButtonText = "Agregar";
            this.btn_AgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarUsuario.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_AgregarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarUsuario.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarUsuario.Iconimage_right = null;
            this.btn_AgregarUsuario.Iconimage_right_Selected = null;
            this.btn_AgregarUsuario.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarUsuario.IconMarginLeft = 0;
            this.btn_AgregarUsuario.IconMarginRight = 0;
            this.btn_AgregarUsuario.IconRightVisible = true;
            this.btn_AgregarUsuario.IconRightZoom = 0D;
            this.btn_AgregarUsuario.IconVisible = true;
            this.btn_AgregarUsuario.IconZoom = 70D;
            this.btn_AgregarUsuario.IsTab = false;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(158, 501);
            this.btn_AgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AgregarUsuario.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_AgregarUsuario.selected = false;
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(147, 39);
            this.btn_AgregarUsuario.TabIndex = 143;
            this.btn_AgregarUsuario.Text = "Agregar";
            this.btn_AgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarUsuario.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarUsuario.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.txtContrasena.HintForeColor = System.Drawing.Color.Empty;
            this.txtContrasena.HintText = "";
            this.txtContrasena.isPassword = false;
            this.txtContrasena.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtContrasena.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtContrasena.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtContrasena.LineThickness = 4;
            this.txtContrasena.Location = new System.Drawing.Point(486, 228);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(5);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(255, 34);
            this.txtContrasena.TabIndex = 114;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(177, 228);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 34);
            this.txtEmail.TabIndex = 113;
            this.txtEmail.Text = "E-Mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AllowDrop = true;
            this.dgv_Usuario.AllowUserToAddRows = false;
            this.dgv_Usuario.AllowUserToDeleteRows = false;
            this.dgv_Usuario.AllowUserToResizeColumns = false;
            this.dgv_Usuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Usuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Usuario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Ape_Paterno,
            this.ape_Materno,
            this.Direccion,
            this.Paiscolum,
            this.Ciudadcolum,
            this.cpcolumn,
            this.Telcolum,
            this.Emailcolum,
            this.ContraColumn,
            this.perfilcolumn});
            this.dgv_Usuario.DoubleBuffered = true;
            this.dgv_Usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Usuario.EnableHeadersVisualStyles = false;
            this.dgv_Usuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Usuario.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgv_Usuario.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Usuario.Location = new System.Drawing.Point(27, 298);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Usuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Usuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Usuario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Usuario.RowTemplate.ReadOnly = true;
            this.dgv_Usuario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(871, 182);
            this.dgv_Usuario.StandardTab = true;
            this.dgv_Usuario.TabIndex = 134;
            this.dgv_Usuario.TabStop = false;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Ape_Paterno
            // 
            this.Ape_Paterno.HeaderText = "Apellido Paterno";
            this.Ape_Paterno.Name = "Ape_Paterno";
            this.Ape_Paterno.ReadOnly = true;
            // 
            // ape_Materno
            // 
            this.ape_Materno.HeaderText = "Apellido Materno";
            this.ape_Materno.Name = "ape_Materno";
            this.ape_Materno.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Paiscolum
            // 
            this.Paiscolum.HeaderText = "País";
            this.Paiscolum.Name = "Paiscolum";
            this.Paiscolum.ReadOnly = true;
            // 
            // Ciudadcolum
            // 
            this.Ciudadcolum.HeaderText = "Ciudad";
            this.Ciudadcolum.Name = "Ciudadcolum";
            this.Ciudadcolum.ReadOnly = true;
            // 
            // cpcolumn
            // 
            this.cpcolumn.HeaderText = "C.P";
            this.cpcolumn.Name = "cpcolumn";
            this.cpcolumn.ReadOnly = true;
            // 
            // Telcolum
            // 
            this.Telcolum.HeaderText = "Teléfono";
            this.Telcolum.Name = "Telcolum";
            this.Telcolum.ReadOnly = true;
            // 
            // Emailcolum
            // 
            this.Emailcolum.HeaderText = "E-Mail";
            this.Emailcolum.Name = "Emailcolum";
            this.Emailcolum.ReadOnly = true;
            // 
            // ContraColumn
            // 
            this.ContraColumn.HeaderText = "Contraseña";
            this.ContraColumn.Name = "ContraColumn";
            this.ContraColumn.ReadOnly = true;
            // 
            // perfilcolumn
            // 
            this.perfilcolumn.HeaderText = "Perfil";
            this.perfilcolumn.Name = "perfilcolumn";
            this.perfilcolumn.ReadOnly = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefono.LineThickness = 4;
            this.txtTelefono.Location = new System.Drawing.Point(669, 124);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(204, 34);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Text = "Teléfono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BackColor = System.Drawing.Color.White;
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoPostal.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoPostal.HintText = "";
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtCodigoPostal.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtCodigoPostal.LineThickness = 4;
            this.txtCodigoPostal.Location = new System.Drawing.Point(527, 124);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(118, 34);
            this.txtCodigoPostal.TabIndex = 8;
            this.txtCodigoPostal.Text = "Código Postal";
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoPostal.Enter += new System.EventHandler(this.txtCodigoPostal_Enter);
            this.txtCodigoPostal.Leave += new System.EventHandler(this.txtCodigoPostal_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDireccion.HintText = "";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtDireccion.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtDireccion.LineThickness = 4;
            this.txtDireccion.Location = new System.Drawing.Point(527, 80);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(346, 34);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.BackColor = System.Drawing.Color.White;
            this.txtApeMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApeMaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApeMaterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApeMaterno.HintText = "";
            this.txtApeMaterno.isPassword = false;
            this.txtApeMaterno.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtApeMaterno.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtApeMaterno.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtApeMaterno.LineThickness = 4;
            this.txtApeMaterno.Location = new System.Drawing.Point(295, 124);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(5);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(204, 34);
            this.txtApeMaterno.TabIndex = 6;
            this.txtApeMaterno.Text = "Apellido Materno";
            this.txtApeMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApeMaterno.Enter += new System.EventHandler(this.txtApeMaterno_Enter);
            this.txtApeMaterno.Leave += new System.EventHandler(this.txtApeMaterno_Leave);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.BackColor = System.Drawing.Color.White;
            this.txtApePaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApePaterno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApePaterno.HintForeColor = System.Drawing.Color.Empty;
            this.txtApePaterno.HintText = "";
            this.txtApePaterno.isPassword = false;
            this.txtApePaterno.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtApePaterno.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtApePaterno.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtApePaterno.LineThickness = 4;
            this.txtApePaterno.Location = new System.Drawing.Point(67, 124);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(5);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(204, 34);
            this.txtApePaterno.TabIndex = 5;
            this.txtApePaterno.Text = "Apellido Paterno";
            this.txtApePaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApePaterno.Enter += new System.EventHandler(this.txtApePaterno_Enter);
            this.txtApePaterno.Leave += new System.EventHandler(this.txtApePaterno_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(67, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(432, 34);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre1_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // cbo_Perfil
            // 
            this.cbo_Perfil.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Perfil.BackColor = System.Drawing.Color.White;
            this.cbo_Perfil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Perfil.FormattingEnabled = true;
            this.cbo_Perfil.ItemHeight = 23;
            this.cbo_Perfil.Location = new System.Drawing.Point(67, 176);
            this.cbo_Perfil.Name = "cbo_Perfil";
            this.cbo_Perfil.Size = new System.Drawing.Size(215, 29);
            this.cbo_Perfil.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Perfil.TabIndex = 112;
            this.cbo_Perfil.UseCustomBackColor = true;
            this.cbo_Perfil.UseCustomForeColor = true;
            this.cbo_Perfil.UseSelectable = true;
            this.cbo_Perfil.UseStyleColors = true;
            // 
            // cbo_Pais
            // 
            this.cbo_Pais.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Pais.BackColor = System.Drawing.Color.White;
            this.cbo_Pais.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Pais.FormattingEnabled = true;
            this.cbo_Pais.ItemHeight = 23;
            this.cbo_Pais.Location = new System.Drawing.Point(339, 176);
            this.cbo_Pais.Name = "cbo_Pais";
            this.cbo_Pais.Size = new System.Drawing.Size(215, 29);
            this.cbo_Pais.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Pais.TabIndex = 109;
            this.cbo_Pais.UseCustomBackColor = true;
            this.cbo_Pais.UseCustomForeColor = true;
            this.cbo_Pais.UseSelectable = true;
            this.cbo_Pais.UseStyleColors = true;
            // 
            // cbo_Ciudad
            // 
            this.cbo_Ciudad.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Ciudad.BackColor = System.Drawing.Color.White;
            this.cbo_Ciudad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Ciudad.FormattingEnabled = true;
            this.cbo_Ciudad.ItemHeight = 23;
            this.cbo_Ciudad.Location = new System.Drawing.Point(615, 176);
            this.cbo_Ciudad.Name = "cbo_Ciudad";
            this.cbo_Ciudad.Size = new System.Drawing.Size(215, 29);
            this.cbo_Ciudad.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Ciudad.TabIndex = 111;
            this.cbo_Ciudad.UseCustomBackColor = true;
            this.cbo_Ciudad.UseCustomForeColor = true;
            this.cbo_Ciudad.UseSelectable = true;
            this.cbo_Ciudad.UseStyleColors = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // numas
            // 
            this.numas.HeaderText = "ApePat";
            this.numas.Name = "numas";
            this.numas.Width = 71;
            // 
            // sec
            // 
            this.sec.HeaderText = "ApeMat";
            this.sec.Name = "sec";
            this.sec.Width = 71;
            // 
            // dir
            // 
            this.dir.HeaderText = "Dirección";
            this.dir.Name = "dir";
            this.dir.Width = 71;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.Width = 71;
            // 
            // Ciu
            // 
            this.Ciu.HeaderText = "Ciudad";
            this.Ciu.Name = "Ciu";
            this.Ciu.Width = 70;
            // 
            // C_postal
            // 
            this.C_postal.HeaderText = "C.P";
            this.C_postal.Name = "C_postal";
            this.C_postal.Width = 71;
            // 
            // telefonocolumn
            // 
            this.telefonocolumn.HeaderText = "Teléfono";
            this.telefonocolumn.Name = "telefonocolumn";
            this.telefonocolumn.Width = 71;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 71;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.pnl_Usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.pnl_Usuarios.ResumeLayout(false);
            this.pnl_Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Usuarios;
        private MetroFramework.Controls.MetroComboBox cbo_Pais;
        private MetroFramework.Controls.MetroComboBox cbo_Perfil;
        private MetroFramework.Controls.MetroComboBox cbo_Ciudad;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Usuario;
        
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContrasena;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApeMaterno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApePaterno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EditarUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonocolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paiscolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudadcolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telcolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailcolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilcolumn;
    }
}