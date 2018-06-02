namespace GestionAeropuerto
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.Label idAvionLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label capitánLabel;
            System.Windows.Forms.Label pistaLabel;
            System.Windows.Forms.Label aparcamientoLabel;
            System.Windows.Forms.Label paisOrigenLabel;
            System.Windows.Forms.Label paisDestinoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.bBDD = new GestionAeropuerto.BBDD();
            this.avionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avionTableAdapter = new GestionAeropuerto.BBDDTableAdapters.AvionTableAdapter();
            this.tableAdapterManager = new GestionAeropuerto.BBDDTableAdapters.TableAdapterManager();
            this.avionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.avionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAvionTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.capitánTextBox = new System.Windows.Forms.TextBox();
            this.pistaTextBox = new System.Windows.Forms.TextBox();
            this.aparcamientoTextBox = new System.Windows.Forms.TextBox();
            this.paisOrigenTextBox = new System.Windows.Forms.TextBox();
            this.paisDestinoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            idAvionLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            capitánLabel = new System.Windows.Forms.Label();
            pistaLabel = new System.Windows.Forms.Label();
            aparcamientoLabel = new System.Windows.Forms.Label();
            paisOrigenLabel = new System.Windows.Forms.Label();
            paisDestinoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingNavigator)).BeginInit();
            this.avionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bBDD
            // 
            this.bBDD.DataSetName = "BBDD";
            this.bBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avionBindingSource
            // 
            this.avionBindingSource.DataMember = "Avion";
            this.avionBindingSource.DataSource = this.bBDD;
            // 
            // avionTableAdapter
            // 
            this.avionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionTableAdapter = this.avionTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ControlTecnicoTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.PasajeroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionAeropuerto.BBDDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VueloTableAdapter = null;
            // 
            // avionBindingNavigator
            // 
            this.avionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avionBindingNavigator.BindingSource = this.avionBindingSource;
            this.avionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.avionBindingNavigatorSaveItem});
            this.avionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avionBindingNavigator.Name = "avionBindingNavigator";
            this.avionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avionBindingNavigator.Size = new System.Drawing.Size(999, 25);
            this.avionBindingNavigator.TabIndex = 0;
            this.avionBindingNavigator.Text = "bindingNavigator1";
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
            // avionBindingNavigatorSaveItem
            // 
            this.avionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avionBindingNavigatorSaveItem.Image")));
            this.avionBindingNavigatorSaveItem.Name = "avionBindingNavigatorSaveItem";
            this.avionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.avionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.avionBindingNavigatorSaveItem.Click += new System.EventHandler(this.avionBindingNavigatorSaveItem_Click_2);
            // 
            // avionDataGridView
            // 
            this.avionDataGridView.AutoGenerateColumns = false;
            this.avionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.avionDataGridView.DataSource = this.avionBindingSource;
            this.avionDataGridView.Location = new System.Drawing.Point(21, 335);
            this.avionDataGridView.Name = "avionDataGridView";
            this.avionDataGridView.Size = new System.Drawing.Size(954, 166);
            this.avionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAvion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAvion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn3.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capitán";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capitán";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pista";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pista";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Aparcamiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Aparcamiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PaisOrigen";
            this.dataGridViewTextBoxColumn7.HeaderText = "PaisOrigen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PaisDestino";
            this.dataGridViewTextBoxColumn8.HeaderText = "PaisDestino";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idAvionLabel
            // 
            idAvionLabel.AutoSize = true;
            idAvionLabel.Location = new System.Drawing.Point(265, 85);
            idAvionLabel.Name = "idAvionLabel";
            idAvionLabel.Size = new System.Drawing.Size(49, 13);
            idAvionLabel.TabIndex = 2;
            idAvionLabel.Text = "Id Avion:";
            // 
            // idAvionTextBox
            // 
            this.idAvionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "IdAvion", true));
            this.idAvionTextBox.Location = new System.Drawing.Point(346, 82);
            this.idAvionTextBox.Name = "idAvionTextBox";
            this.idAvionTextBox.Size = new System.Drawing.Size(200, 20);
            this.idAvionTextBox.TabIndex = 3;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(265, 111);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 4;
            horaLabel.Text = "Hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "Hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(346, 108);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 5;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(265, 137);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 6;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(346, 134);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTextBox.TabIndex = 7;
            // 
            // capitánLabel
            // 
            capitánLabel.AutoSize = true;
            capitánLabel.Location = new System.Drawing.Point(265, 163);
            capitánLabel.Name = "capitánLabel";
            capitánLabel.Size = new System.Drawing.Size(46, 13);
            capitánLabel.TabIndex = 8;
            capitánLabel.Text = "Capitán:";
            // 
            // capitánTextBox
            // 
            this.capitánTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "Capitán", true));
            this.capitánTextBox.Location = new System.Drawing.Point(346, 160);
            this.capitánTextBox.Name = "capitánTextBox";
            this.capitánTextBox.Size = new System.Drawing.Size(200, 20);
            this.capitánTextBox.TabIndex = 9;
            // 
            // pistaLabel
            // 
            pistaLabel.AutoSize = true;
            pistaLabel.Location = new System.Drawing.Point(265, 189);
            pistaLabel.Name = "pistaLabel";
            pistaLabel.Size = new System.Drawing.Size(33, 13);
            pistaLabel.TabIndex = 10;
            pistaLabel.Text = "Pista:";
            // 
            // pistaTextBox
            // 
            this.pistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "Pista", true));
            this.pistaTextBox.Location = new System.Drawing.Point(346, 186);
            this.pistaTextBox.Name = "pistaTextBox";
            this.pistaTextBox.Size = new System.Drawing.Size(200, 20);
            this.pistaTextBox.TabIndex = 11;
            // 
            // aparcamientoLabel
            // 
            aparcamientoLabel.AutoSize = true;
            aparcamientoLabel.Location = new System.Drawing.Point(265, 215);
            aparcamientoLabel.Name = "aparcamientoLabel";
            aparcamientoLabel.Size = new System.Drawing.Size(75, 13);
            aparcamientoLabel.TabIndex = 12;
            aparcamientoLabel.Text = "Aparcamiento:";
            // 
            // aparcamientoTextBox
            // 
            this.aparcamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "Aparcamiento", true));
            this.aparcamientoTextBox.Location = new System.Drawing.Point(346, 212);
            this.aparcamientoTextBox.Name = "aparcamientoTextBox";
            this.aparcamientoTextBox.Size = new System.Drawing.Size(200, 20);
            this.aparcamientoTextBox.TabIndex = 13;
            // 
            // paisOrigenLabel
            // 
            paisOrigenLabel.AutoSize = true;
            paisOrigenLabel.Location = new System.Drawing.Point(265, 241);
            paisOrigenLabel.Name = "paisOrigenLabel";
            paisOrigenLabel.Size = new System.Drawing.Size(64, 13);
            paisOrigenLabel.TabIndex = 14;
            paisOrigenLabel.Text = "Pais Origen:";
            // 
            // paisOrigenTextBox
            // 
            this.paisOrigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "PaisOrigen", true));
            this.paisOrigenTextBox.Location = new System.Drawing.Point(346, 238);
            this.paisOrigenTextBox.Name = "paisOrigenTextBox";
            this.paisOrigenTextBox.Size = new System.Drawing.Size(200, 20);
            this.paisOrigenTextBox.TabIndex = 15;
            // 
            // paisDestinoLabel
            // 
            paisDestinoLabel.AutoSize = true;
            paisDestinoLabel.Location = new System.Drawing.Point(265, 267);
            paisDestinoLabel.Name = "paisDestinoLabel";
            paisDestinoLabel.Size = new System.Drawing.Size(69, 13);
            paisDestinoLabel.TabIndex = 16;
            paisDestinoLabel.Text = "Pais Destino:";
            // 
            // paisDestinoTextBox
            // 
            this.paisDestinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionBindingSource, "PaisDestino", true));
            this.paisDestinoTextBox.Location = new System.Drawing.Point(346, 264);
            this.paisDestinoTextBox.Name = "paisDestinoTextBox";
            this.paisDestinoTextBox.Size = new System.Drawing.Size(200, 20);
            this.paisDestinoTextBox.TabIndex = 17;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(265, 294);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 18;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.avionBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(346, 290);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "AVION";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Filtrar por Pais de Origen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Filtrar por Pais de Destino";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "Filtrar por Número de Avion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idAvionLabel);
            this.Controls.Add(this.idAvionTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(capitánLabel);
            this.Controls.Add(this.capitánTextBox);
            this.Controls.Add(pistaLabel);
            this.Controls.Add(this.pistaTextBox);
            this.Controls.Add(aparcamientoLabel);
            this.Controls.Add(this.aparcamientoTextBox);
            this.Controls.Add(paisOrigenLabel);
            this.Controls.Add(this.paisOrigenTextBox);
            this.Controls.Add(paisDestinoLabel);
            this.Controls.Add(this.paisDestinoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.avionDataGridView);
            this.Controls.Add(this.avionBindingNavigator);
            this.Name = "Principal";
            this.Text = "Avion";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingNavigator)).EndInit();
            this.avionBindingNavigator.ResumeLayout(false);
            this.avionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BBDD bBDD;
        private System.Windows.Forms.BindingSource avionBindingSource;
        private BBDDTableAdapters.AvionTableAdapter avionTableAdapter;
        private BBDDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton avionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView avionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idAvionTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox capitánTextBox;
        private System.Windows.Forms.TextBox pistaTextBox;
        private System.Windows.Forms.TextBox aparcamientoTextBox;
        private System.Windows.Forms.TextBox paisOrigenTextBox;
        private System.Windows.Forms.TextBox paisDestinoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}