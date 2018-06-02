namespace GestionAeropuerto
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bBDD = new GestionAeropuerto.BBDD();
            this.avionTableAdapter = new GestionAeropuerto.BBDDTableAdapters.AvionTableAdapter();
            this.tableAdapterManager = new GestionAeropuerto.BBDDTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "AVIONES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // avionBindingSource
            // 
            this.avionBindingSource.DataMember = "Avion";
            this.avionBindingSource.DataSource = this.bBDD;
            // 
            // bBDD
            // 
            this.bBDD.DataSetName = "BBDD";
            this.bBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "VUELOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 533);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BBDD bBDD;
        private System.Windows.Forms.BindingSource avionBindingSource;
        private BBDDTableAdapters.AvionTableAdapter avionTableAdapter;
        private BBDDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

