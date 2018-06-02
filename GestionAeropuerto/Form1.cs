using GestionAeropuerto.BBDDTableAdapters;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void avionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Avion' Puede moverla o quitarla según sea necesario.
            this.avionTableAdapter.Fill(this.bBDD.Avion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avion ventana4 = new Avion();
            ventana4.Show();
            this.Visible = false;
           
        }

        private void avionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaisDestino ventana5 = new PaisDestino();
            ventana5.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Principal ventana1 = new Principal();
            ventana1.Show();
            this.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Vuelos ventana2 = new Vuelos();
            ventana2.Show();
            this.Visible = false;
        }
    }
}
