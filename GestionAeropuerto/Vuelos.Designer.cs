namespace GestionAeropuerto
{
    partial class Vuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vuelos));
            System.Windows.Forms.Label idVueloLabel;
            System.Windows.Forms.Label idAvionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label lugarOrigenLabel;
            System.Windows.Forms.Label lugarDestiniLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label incidenciasLabel;
            this.bBDD = new GestionAeropuerto.BBDD();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueloTableAdapter = new GestionAeropuerto.BBDDTableAdapters.VueloTableAdapter();
            this.tableAdapterManager = new GestionAeropuerto.BBDDTableAdapters.TableAdapterManager();
            this.vueloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vueloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vueloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVueloTextBox = new System.Windows.Forms.TextBox();
            this.idAvionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.lugarOrigenTextBox = new System.Windows.Forms.TextBox();
            this.lugarDestiniTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.incidenciasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bbdd1 = new GestionAeropuerto.BBDD();
            this.vueloTableAdapter1 = new GestionAeropuerto.BBDDTableAdapters.VueloTableAdapter();
            idVueloLabel = new System.Windows.Forms.Label();
            idAvionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            lugarOrigenLabel = new System.Windows.Forms.Label();
            lugarDestiniLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            incidenciasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingNavigator)).BeginInit();
            this.vueloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vueloDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1)).BeginInit();
            this.SuspendLayout();
            // 
            // bBDD
            // 
            this.bBDD.DataSetName = "BBDD";
            this.bBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataMember = "Vuelo";
            this.vueloBindingSource.DataSource = this.bBDD;
            // 
            // vueloTableAdapter
            // 
            this.vueloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ControlTecnicoTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.PasajeroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionAeropuerto.BBDDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VueloTableAdapter = this.vueloTableAdapter;
            // 
            // vueloBindingNavigator
            // 
            this.vueloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vueloBindingNavigator.BindingSource = this.vueloBindingSource;
            this.vueloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vueloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vueloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vueloBindingNavigatorSaveItem});
            this.vueloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vueloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vueloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vueloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vueloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vueloBindingNavigator.Name = "vueloBindingNavigator";
            this.vueloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vueloBindingNavigator.Size = new System.Drawing.Size(982, 25);
            this.vueloBindingNavigator.TabIndex = 0;
            this.vueloBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // vueloBindingNavigatorSaveItem
            // 
            this.vueloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vueloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vueloBindingNavigatorSaveItem.Image")));
            this.vueloBindingNavigatorSaveItem.Name = "vueloBindingNavigatorSaveItem";
            this.vueloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vueloBindingNavigatorSaveItem.Text = "Guardar datos";
           // this.vueloBindingNavigatorSaveItem.Click += new System.EventHandler(this.vueloBindingNavigatorSaveItem_Click);
            // 
            // vueloDataGridView
            // 
            this.vueloDataGridView.AutoGenerateColumns = false;
            this.vueloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vueloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vueloDataGridView.DataSource = this.vueloBindingSource;
            this.vueloDataGridView.Location = new System.Drawing.Point(38, 304);
            this.vueloDataGridView.Name = "vueloDataGridView";
            this.vueloDataGridView.Size = new System.Drawing.Size(844, 220);
            this.vueloDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVuelo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVuelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAvion";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdAvion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LugarOrigen";
            this.dataGridViewTextBoxColumn5.HeaderText = "LugarOrigen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LugarDestini";
            this.dataGridViewTextBoxColumn6.HeaderText = "LugarDestini";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Incidencias";
            this.dataGridViewTextBoxColumn8.HeaderText = "Incidencias";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idVueloLabel
            // 
            idVueloLabel.AutoSize = true;
            idVueloLabel.Location = new System.Drawing.Point(212, 88);
            idVueloLabel.Name = "idVueloLabel";
            idVueloLabel.Size = new System.Drawing.Size(49, 13);
            idVueloLabel.TabIndex = 2;
            idVueloLabel.Text = "Id Vuelo:";
            // 
            // idVueloTextBox
            // 
            this.idVueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "IdVuelo", true));
            this.idVueloTextBox.Location = new System.Drawing.Point(290, 85);
            this.idVueloTextBox.Name = "idVueloTextBox";
            this.idVueloTextBox.Size = new System.Drawing.Size(200, 20);
            this.idVueloTextBox.TabIndex = 3;
            // 
            // idAvionLabel
            // 
            idAvionLabel.AutoSize = true;
            idAvionLabel.Location = new System.Drawing.Point(212, 114);
            idAvionLabel.Name = "idAvionLabel";
            idAvionLabel.Size = new System.Drawing.Size(49, 13);
            idAvionLabel.TabIndex = 4;
            idAvionLabel.Text = "Id Avion:";
            // 
            // idAvionTextBox
            // 
            this.idAvionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "IdAvion", true));
            this.idAvionTextBox.Location = new System.Drawing.Point(290, 111);
            this.idAvionTextBox.Name = "idAvionTextBox";
            this.idAvionTextBox.Size = new System.Drawing.Size(200, 20);
            this.idAvionTextBox.TabIndex = 5;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(212, 141);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vueloBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(290, 137);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(212, 166);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 8;
            horaLabel.Text = "Hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(290, 163);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 9;
            // 
            // lugarOrigenLabel
            // 
            lugarOrigenLabel.AutoSize = true;
            lugarOrigenLabel.Location = new System.Drawing.Point(212, 192);
            lugarOrigenLabel.Name = "lugarOrigenLabel";
            lugarOrigenLabel.Size = new System.Drawing.Size(71, 13);
            lugarOrigenLabel.TabIndex = 10;
            lugarOrigenLabel.Text = "Lugar Origen:";
            // 
            // lugarOrigenTextBox
            // 
            this.lugarOrigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "LugarOrigen", true));
            this.lugarOrigenTextBox.Location = new System.Drawing.Point(290, 189);
            this.lugarOrigenTextBox.Name = "lugarOrigenTextBox";
            this.lugarOrigenTextBox.Size = new System.Drawing.Size(200, 20);
            this.lugarOrigenTextBox.TabIndex = 11;
            // 
            // lugarDestiniLabel
            // 
            lugarDestiniLabel.AutoSize = true;
            lugarDestiniLabel.Location = new System.Drawing.Point(212, 218);
            lugarDestiniLabel.Name = "lugarDestiniLabel";
            lugarDestiniLabel.Size = new System.Drawing.Size(72, 13);
            lugarDestiniLabel.TabIndex = 12;
            lugarDestiniLabel.Text = "Lugar Destini:";
            // 
            // lugarDestiniTextBox
            // 
            this.lugarDestiniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "LugarDestini", true));
            this.lugarDestiniTextBox.Location = new System.Drawing.Point(290, 215);
            this.lugarDestiniTextBox.Name = "lugarDestiniTextBox";
            this.lugarDestiniTextBox.Size = new System.Drawing.Size(200, 20);
            this.lugarDestiniTextBox.TabIndex = 13;
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Location = new System.Drawing.Point(212, 244);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(53, 13);
            duracionLabel.TabIndex = 14;
            duracionLabel.Text = "Duracion:";
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "Duracion", true));
            this.duracionTextBox.Location = new System.Drawing.Point(290, 241);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.Size = new System.Drawing.Size(200, 20);
            this.duracionTextBox.TabIndex = 15;
            // 
            // incidenciasLabel
            // 
            incidenciasLabel.AutoSize = true;
            incidenciasLabel.Location = new System.Drawing.Point(212, 270);
            incidenciasLabel.Name = "incidenciasLabel";
            incidenciasLabel.Size = new System.Drawing.Size(64, 13);
            incidenciasLabel.TabIndex = 16;
            incidenciasLabel.Text = "Incidencias:";
            // 
            // incidenciasTextBox
            // 
            this.incidenciasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vueloBindingSource, "Incidencias", true));
            this.incidenciasTextBox.Location = new System.Drawing.Point(290, 267);
            this.incidenciasTextBox.Name = "incidenciasTextBox";
            this.incidenciasTextBox.Size = new System.Drawing.Size(200, 20);
            this.incidenciasTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "VUELOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bbdd1
            // 
            this.bbdd1.DataSetName = "BBDD";
            this.bbdd1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueloTableAdapter1
            // 
            this.vueloTableAdapter1.ClearBeforeFill = true;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idVueloLabel);
            this.Controls.Add(this.idVueloTextBox);
            this.Controls.Add(idAvionLabel);
            this.Controls.Add(this.idAvionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(lugarOrigenLabel);
            this.Controls.Add(this.lugarOrigenTextBox);
            this.Controls.Add(lugarDestiniLabel);
            this.Controls.Add(this.lugarDestiniTextBox);
            this.Controls.Add(duracionLabel);
            this.Controls.Add(this.duracionTextBox);
            this.Controls.Add(incidenciasLabel);
            this.Controls.Add(this.incidenciasTextBox);
            this.Controls.Add(this.vueloDataGridView);
            this.Controls.Add(this.vueloBindingNavigator);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.Vuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingNavigator)).EndInit();
            this.vueloBindingNavigator.ResumeLayout(false);
            this.vueloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vueloDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BBDD bBDD;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private BBDDTableAdapters.VueloTableAdapter vueloTableAdapter;
        private BBDDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vueloBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vueloBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vueloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idVueloTextBox;
        private System.Windows.Forms.TextBox idAvionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox lugarOrigenTextBox;
        private System.Windows.Forms.TextBox lugarDestiniTextBox;
        private System.Windows.Forms.TextBox duracionTextBox;
        private System.Windows.Forms.TextBox incidenciasTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private BBDD bbdd1;
        private BBDDTableAdapters.VueloTableAdapter vueloTableAdapter1;
    }
}