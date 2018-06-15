namespace AirFly
{
    partial class AeropuertoYRuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_AeroRuta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Aeropuerto = new MetroFramework.Controls.MetroComboBox();
            this.cbo_Ciudad = new MetroFramework.Controls.MetroComboBox();
            this.btn_EliminarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EditarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_Aeropuerto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtAeropuerto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomRuta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKilometros = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_Ruta = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnEliminarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl_AeroRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ruta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AeroRuta
            // 
            this.pnl_AeroRuta.Controls.Add(this.dateTimePicker1);
            this.pnl_AeroRuta.Controls.Add(this.label1);
            this.pnl_AeroRuta.Controls.Add(this.label2);
            this.pnl_AeroRuta.Controls.Add(this.cbo_Aeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.cbo_Ciudad);
            this.pnl_AeroRuta.Controls.Add(this.btn_EliminarAeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.btn_EditarAeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.btn_AgregarAeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.dgv_Aeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.txtAeropuerto);
            this.pnl_AeroRuta.Controls.Add(this.txtNomRuta);
            this.pnl_AeroRuta.Controls.Add(this.txtKilometros);
            this.pnl_AeroRuta.Controls.Add(this.dgv_Ruta);
            this.pnl_AeroRuta.Controls.Add(this.btnEliminarRuta);
            this.pnl_AeroRuta.Controls.Add(this.btnEditarRuta);
            this.pnl_AeroRuta.Controls.Add(this.btnAgregarRuta);
            this.pnl_AeroRuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AeroRuta.Location = new System.Drawing.Point(0, 0);
            this.pnl_AeroRuta.Name = "pnl_AeroRuta";
            this.pnl_AeroRuta.Size = new System.Drawing.Size(908, 545);
            this.pnl_AeroRuta.TabIndex = 0;
            this.pnl_AeroRuta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_AeroRuta_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 161;
            this.label1.Text = "AEROPUERTO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(22, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 160;
            this.label2.Text = "RUTA";
            // 
            // cbo_Aeropuerto
            // 
            this.cbo_Aeropuerto.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Aeropuerto.BackColor = System.Drawing.Color.White;
            this.cbo_Aeropuerto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Aeropuerto.FormattingEnabled = true;
            this.cbo_Aeropuerto.ItemHeight = 23;
            this.cbo_Aeropuerto.Location = new System.Drawing.Point(676, 317);
            this.cbo_Aeropuerto.Name = "cbo_Aeropuerto";
            this.cbo_Aeropuerto.Size = new System.Drawing.Size(174, 29);
            this.cbo_Aeropuerto.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Aeropuerto.TabIndex = 159;
            this.cbo_Aeropuerto.UseCustomBackColor = true;
            this.cbo_Aeropuerto.UseCustomForeColor = true;
            this.cbo_Aeropuerto.UseSelectable = true;
            this.cbo_Aeropuerto.UseStyleColors = true;
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
            this.cbo_Ciudad.Location = new System.Drawing.Point(472, 49);
            this.cbo_Ciudad.Name = "cbo_Ciudad";
            this.cbo_Ciudad.PromptText = "Seleccionar Ciudad";
            this.cbo_Ciudad.Size = new System.Drawing.Size(174, 29);
            this.cbo_Ciudad.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Ciudad.TabIndex = 158;
            this.cbo_Ciudad.UseCustomBackColor = true;
            this.cbo_Ciudad.UseCustomForeColor = true;
            this.cbo_Ciudad.UseSelectable = true;
            this.cbo_Ciudad.UseStyleColors = true;
            // 
            // btn_EliminarAeropuerto
            // 
            this.btn_EliminarAeropuerto.Activecolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAeropuerto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EliminarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarAeropuerto.BorderRadius = 0;
            this.btn_EliminarAeropuerto.ButtonText = "Eliminar";
            this.btn_EliminarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarAeropuerto.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_EliminarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAeropuerto.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btn_EliminarAeropuerto.Iconimage_right = null;
            this.btn_EliminarAeropuerto.Iconimage_right_Selected = null;
            this.btn_EliminarAeropuerto.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btn_EliminarAeropuerto.IconMarginLeft = 0;
            this.btn_EliminarAeropuerto.IconMarginRight = 0;
            this.btn_EliminarAeropuerto.IconRightVisible = true;
            this.btn_EliminarAeropuerto.IconRightZoom = 0D;
            this.btn_EliminarAeropuerto.IconVisible = true;
            this.btn_EliminarAeropuerto.IconZoom = 70D;
            this.btn_EliminarAeropuerto.IsTab = false;
            this.btn_EliminarAeropuerto.Location = new System.Drawing.Point(703, 193);
            this.btn_EliminarAeropuerto.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EliminarAeropuerto.Name = "btn_EliminarAeropuerto";
            this.btn_EliminarAeropuerto.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EliminarAeropuerto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EliminarAeropuerto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_EliminarAeropuerto.selected = false;
            this.btn_EliminarAeropuerto.Size = new System.Drawing.Size(147, 45);
            this.btn_EliminarAeropuerto.TabIndex = 157;
            this.btn_EliminarAeropuerto.Text = "Eliminar";
            this.btn_EliminarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarAeropuerto.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_EditarAeropuerto
            // 
            this.btn_EditarAeropuerto.Activecolor = System.Drawing.Color.Transparent;
            this.btn_EditarAeropuerto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarAeropuerto.BorderRadius = 0;
            this.btn_EditarAeropuerto.ButtonText = "Editar";
            this.btn_EditarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarAeropuerto.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_EditarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EditarAeropuerto.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarAeropuerto.Iconimage_right = null;
            this.btn_EditarAeropuerto.Iconimage_right_Selected = null;
            this.btn_EditarAeropuerto.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btn_EditarAeropuerto.IconMarginLeft = 0;
            this.btn_EditarAeropuerto.IconMarginRight = 0;
            this.btn_EditarAeropuerto.IconRightVisible = true;
            this.btn_EditarAeropuerto.IconRightZoom = 0D;
            this.btn_EditarAeropuerto.IconVisible = true;
            this.btn_EditarAeropuerto.IconZoom = 70D;
            this.btn_EditarAeropuerto.IsTab = false;
            this.btn_EditarAeropuerto.Location = new System.Drawing.Point(703, 142);
            this.btn_EditarAeropuerto.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EditarAeropuerto.Name = "btn_EditarAeropuerto";
            this.btn_EditarAeropuerto.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_EditarAeropuerto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EditarAeropuerto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_EditarAeropuerto.selected = false;
            this.btn_EditarAeropuerto.Size = new System.Drawing.Size(147, 39);
            this.btn_EditarAeropuerto.TabIndex = 156;
            this.btn_EditarAeropuerto.Text = "Editar";
            this.btn_EditarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_EditarAeropuerto.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AgregarAeropuerto
            // 
            this.btn_AgregarAeropuerto.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAeropuerto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarAeropuerto.BorderRadius = 0;
            this.btn_AgregarAeropuerto.ButtonText = "Agregar";
            this.btn_AgregarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAeropuerto.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_AgregarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAeropuerto.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarAeropuerto.Iconimage_right = null;
            this.btn_AgregarAeropuerto.Iconimage_right_Selected = null;
            this.btn_AgregarAeropuerto.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btn_AgregarAeropuerto.IconMarginLeft = 0;
            this.btn_AgregarAeropuerto.IconMarginRight = 0;
            this.btn_AgregarAeropuerto.IconRightVisible = true;
            this.btn_AgregarAeropuerto.IconRightZoom = 0D;
            this.btn_AgregarAeropuerto.IconVisible = true;
            this.btn_AgregarAeropuerto.IconZoom = 70D;
            this.btn_AgregarAeropuerto.IsTab = false;
            this.btn_AgregarAeropuerto.Location = new System.Drawing.Point(703, 93);
            this.btn_AgregarAeropuerto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarAeropuerto.Name = "btn_AgregarAeropuerto";
            this.btn_AgregarAeropuerto.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarAeropuerto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AgregarAeropuerto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btn_AgregarAeropuerto.selected = false;
            this.btn_AgregarAeropuerto.Size = new System.Drawing.Size(147, 39);
            this.btn_AgregarAeropuerto.TabIndex = 155;
            this.btn_AgregarAeropuerto.Text = "Agregar";
            this.btn_AgregarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarAeropuerto.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAeropuerto.Click += new System.EventHandler(this.btn_AgregarAeropuerto_Click);
            // 
            // dgv_Aeropuerto
            // 
            this.dgv_Aeropuerto.AllowDrop = true;
            this.dgv_Aeropuerto.AllowUserToAddRows = false;
            this.dgv_Aeropuerto.AllowUserToDeleteRows = false;
            this.dgv_Aeropuerto.AllowUserToResizeColumns = false;
            this.dgv_Aeropuerto.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Aeropuerto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Aeropuerto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aeropuerto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Aeropuerto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Aeropuerto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aeropuerto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Aeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aeropuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.aeropuerto,
            this.ciu});
            this.dgv_Aeropuerto.DoubleBuffered = true;
            this.dgv_Aeropuerto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Aeropuerto.EnableHeadersVisualStyles = false;
            this.dgv_Aeropuerto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Aeropuerto.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgv_Aeropuerto.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Aeropuerto.Location = new System.Drawing.Point(98, 91);
            this.dgv_Aeropuerto.MultiSelect = false;
            this.dgv_Aeropuerto.Name = "dgv_Aeropuerto";
            this.dgv_Aeropuerto.ReadOnly = true;
            this.dgv_Aeropuerto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Aeropuerto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aeropuerto.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Aeropuerto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Aeropuerto.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_Aeropuerto.RowTemplate.ReadOnly = true;
            this.dgv_Aeropuerto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aeropuerto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Aeropuerto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Aeropuerto.Size = new System.Drawing.Size(548, 147);
            this.dgv_Aeropuerto.StandardTab = true;
            this.dgv_Aeropuerto.TabIndex = 154;
            this.dgv_Aeropuerto.TabStop = false;
            // 
            // txtAeropuerto
            // 
            this.txtAeropuerto.BackColor = System.Drawing.Color.White;
            this.txtAeropuerto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAeropuerto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeropuerto.ForeColor = System.Drawing.Color.DimGray;
            this.txtAeropuerto.HintForeColor = System.Drawing.Color.Empty;
            this.txtAeropuerto.HintText = "";
            this.txtAeropuerto.isPassword = false;
            this.txtAeropuerto.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtAeropuerto.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtAeropuerto.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtAeropuerto.LineThickness = 4;
            this.txtAeropuerto.Location = new System.Drawing.Point(251, 44);
            this.txtAeropuerto.Margin = new System.Windows.Forms.Padding(5);
            this.txtAeropuerto.Name = "txtAeropuerto";
            this.txtAeropuerto.Size = new System.Drawing.Size(204, 34);
            this.txtAeropuerto.TabIndex = 152;
            this.txtAeropuerto.Text = "Nombre del Aeropuerto";
            this.txtAeropuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAeropuerto.Enter += new System.EventHandler(this.txtAeropuerto_Enter);
            this.txtAeropuerto.Leave += new System.EventHandler(this.txtAeropuerto_Leave);
            // 
            // txtNomRuta
            // 
            this.txtNomRuta.BackColor = System.Drawing.Color.White;
            this.txtNomRuta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomRuta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRuta.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomRuta.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomRuta.HintText = "";
            this.txtNomRuta.isPassword = false;
            this.txtNomRuta.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtNomRuta.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtNomRuta.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtNomRuta.LineThickness = 4;
            this.txtNomRuta.Location = new System.Drawing.Point(98, 317);
            this.txtNomRuta.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomRuta.Name = "txtNomRuta";
            this.txtNomRuta.Size = new System.Drawing.Size(158, 34);
            this.txtNomRuta.TabIndex = 151;
            this.txtNomRuta.Text = "Nombre de la Ruta";
            this.txtNomRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKilometros
            // 
            this.txtKilometros.BackColor = System.Drawing.Color.White;
            this.txtKilometros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKilometros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometros.ForeColor = System.Drawing.Color.DimGray;
            this.txtKilometros.HintForeColor = System.Drawing.Color.Empty;
            this.txtKilometros.HintText = "";
            this.txtKilometros.isPassword = false;
            this.txtKilometros.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtKilometros.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtKilometros.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtKilometros.LineThickness = 4;
            this.txtKilometros.Location = new System.Drawing.Point(297, 317);
            this.txtKilometros.Margin = new System.Windows.Forms.Padding(5);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(158, 34);
            this.txtKilometros.TabIndex = 149;
            this.txtKilometros.Text = "Kilometros";
            this.txtKilometros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Ruta
            // 
            this.dgv_Ruta.AllowDrop = true;
            this.dgv_Ruta.AllowUserToAddRows = false;
            this.dgv_Ruta.AllowUserToDeleteRows = false;
            this.dgv_Ruta.AllowUserToResizeColumns = false;
            this.dgv_Ruta.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Ruta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_Ruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ruta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Ruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ruta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ruta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_Ruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.numas,
            this.sec,
            this.aecol});
            this.dgv_Ruta.DoubleBuffered = true;
            this.dgv_Ruta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Ruta.EnableHeadersVisualStyles = false;
            this.dgv_Ruta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Ruta.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgv_Ruta.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Ruta.Location = new System.Drawing.Point(98, 372);
            this.dgv_Ruta.MultiSelect = false;
            this.dgv_Ruta.Name = "dgv_Ruta";
            this.dgv_Ruta.ReadOnly = true;
            this.dgv_Ruta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Ruta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ruta.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_Ruta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Ruta.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_Ruta.RowTemplate.ReadOnly = true;
            this.dgv_Ruta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ruta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Ruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ruta.Size = new System.Drawing.Size(548, 147);
            this.dgv_Ruta.StandardTab = true;
            this.dgv_Ruta.TabIndex = 144;
            this.dgv_Ruta.TabStop = false;
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarRuta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarRuta.BorderRadius = 0;
            this.btnEliminarRuta.ButtonText = "Eliminar";
            this.btnEliminarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRuta.DisabledColor = System.Drawing.Color.Transparent;
            this.btnEliminarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarRuta.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btnEliminarRuta.Iconimage_right = null;
            this.btnEliminarRuta.Iconimage_right_Selected = null;
            this.btnEliminarRuta.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.btnEliminarRuta.IconMarginLeft = 0;
            this.btnEliminarRuta.IconMarginRight = 0;
            this.btnEliminarRuta.IconRightVisible = true;
            this.btnEliminarRuta.IconRightZoom = 0D;
            this.btnEliminarRuta.IconVisible = true;
            this.btnEliminarRuta.IconZoom = 70D;
            this.btnEliminarRuta.IsTab = false;
            this.btnEliminarRuta.Location = new System.Drawing.Point(703, 474);
            this.btnEliminarRuta.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarRuta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnEliminarRuta.selected = false;
            this.btnEliminarRuta.Size = new System.Drawing.Size(147, 45);
            this.btnEliminarRuta.TabIndex = 147;
            this.btnEliminarRuta.Text = "Eliminar";
            this.btnEliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarRuta.Textcolor = System.Drawing.Color.White;
            this.btnEliminarRuta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.Activecolor = System.Drawing.Color.Transparent;
            this.btnEditarRuta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarRuta.BorderRadius = 0;
            this.btnEditarRuta.ButtonText = "Editar";
            this.btnEditarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRuta.DisabledColor = System.Drawing.Color.Transparent;
            this.btnEditarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarRuta.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btnEditarRuta.Iconimage_right = null;
            this.btnEditarRuta.Iconimage_right_Selected = null;
            this.btnEditarRuta.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.btnEditarRuta.IconMarginLeft = 0;
            this.btnEditarRuta.IconMarginRight = 0;
            this.btnEditarRuta.IconRightVisible = true;
            this.btnEditarRuta.IconRightZoom = 0D;
            this.btnEditarRuta.IconVisible = true;
            this.btnEditarRuta.IconZoom = 70D;
            this.btnEditarRuta.IsTab = false;
            this.btnEditarRuta.Location = new System.Drawing.Point(703, 423);
            this.btnEditarRuta.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnEditarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarRuta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnEditarRuta.selected = false;
            this.btnEditarRuta.Size = new System.Drawing.Size(147, 39);
            this.btnEditarRuta.TabIndex = 146;
            this.btnEditarRuta.Text = "Editar";
            this.btnEditarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarRuta.Textcolor = System.Drawing.Color.White;
            this.btnEditarRuta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarRuta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarRuta.BorderRadius = 0;
            this.btnAgregarRuta.ButtonText = "Agregar";
            this.btnAgregarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarRuta.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAgregarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarRuta.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarRuta.Iconimage_right = null;
            this.btnAgregarRuta.Iconimage_right_Selected = null;
            this.btnAgregarRuta.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarRuta.IconMarginLeft = 0;
            this.btnAgregarRuta.IconMarginRight = 0;
            this.btnAgregarRuta.IconRightVisible = true;
            this.btnAgregarRuta.IconRightZoom = 0D;
            this.btnAgregarRuta.IconVisible = true;
            this.btnAgregarRuta.IconZoom = 70D;
            this.btnAgregarRuta.IsTab = false;
            this.btnAgregarRuta.Location = new System.Drawing.Point(703, 374);
            this.btnAgregarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarRuta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnAgregarRuta.selected = false;
            this.btnAgregarRuta.Size = new System.Drawing.Size(147, 39);
            this.btnAgregarRuta.TabIndex = 145;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarRuta.Textcolor = System.Drawing.Color.White;
            this.btnAgregarRuta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Id_Aeropuerto";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // aeropuerto
            // 
            this.aeropuerto.DataPropertyName = "Nombre_Aeropuerto";
            this.aeropuerto.HeaderText = "Aeropuerto";
            this.aeropuerto.Name = "aeropuerto";
            this.aeropuerto.ReadOnly = true;
            // 
            // ciu
            // 
            this.ciu.DataPropertyName = "Id_Ciudad";
            this.ciu.HeaderText = "Ciudad";
            this.ciu.Name = "ciu";
            this.ciu.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Ruta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // numas
            // 
            this.numas.HeaderText = "Kilometros";
            this.numas.Name = "numas";
            this.numas.ReadOnly = true;
            // 
            // sec
            // 
            this.sec.HeaderText = "Tiempo";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            // 
            // aecol
            // 
            this.aecol.HeaderText = "Aeropuerto";
            this.aecol.Name = "aecol";
            this.aecol.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 162;
            // 
            // AeropuertoYRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 545);
            this.Controls.Add(this.pnl_AeroRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AeropuertoYRuta";
            this.Text = "AeropuertoYRuta";
            this.Load += new System.EventHandler(this.AeropuertoYRuta_Load);
            this.pnl_AeroRuta.ResumeLayout(false);
            this.pnl_AeroRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ruta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AeroRuta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomRuta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKilometros;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Ruta;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarAeropuerto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EditarAeropuerto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarAeropuerto;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Aeropuerto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAeropuerto;
        private MetroFramework.Controls.MetroComboBox cbo_Aeropuerto;
        private MetroFramework.Controls.MetroComboBox cbo_Ciudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn aecol;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}