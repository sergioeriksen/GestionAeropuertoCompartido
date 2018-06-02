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
    public partial class Avion : Form
    {
        public Avion()
        {
            InitializeComponent();
        }

        private void avionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void Avion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Avion' Puede moverla o quitarla según sea necesario.
            this.avionTableAdapter.Fill(this.bBDD.Avion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable();
            BBDDTableAdapters.AvionTableAdapter aviones2 = new BBDDTableAdapters.AvionTableAdapter();
            tabla2 = aviones2.PaisOrigen(textBox1.Text);
            avionDataGridView.DataSource = tabla2;
        }

        private void avionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
