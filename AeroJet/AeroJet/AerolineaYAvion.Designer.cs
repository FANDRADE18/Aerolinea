namespace AirFly
{
    partial class AerolineaYAvion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_AerolineayAvion = new System.Windows.Forms.Panel();
            this.cbo_Aerolinea = new MetroFramework.Controls.MetroComboBox();
            this.txtSeccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAsiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Avion = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarAvion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EditarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_Aerolinea = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAerolinea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Aeroínea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomAvion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnl_AerolineayAvion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Avion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolinea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AerolineayAvion
            // 
            this.pnl_AerolineayAvion.Controls.Add(this.txtNomAvion);
            this.pnl_AerolineayAvion.Controls.Add(this.cbo_Aerolinea);
            this.pnl_AerolineayAvion.Controls.Add(this.txtSeccion);
            this.pnl_AerolineayAvion.Controls.Add(this.txtAsiento);
            this.pnl_AerolineayAvion.Controls.Add(this.txtClase);
            this.pnl_AerolineayAvion.Controls.Add(this.label1);
            this.pnl_AerolineayAvion.Controls.Add(this.dgv_Avion);
            this.pnl_AerolineayAvion.Controls.Add(this.bunifuFlatButton1);
            this.pnl_AerolineayAvion.Controls.Add(this.bunifuFlatButton2);
            this.pnl_AerolineayAvion.Controls.Add(this.btnAgregarAvion);
            this.pnl_AerolineayAvion.Controls.Add(this.panel1);
            this.pnl_AerolineayAvion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AerolineayAvion.Location = new System.Drawing.Point(0, 0);
            this.pnl_AerolineayAvion.Name = "pnl_AerolineayAvion";
            this.pnl_AerolineayAvion.Size = new System.Drawing.Size(924, 594);
            this.pnl_AerolineayAvion.TabIndex = 0;
            this.pnl_AerolineayAvion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_AerolineayAvion_Paint);
            // 
            // cbo_Aerolinea
            // 
            this.cbo_Aerolinea.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Aerolinea.BackColor = System.Drawing.Color.White;
            this.cbo_Aerolinea.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Aerolinea.FormattingEnabled = true;
            this.cbo_Aerolinea.ItemHeight = 23;
            this.cbo_Aerolinea.Location = new System.Drawing.Point(600, 328);
            this.cbo_Aerolinea.Name = "cbo_Aerolinea";
            this.cbo_Aerolinea.Size = new System.Drawing.Size(260, 29);
            this.cbo_Aerolinea.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Aerolinea.TabIndex = 144;
            this.cbo_Aerolinea.UseCustomBackColor = true;
            this.cbo_Aerolinea.UseCustomForeColor = true;
            this.cbo_Aerolinea.UseSelectable = true;
            this.cbo_Aerolinea.UseStyleColors = true;
            // 
            // txtSeccion
            // 
            this.txtSeccion.BackColor = System.Drawing.Color.White;
            this.txtSeccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtSeccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtSeccion.HintText = "";
            this.txtSeccion.isPassword = false;
            this.txtSeccion.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtSeccion.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtSeccion.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtSeccion.LineThickness = 4;
            this.txtSeccion.Location = new System.Drawing.Point(427, 323);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(145, 34);
            this.txtSeccion.TabIndex = 143;
            this.txtSeccion.Text = "Sección";
            this.txtSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeccion.Enter += new System.EventHandler(this.txtSeccion_Enter);
            this.txtSeccion.Leave += new System.EventHandler(this.txtSeccion_Leave);
            // 
            // txtAsiento
            // 
            this.txtAsiento.BackColor = System.Drawing.Color.White;
            this.txtAsiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.ForeColor = System.Drawing.Color.DimGray;
            this.txtAsiento.HintForeColor = System.Drawing.Color.Empty;
            this.txtAsiento.HintText = "";
            this.txtAsiento.isPassword = false;
            this.txtAsiento.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtAsiento.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtAsiento.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtAsiento.LineThickness = 4;
            this.txtAsiento.Location = new System.Drawing.Point(257, 323);
            this.txtAsiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(160, 34);
            this.txtAsiento.TabIndex = 142;
            this.txtAsiento.Text = "Número de Asientos";
            this.txtAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAsiento.Enter += new System.EventHandler(this.txtAsiento_Enter);
            this.txtAsiento.Leave += new System.EventHandler(this.txtAsiento_Leave);
            // 
            // txtClase
            // 
            this.txtClase.BackColor = System.Drawing.Color.White;
            this.txtClase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClase.ForeColor = System.Drawing.Color.DimGray;
            this.txtClase.HintForeColor = System.Drawing.Color.Empty;
            this.txtClase.HintText = "";
            this.txtClase.isPassword = false;
            this.txtClase.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtClase.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtClase.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtClase.LineThickness = 4;
            this.txtClase.Location = new System.Drawing.Point(108, 323);
            this.txtClase.Margin = new System.Windows.Forms.Padding(5);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(128, 34);
            this.txtClase.TabIndex = 141;
            this.txtClase.Text = "Clase";
            this.txtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClase.Enter += new System.EventHandler(this.txtClase_Enter);
            this.txtClase.Leave += new System.EventHandler(this.txtClase_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(64, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 140;
            this.label1.Text = "AVIÓN";
            // 
            // dgv_Avion
            // 
            this.dgv_Avion.AllowDrop = true;
            this.dgv_Avion.AllowUserToAddRows = false;
            this.dgv_Avion.AllowUserToDeleteRows = false;
            this.dgv_Avion.AllowUserToResizeColumns = false;
            this.dgv_Avion.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Avion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Avion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Avion.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Avion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Avion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Avion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Avion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Avion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomcol,
            this.dataGridViewTextBoxColumn2,
            this.numas,
            this.sec,
            this.ae});
            this.dgv_Avion.DoubleBuffered = true;
            this.dgv_Avion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Avion.EnableHeadersVisualStyles = false;
            this.dgv_Avion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Avion.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgv_Avion.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Avion.Location = new System.Drawing.Point(108, 383);
            this.dgv_Avion.MultiSelect = false;
            this.dgv_Avion.Name = "dgv_Avion";
            this.dgv_Avion.ReadOnly = true;
            this.dgv_Avion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Avion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Avion.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Avion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Avion.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Avion.RowTemplate.ReadOnly = true;
            this.dgv_Avion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Avion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Avion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Avion.Size = new System.Drawing.Size(548, 147);
            this.dgv_Avion.StandardTab = true;
            this.dgv_Avion.TabIndex = 130;
            this.dgv_Avion.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Eliminar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(713, 485);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(147, 45);
            this.bunifuFlatButton1.TabIndex = 139;
            this.bunifuFlatButton1.Text = "Eliminar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Editar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(713, 434);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(147, 39);
            this.bunifuFlatButton2.TabIndex = 138;
            this.bunifuFlatButton2.Text = "Editar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarAvion
            // 
            this.btnAgregarAvion.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarAvion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAvion.BorderRadius = 0;
            this.btnAgregarAvion.ButtonText = "Agregar";
            this.btnAgregarAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAvion.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAgregarAvion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarAvion.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarAvion.Iconimage_right = null;
            this.btnAgregarAvion.Iconimage_right_Selected = null;
            this.btnAgregarAvion.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarAvion.IconMarginLeft = 0;
            this.btnAgregarAvion.IconMarginRight = 0;
            this.btnAgregarAvion.IconRightVisible = true;
            this.btnAgregarAvion.IconRightZoom = 0D;
            this.btnAgregarAvion.IconVisible = true;
            this.btnAgregarAvion.IconZoom = 70D;
            this.btnAgregarAvion.IsTab = false;
            this.btnAgregarAvion.Location = new System.Drawing.Point(713, 385);
            this.btnAgregarAvion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarAvion.Name = "btnAgregarAvion";
            this.btnAgregarAvion.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarAvion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarAvion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnAgregarAvion.selected = false;
            this.btnAgregarAvion.Size = new System.Drawing.Size(147, 39);
            this.btnAgregarAvion.TabIndex = 137;
            this.btnAgregarAvion.Text = "Agregar";
            this.btnAgregarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarAvion.Textcolor = System.Drawing.Color.White;
            this.btnAgregarAvion.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAvion.Click += new System.EventHandler(this.btnAgregarAvion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_EliminarAerolinea);
            this.panel1.Controls.Add(this.btn_EditarAerolinea);
            this.panel1.Controls.Add(this.btn_AgregarAerolinea);
            this.panel1.Controls.Add(this.dgv_Aerolinea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAerolinea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 264);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_EliminarAerolinea
            // 
            this.btn_EliminarAerolinea.Activecolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAerolinea.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EliminarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarAerolinea.BorderRadius = 0;
            this.btn_EliminarAerolinea.ButtonText = "Eliminar";
            this.btn_EliminarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarAerolinea.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_EliminarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAerolinea.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btn_EliminarAerolinea.Iconimage_right = null;
            this.btn_EliminarAerolinea.Iconimage_right_Selected = null;
            this.btn_EliminarAerolinea.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btn_EliminarAerolinea.IconMarginLeft = 0;
            this.btn_EliminarAerolinea.IconMarginRight = 0;
            this.btn_EliminarAerolinea.IconRightVisible = true;
            this.btn_EliminarAerolinea.IconRightZoom = 0D;
            this.btn_EliminarAerolinea.IconVisible = true;
            this.btn_EliminarAerolinea.IconZoom = 70D;
            this.btn_EliminarAerolinea.IsTab = false;
            this.btn_EliminarAerolinea.Location = new System.Drawing.Point(713, 202);
            this.btn_EliminarAerolinea.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EliminarAerolinea.Name = "btn_EliminarAerolinea";
            this.btn_EliminarAerolinea.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EliminarAerolinea.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btn_EliminarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarAerolinea.selected = false;
            this.btn_EliminarAerolinea.Size = new System.Drawing.Size(147, 45);
            this.btn_EliminarAerolinea.TabIndex = 142;
            this.btn_EliminarAerolinea.Text = "Eliminar";
            this.btn_EliminarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarAerolinea.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_EditarAerolinea
            // 
            this.btn_EditarAerolinea.Activecolor = System.Drawing.Color.Transparent;
            this.btn_EditarAerolinea.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarAerolinea.BorderRadius = 0;
            this.btn_EditarAerolinea.ButtonText = "Editar";
            this.btn_EditarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarAerolinea.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_EditarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EditarAerolinea.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarAerolinea.Iconimage_right = null;
            this.btn_EditarAerolinea.Iconimage_right_Selected = null;
            this.btn_EditarAerolinea.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarAerolinea.IconMarginLeft = 0;
            this.btn_EditarAerolinea.IconMarginRight = 0;
            this.btn_EditarAerolinea.IconRightVisible = true;
            this.btn_EditarAerolinea.IconRightZoom = 0D;
            this.btn_EditarAerolinea.IconVisible = true;
            this.btn_EditarAerolinea.IconZoom = 70D;
            this.btn_EditarAerolinea.IsTab = false;
            this.btn_EditarAerolinea.Location = new System.Drawing.Point(713, 151);
            this.btn_EditarAerolinea.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EditarAerolinea.Name = "btn_EditarAerolinea";
            this.btn_EditarAerolinea.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarAerolinea.OnHovercolor = System.Drawing.Color.Gold;
            this.btn_EditarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EditarAerolinea.selected = false;
            this.btn_EditarAerolinea.Size = new System.Drawing.Size(147, 39);
            this.btn_EditarAerolinea.TabIndex = 141;
            this.btn_EditarAerolinea.Text = "Editar";
            this.btn_EditarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_EditarAerolinea.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AgregarAerolinea
            // 
            this.btn_AgregarAerolinea.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAerolinea.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarAerolinea.BorderRadius = 0;
            this.btn_AgregarAerolinea.ButtonText = "Agregar";
            this.btn_AgregarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAerolinea.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_AgregarAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAerolinea.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarAerolinea.Iconimage_right = null;
            this.btn_AgregarAerolinea.Iconimage_right_Selected = null;
            this.btn_AgregarAerolinea.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarAerolinea.IconMarginLeft = 0;
            this.btn_AgregarAerolinea.IconMarginRight = 0;
            this.btn_AgregarAerolinea.IconRightVisible = true;
            this.btn_AgregarAerolinea.IconRightZoom = 0D;
            this.btn_AgregarAerolinea.IconVisible = true;
            this.btn_AgregarAerolinea.IconZoom = 70D;
            this.btn_AgregarAerolinea.IsTab = false;
            this.btn_AgregarAerolinea.Location = new System.Drawing.Point(713, 102);
            this.btn_AgregarAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarAerolinea.Name = "btn_AgregarAerolinea";
            this.btn_AgregarAerolinea.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarAerolinea.OnHovercolor = System.Drawing.Color.Lime;
            this.btn_AgregarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarAerolinea.selected = false;
            this.btn_AgregarAerolinea.Size = new System.Drawing.Size(147, 39);
            this.btn_AgregarAerolinea.TabIndex = 140;
            this.btn_AgregarAerolinea.Text = "Agregar";
            this.btn_AgregarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarAerolinea.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAerolinea.Click += new System.EventHandler(this.btn_AgregarAerolinea_Click);
            // 
            // dgv_Aerolinea
            // 
            this.dgv_Aerolinea.AllowDrop = true;
            this.dgv_Aerolinea.AllowUserToAddRows = false;
            this.dgv_Aerolinea.AllowUserToDeleteRows = false;
            this.dgv_Aerolinea.AllowUserToResizeColumns = false;
            this.dgv_Aerolinea.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgv_Aerolinea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_Aerolinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aerolinea.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Aerolinea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Aerolinea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aerolinea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_Aerolinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aerolinea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aeroínea,
            this.aero});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Aerolinea.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Aerolinea.DoubleBuffered = true;
            this.dgv_Aerolinea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Aerolinea.EnableHeadersVisualStyles = false;
            this.dgv_Aerolinea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Aerolinea.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgv_Aerolinea.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Aerolinea.Location = new System.Drawing.Point(108, 105);
            this.dgv_Aerolinea.MultiSelect = false;
            this.dgv_Aerolinea.Name = "dgv_Aerolinea";
            this.dgv_Aerolinea.ReadOnly = true;
            this.dgv_Aerolinea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Aerolinea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aerolinea.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Aerolinea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgv_Aerolinea.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Aerolinea.RowTemplate.ReadOnly = true;
            this.dgv_Aerolinea.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aerolinea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Aerolinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Aerolinea.Size = new System.Drawing.Size(548, 147);
            this.dgv_Aerolinea.StandardTab = true;
            this.dgv_Aerolinea.TabIndex = 139;
            this.dgv_Aerolinea.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 138;
            this.label2.Text = "AEROLÍNEA";
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.BackColor = System.Drawing.Color.White;
            this.txtAerolinea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAerolinea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAerolinea.ForeColor = System.Drawing.Color.DimGray;
            this.txtAerolinea.HintForeColor = System.Drawing.Color.Empty;
            this.txtAerolinea.HintText = "";
            this.txtAerolinea.isPassword = false;
            this.txtAerolinea.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtAerolinea.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtAerolinea.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtAerolinea.LineThickness = 4;
            this.txtAerolinea.Location = new System.Drawing.Point(288, 53);
            this.txtAerolinea.Margin = new System.Windows.Forms.Padding(5);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(204, 34);
            this.txtAerolinea.TabIndex = 3;
            this.txtAerolinea.Text = "Nombre de la Aerolínea";
            this.txtAerolinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAerolinea.Enter += new System.EventHandler(this.txtAerolinea_Enter);
            this.txtAerolinea.Leave += new System.EventHandler(this.txtAerolinea_Leave);
            // 
            // Aeroínea
            // 
            this.Aeroínea.DataPropertyName = "Id_Aerolinea";
            this.Aeroínea.HeaderText = "Clave";
            this.Aeroínea.Name = "Aeroínea";
            this.Aeroínea.ReadOnly = true;
            // 
            // aero
            // 
            this.aero.DataPropertyName = "Nombre_Aerolinea";
            this.aero.HeaderText = "Aerolinea";
            this.aero.Name = "aero";
            this.aero.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Avion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomcol
            // 
            this.nomcol.DataPropertyName = "Nombre_Avion";
            this.nomcol.HeaderText = "Nombre";
            this.nomcol.Name = "nomcol";
            this.nomcol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Clase_Avion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Clase";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numas
            // 
            this.numas.DataPropertyName = "NumAsientos_Avion";
            this.numas.HeaderText = "No.Asiento";
            this.numas.Name = "numas";
            this.numas.ReadOnly = true;
            // 
            // sec
            // 
            this.sec.DataPropertyName = "Secciones_Avion";
            this.sec.HeaderText = "Sección";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            // 
            // ae
            // 
            this.ae.DataPropertyName = "Id_Aerolinea";
            this.ae.HeaderText = "Aerolínea";
            this.ae.Name = "ae";
            this.ae.ReadOnly = true;
            // 
            // txtNomAvion
            // 
            this.txtNomAvion.BackColor = System.Drawing.Color.White;
            this.txtNomAvion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomAvion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAvion.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomAvion.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomAvion.HintText = "";
            this.txtNomAvion.isPassword = false;
            this.txtNomAvion.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtNomAvion.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtNomAvion.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtNomAvion.LineThickness = 4;
            this.txtNomAvion.Location = new System.Drawing.Point(238, 279);
            this.txtNomAvion.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomAvion.Name = "txtNomAvion";
            this.txtNomAvion.Size = new System.Drawing.Size(235, 34);
            this.txtNomAvion.TabIndex = 145;
            this.txtNomAvion.Text = "Nombre del Avión";
            this.txtNomAvion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomAvion.Enter += new System.EventHandler(this.txtNomAvion_Enter);
            this.txtNomAvion.Leave += new System.EventHandler(this.txtNomAvion_Leave);
            // 
            // AerolineaYAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.pnl_AerolineayAvion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AerolineaYAvion";
            this.Text = "AerolineaYAvion";
            this.Load += new System.EventHandler(this.AerolineaYAvion_Load);
            this.pnl_AerolineayAvion.ResumeLayout(false);
            this.pnl_AerolineayAvion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Avion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AerolineayAvion;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAerolinea;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarAerolinea;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EditarAerolinea;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarAerolinea;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Aerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Avion;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarAvion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSeccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAsiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClase;
        private MetroFramework.Controls.MetroComboBox cbo_Aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aeroínea;
        private System.Windows.Forms.DataGridViewTextBoxColumn aero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ae;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomAvion;
    }
}