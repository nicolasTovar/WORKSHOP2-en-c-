using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORKSHOP2
{
    public partial class FrmDataView : Form
    {
        Dato dato = new Dato();

        public FrmDataView()
        {
            InitializeComponent();
        }

        private void dgSql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataView_Load(object sender, EventArgs e)
        {
            dato.mostrarNombre(ref cbCategoria);
            lstFiltro.Items.Add("CodProd");
            lstFiltro.Items.Add("NomProd");
            lstFiltro.Items.Add("CodCat");
           
            this.dgSql.DataSource = dato.mostrarTabla().Tables[0].DefaultView;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.dgSql.DataSource = dato.mostrarInicial(txtMostrar.Text.Trim().ToString()).Tables[0].DefaultView;

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgSql.DataSource = dato.comboNombre(cbCategoria.Text.Trim().ToString()).Tables[0].DefaultView;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.dgSql.DataSource = dato.mostrarTabla().Tables[0].DefaultView;
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            this.dgSql.DataSource = dato.ascendente(lstFiltro.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.dgSql.DataSource = dato.descendente(lstFiltro.Text.ToString()).Tables[0].DefaultView;
        }
    }
}
