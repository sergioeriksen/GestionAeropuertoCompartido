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
    public partial class VueloOrigen : Form
    {
        public VueloOrigen()
        {
            InitializeComponent();
        }

        private void vueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vueloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void VueloOrigen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Vuelo' Puede moverla o quitarla según sea necesario.
            this.vueloTableAdapter.Fill(this.bBDD.Vuelo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla3 = new DataTable();
            BBDDTableAdapters.VueloTableAdapter vuelo = new BBDDTableAdapters.VueloTableAdapter();
            tabla3 = vuelo.LugarOrigen(textBox1.Text);
            vueloDataGridView.DataSource = tabla3;
        }
    }
}
