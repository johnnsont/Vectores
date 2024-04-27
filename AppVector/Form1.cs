using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class Frmvectores : Form
    {
        //creando una instancia de mi clase vector
        clsVector v = new clsVector();
        public Frmvectores()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbresultado.Text = "";
            for (int i = 0; i < v.longitud(); i++) {
                lbresultado.Text = lbresultado.Text + v.obtenervalor(i) + ",";
            }
            lbresultado.Text = lbresultado.Text + "]";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }
    }
}
