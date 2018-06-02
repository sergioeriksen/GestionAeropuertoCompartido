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
    public partial class Vuelos : Form
    {
        private BBDD bbdd;

        public object avionBindingSource { get; private set; }

        public Vuelos()
        {
            InitializeComponent();
        }

        private void vueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vueloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bbdd);

        }
      

        private void Vuelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Vuelo' Puede moverla o quitarla según sea necesario.
            this.vueloTableAdapter.Fill(this.bBDD.Vuelo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VueloOrigen ventana = new VueloOrigen();
            ventana.Show();
            this.Visible = false;
        }
    }
}
