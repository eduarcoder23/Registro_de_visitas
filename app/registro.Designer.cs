using System;

namespace app
{
    partial class registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textCarrera = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textHorase = new System.Windows.Forms.TextBox();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.comboBoxAula = new System.Windows.Forms.ComboBox();
            this.textHorass = new System.Windows.Forms.TextBox();
            this.tablaCategoria = new System.Windows.Forms.DataGridView();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRERADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDIFICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGDataSet = new app.REGDataSet();
            this.uSUARIOSTableAdapter = new app.REGDataSetTableAdapters.USUARIOSTableAdapter();
            this.topFormulario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEdificio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGDataSet)).BeginInit();
            this.topFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(100, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(173, 26);
            this.textNombre.TabIndex = 23;
            // 
            // textApellido
            // 
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(95, 91);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(178, 26);
            this.textApellido.TabIndex = 24;
            // 
            // textCarrera
            // 
            this.textCarrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCarrera.Location = new System.Drawing.Point(95, 125);
            this.textCarrera.Multiline = true;
            this.textCarrera.Name = "textCarrera";
            this.textCarrera.Size = new System.Drawing.Size(178, 29);
            this.textCarrera.TabIndex = 25;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(95, 168);
            this.textCorreo.Multiline = true;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(178, 25);
            this.textCorreo.TabIndex = 26;
            // 
            // textHorase
            // 
            this.textHorase.Location = new System.Drawing.Point(129, 257);
            this.textHorase.Multiline = true;
            this.textHorase.Name = "textHorase";
            this.textHorase.Size = new System.Drawing.Size(144, 20);
            this.textHorase.TabIndex = 27;
            // 
            // textMotivo
            // 
            this.textMotivo.Location = new System.Drawing.Point(129, 340);
            this.textMotivo.Multiline = true;
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(144, 20);
            this.textMotivo.TabIndex = 41;
            // 
            // comboBoxAula
            // 
            this.comboBoxAula.FormattingEnabled = true;
            this.comboBoxAula.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "C1",
            "C2",
            "C3",
            "C4",
            "D1",
            "D2",
            "D3",
            "D4"});
            this.comboBoxAula.Location = new System.Drawing.Point(129, 382);
            this.comboBoxAula.Name = "comboBoxAula";
            this.comboBoxAula.Size = new System.Drawing.Size(127, 21);
            this.comboBoxAula.TabIndex = 42;
            // 
            // textHorass
            // 
            this.textHorass.Location = new System.Drawing.Point(129, 295);
            this.textHorass.Name = "textHorass";
            this.textHorass.Size = new System.Drawing.Size(144, 20);
            this.textHorass.TabIndex = 43;
            // 
            // tablaCategoria
            // 
            this.tablaCategoria.AllowUserToAddRows = false;
            this.tablaCategoria.AllowUserToDeleteRows = false;
            this.tablaCategoria.AutoGenerateColumns = false;
            this.tablaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCategoria.BackgroundColor = System.Drawing.Color.White;
            this.tablaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCategoria.ColumnHeadersVisible = false;
            this.tablaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.cARRERADataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.eDIFICIODataGridViewTextBoxColumn,
            this.hORASEDataGridViewTextBoxColumn,
            this.hORASSDataGridViewTextBoxColumn,
            this.mOTIVODataGridViewTextBoxColumn,
            this.aULADataGridViewTextBoxColumn});
            this.tablaCategoria.DataSource = this.uSUARIOSBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCategoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCategoria.Location = new System.Drawing.Point(309, 114);
            this.tablaCategoria.Name = "tablaCategoria";
            this.tablaCategoria.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCategoria.RowHeadersVisible = false;
            this.tablaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCategoria.Size = new System.Drawing.Size(510, 246);
            this.tablaCategoria.TabIndex = 47;
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            this.aPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cARRERADataGridViewTextBoxColumn
            // 
            this.cARRERADataGridViewTextBoxColumn.DataPropertyName = "CARRERA";
            this.cARRERADataGridViewTextBoxColumn.HeaderText = "CARRERA";
            this.cARRERADataGridViewTextBoxColumn.Name = "cARRERADataGridViewTextBoxColumn";
            this.cARRERADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            this.cORREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDIFICIODataGridViewTextBoxColumn
            // 
            this.eDIFICIODataGridViewTextBoxColumn.DataPropertyName = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.HeaderText = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.Name = "eDIFICIODataGridViewTextBoxColumn";
            this.eDIFICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORASEDataGridViewTextBoxColumn
            // 
            this.hORASEDataGridViewTextBoxColumn.DataPropertyName = "HORASE";
            this.hORASEDataGridViewTextBoxColumn.HeaderText = "HORASE";
            this.hORASEDataGridViewTextBoxColumn.Name = "hORASEDataGridViewTextBoxColumn";
            this.hORASEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORASSDataGridViewTextBoxColumn
            // 
            this.hORASSDataGridViewTextBoxColumn.DataPropertyName = "HORASS";
            this.hORASSDataGridViewTextBoxColumn.HeaderText = "HORASS";
            this.hORASSDataGridViewTextBoxColumn.Name = "hORASSDataGridViewTextBoxColumn";
            this.hORASSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOTIVODataGridViewTextBoxColumn
            // 
            this.mOTIVODataGridViewTextBoxColumn.DataPropertyName = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.HeaderText = "MOTIVO";
            this.mOTIVODataGridViewTextBoxColumn.Name = "mOTIVODataGridViewTextBoxColumn";
            this.mOTIVODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aULADataGridViewTextBoxColumn
            // 
            this.aULADataGridViewTextBoxColumn.DataPropertyName = "AULA";
            this.aULADataGridViewTextBoxColumn.HeaderText = "AULA";
            this.aULADataGridViewTextBoxColumn.Name = "aULADataGridViewTextBoxColumn";
            this.aULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.rEGDataSet;
            // 
            // rEGDataSet
            // 
            this.rEGDataSet.DataSetName = "REGDataSet";
            this.rEGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // topFormulario
            // 
            this.topFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.topFormulario.Controls.Add(this.pictureBox2);
            this.topFormulario.Controls.Add(this.pictureBox1);
            this.topFormulario.Controls.Add(this.cerrarFormulario);
            this.topFormulario.Controls.Add(this.label1);
            this.topFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormulario.Location = new System.Drawing.Point(0, 0);
            this.topFormulario.Name = "topFormulario";
            this.topFormulario.Size = new System.Drawing.Size(831, 47);
            this.topFormulario.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::app.Properties.Resources.close_window__1_;
            this.pictureBox2.Location = new System.Drawing.Point(786, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::app.Properties.Resources.channels4_profile;
            this.pictureBox1.Location = new System.Drawing.Point(0, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.Image = global::app.Properties.Resources.exit;
            this.cerrarFormulario.Location = new System.Drawing.Point(1117, 3);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(37, 41);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarFormulario.TabIndex = 1;
            this.cerrarFormulario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario de registros";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.Silver;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "NUEVO";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 80D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(276, 392);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(131, 44);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.Silver;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 7;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 80D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(550, 392);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(131, 44);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.Silver;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "INSERTAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 60D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(413, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(131, 41);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "INSERTAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "TABLA ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(699, 392);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(120, 44);
            this.bunifuFlatButton1.TabIndex = 59;
            this.bunifuFlatButton1.Text = "TABLA ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "EDIFICIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "CORREO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "CARRERA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "HORA DE ENTRADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "HORA DE SALIDA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "MOTIVO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "AULA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "TABLA DE DATOS";
            // 
            // comboBoxEdificio
            // 
            this.comboBoxEdificio.FormattingEnabled = true;
            this.comboBoxEdificio.Items.AddRange(new object[] {
            "DEPARTAMENTO DE COMUNICACIONES",
            "DEPARTAMENTO LEGAL",
            "DEPARTAMENTO DE FINANZAS",
            "DEPARTAMENTO DE PROGRAMAS DE EXTENSION",
            "DEPARTAMENTO DE OPERACIONES",
            "DEPARTAMENTO DE PLANIFICACION Y DESARROLLO",
            "DEPARTAMENTO DE RECURSOS HUMANOS",
            "DEPARTAMENTO GESTION Y CALIDAD",
            "",
            "",
            ""});
            this.comboBoxEdificio.Location = new System.Drawing.Point(95, 213);
            this.comboBoxEdificio.Name = "comboBoxEdificio";
            this.comboBoxEdificio.Size = new System.Drawing.Size(178, 21);
            this.comboBoxEdificio.TabIndex = 44;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 445);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.topFormulario);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tablaCategoria);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxEdificio);
            this.Controls.Add(this.textHorass);
            this.Controls.Add(this.comboBoxAula);
            this.Controls.Add(this.textMotivo);
            this.Controls.Add(this.textHorase);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textCarrera);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro";
            this.Text = "registro";
            this.Load += new System.EventHandler(this.registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGDataSet)).EndInit();
            this.topFormulario.ResumeLayout(false);
            this.topFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textCarrera;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textHorase;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.ComboBox comboBoxAula;
        private System.Windows.Forms.TextBox textHorass;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.DataGridView tablaCategoria;
        private REGDataSet rEGDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private REGDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRERADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDIFICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aULADataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.Panel topFormulario;
        private System.Windows.Forms.PictureBox cerrarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxEdificio;
    }
}