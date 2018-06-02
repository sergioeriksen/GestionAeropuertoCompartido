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
    public partial class Principal : Form
    {
        private BBDD bbdd1;

        public Principal()
        {
            InitializeComponent();
        }

        private void avionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void Principal_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            PaisDestino ventana5 = new PaisDestino();
            ventana5.Show();
            this.Visible = false;
        }

        private void avionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bbdd1);

        }

        private void avionBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bBDD);

        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bBDD.Avion' Puede moverla o quitarla según sea necesario.
            this.avionTableAdapter.Fill(this.bBDD.Avion);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdAVion ventana6 = new IdAVion();
            ventana6.Show();
            this.Visible = false;
        }
    }
}
