namespace AirFly
{
    partial class PaisyCiudad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdPais = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbo_Pais = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarPais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvPais = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPais = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCiudad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvCiudad = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paiscol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdPais);
            this.panel1.Controls.Add(this.cbo_Pais);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.panel1.Controls.Add(this.btnAgregarPais);
            this.panel1.Controls.Add(this.dgvPais);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.btnAgregarCiudad);
            this.panel1.Controls.Add(this.dgvCiudad);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 555);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdPais
            // 
            this.txtIdPais.BackColor = System.Drawing.Color.White;
            this.txtIdPais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPais.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPais.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdPais.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdPais.HintText = "";
            this.txtIdPais.isPassword = false;
            this.txtIdPais.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtIdPais.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtIdPais.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtIdPais.LineThickness = 4;
            this.txtIdPais.Location = new System.Drawing.Point(617, 28);
            this.txtIdPais.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdPais.Name = "txtIdPais";
            this.txtIdPais.Size = new System.Drawing.Size(52, 34);
            this.txtIdPais.TabIndex = 151;
            this.txtIdPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_Pais
            // 
            this.cbo_Pais.AutoCompleteCustomSource.AddRange(new string[] {
            "tic",
            "admin",
            "gastro",
            "derecho"});
            this.cbo_Pais.BackColor = System.Drawing.Color.White;
            this.cbo_Pais.DisplayMember = "Seleccionar Pais";
            this.cbo_Pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Pais.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbo_Pais.FormattingEnabled = true;
            this.cbo_Pais.ItemHeight = 23;
            this.cbo_Pais.Items.AddRange(new object[] {
            "Seleccionar País"});
            this.cbo_Pais.Location = new System.Drawing.Point(433, 322);
            this.cbo_Pais.Name = "cbo_Pais";
            this.cbo_Pais.PromptText = "Seleccionar País";
            this.cbo_Pais.Size = new System.Drawing.Size(220, 29);
            this.cbo_Pais.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbo_Pais.TabIndex = 150;
            this.cbo_Pais.UseCustomBackColor = true;
            this.cbo_Pais.UseCustomForeColor = true;
            this.cbo_Pais.UseSelectable = true;
            this.cbo_Pais.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 149;
            this.label2.Text = "PAÍS";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Eliminar";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Delete_File_48;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(712, 211);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(147, 39);
            this.bunifuFlatButton4.TabIndex = 148;
            this.bunifuFlatButton4.Text = "Eliminar";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Editar";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Edit_File_48;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(712, 154);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(147, 39);
            this.bunifuFlatButton5.TabIndex = 147;
            this.bunifuFlatButton5.Text = "Editar";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarPais.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPais.BorderRadius = 0;
            this.btnAgregarPais.ButtonText = "Agregar";
            this.btnAgregarPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPais.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAgregarPais.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarPais.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarPais.Iconimage_right = null;
            this.btnAgregarPais.Iconimage_right_Selected = null;
            this.btnAgregarPais.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarPais.IconMarginLeft = 0;
            this.btnAgregarPais.IconMarginRight = 0;
            this.btnAgregarPais.IconRightVisible = true;
            this.btnAgregarPais.IconRightZoom = 0D;
            this.btnAgregarPais.IconVisible = true;
            this.btnAgregarPais.IconZoom = 70D;
            this.btnAgregarPais.IsTab = false;
            this.btnAgregarPais.Location = new System.Drawing.Point(712, 100);
            this.btnAgregarPais.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarPais.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.btnAgregarPais.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarPais.selected = false;
            this.btnAgregarPais.Size = new System.Drawing.Size(147, 39);
            this.btnAgregarPais.TabIndex = 146;
            this.btnAgregarPais.Text = "Agregar";
            this.btnAgregarPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarPais.Textcolor = System.Drawing.Color.White;
            this.btnAgregarPais.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // dgvPais
            // 
            this.dgvPais.AllowDrop = true;
            this.dgvPais.AllowUserToAddRows = false;
            this.dgvPais.AllowUserToDeleteRows = false;
            this.dgvPais.AllowUserToResizeColumns = false;
            this.dgvPais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvPais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPais.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPais.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPais.DoubleBuffered = true;
            this.dgvPais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPais.EnableHeadersVisualStyles = false;
            this.dgvPais.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPais.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvPais.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPais.Location = new System.Drawing.Point(105, 103);
            this.dgvPais.MultiSelect = false;
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.ReadOnly = true;
            this.dgvPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvPais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPais.RowTemplate.ReadOnly = true;
            this.dgvPais.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPais.Size = new System.Drawing.Size(548, 147);
            this.dgvPais.StandardTab = true;
            this.dgvPais.TabIndex = 145;
            this.dgvPais.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Pais";
            this.dataGridViewTextBoxColumn3.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre_Pais";
            this.dataGridViewTextBoxColumn4.HeaderText = "País";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.White;
            this.txtPais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPais.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.DimGray;
            this.txtPais.HintForeColor = System.Drawing.Color.Empty;
            this.txtPais.HintText = "";
            this.txtPais.isPassword = false;
            this.txtPais.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtPais.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtPais.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtPais.LineThickness = 4;
            this.txtPais.Location = new System.Drawing.Point(274, 49);
            this.txtPais.Margin = new System.Windows.Forms.Padding(5);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(232, 34);
            this.txtPais.TabIndex = 144;
            this.txtPais.Text = "Nombre del País";
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPais.Enter += new System.EventHandler(this.txtPais_Enter);
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(24, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 143;
            this.label1.Text = "CIUDAD";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(712, 478);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(147, 39);
            this.bunifuFlatButton1.TabIndex = 142;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(712, 421);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(147, 39);
            this.bunifuFlatButton2.TabIndex = 141;
            this.bunifuFlatButton2.Text = "Editar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarCiudad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCiudad.BorderRadius = 0;
            this.btnAgregarCiudad.ButtonText = "Agregar";
            this.btnAgregarCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCiudad.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAgregarCiudad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCiudad.Iconimage = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarCiudad.Iconimage_right = null;
            this.btnAgregarCiudad.Iconimage_right_Selected = null;
            this.btnAgregarCiudad.Iconimage_Selected = global::AirFly.Properties.Resources.icons8_Add_File_48;
            this.btnAgregarCiudad.IconMarginLeft = 0;
            this.btnAgregarCiudad.IconMarginRight = 0;
            this.btnAgregarCiudad.IconRightVisible = true;
            this.btnAgregarCiudad.IconRightZoom = 0D;
            this.btnAgregarCiudad.IconVisible = true;
            this.btnAgregarCiudad.IconZoom = 70D;
            this.btnAgregarCiudad.IsTab = false;
            this.btnAgregarCiudad.Location = new System.Drawing.Point(712, 367);
            this.btnAgregarCiudad.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarCiudad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregarCiudad.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.btnAgregarCiudad.selected = false;
            this.btnAgregarCiudad.Size = new System.Drawing.Size(147, 39);
            this.btnAgregarCiudad.TabIndex = 140;
            this.btnAgregarCiudad.Text = "Agregar";
            this.btnAgregarCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarCiudad.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCiudad.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
            // 
            // dgvCiudad
            // 
            this.dgvCiudad.AllowDrop = true;
            this.dgvCiudad.AllowUserToAddRows = false;
            this.dgvCiudad.AllowUserToDeleteRows = false;
            this.dgvCiudad.AllowUserToResizeColumns = false;
            this.dgvCiudad.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCiudad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCiudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCiudad.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCiudad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Paiscol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCiudad.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCiudad.DoubleBuffered = true;
            this.dgvCiudad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCiudad.EnableHeadersVisualStyles = false;
            this.dgvCiudad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCiudad.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dgvCiudad.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCiudad.Location = new System.Drawing.Point(105, 370);
            this.dgvCiudad.MultiSelect = false;
            this.dgvCiudad.Name = "dgvCiudad";
            this.dgvCiudad.ReadOnly = true;
            this.dgvCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCiudad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudad.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCiudad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCiudad.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCiudad.RowTemplate.ReadOnly = true;
            this.dgvCiudad.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCiudad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiudad.Size = new System.Drawing.Size(548, 147);
            this.dgvCiudad.StandardTab = true;
            this.dgvCiudad.TabIndex = 139;
            this.dgvCiudad.TabStop = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCiudad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCiudad.HintText = "";
            this.txtCiudad.isPassword = false;
            this.txtCiudad.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtCiudad.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtCiudad.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtCiudad.LineThickness = 4;
            this.txtCiudad.Location = new System.Drawing.Point(169, 317);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(5);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(232, 34);
            this.txtCiudad.TabIndex = 138;
            this.txtCiudad.Text = "Nombre de la Ciudad";
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCiudad.Enter += new System.EventHandler(this.txtCiudad_Enter);
            this.txtCiudad.Leave += new System.EventHandler(this.txtCiudad_Leave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Ciudad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Ciudad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Paiscol
            // 
            this.Paiscol.DataPropertyName = "Id_Pais";
            this.Paiscol.HeaderText = "País";
            this.Paiscol.Name = "Paiscol";
            this.Paiscol.ReadOnly = true;
            // 
            // PaisyCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaisyCiudad";
            this.Text = "PaisyCiudad";
            this.Load += new System.EventHandler(this.PaisyCiudad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCiudad;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCiudad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarPais;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPais;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPais;
        private MetroFramework.Controls.MetroComboBox cbo_Pais;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paiscol;
    }
}