using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            //dt.Columns.Add(new DataColumn("Fin", typeof(bool)));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = alerta.PreguntaOkCancel("¿Está seguro de que desea salir?");
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
