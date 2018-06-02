using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAeropuerto
{
    public partial class PaisDestino : Form
    {
        public PaisDestino()
        {
            InitializeComponent();
        }

        private void avionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void PaisDestino_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Avion' Puede moverla o quitarla según sea necesario.
            this.avionTableAdapter.Fill(this.bBDD.Avion);

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            BBDDTableAdapters.AvionTableAdapter aviones2 = new BBDDTableAdapters.AvionTableAdapter();
            tabla3 = aviones2.PaisDestino(textBox1.Text);
            avionDataGridView.DataSource = tabla3;
        }
    }
}
