using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WORKSHOP2
{
    public partial class FrmAdo : Form
    {
        DataSet ds = new DataSet();
        Dato dato = new Dato();
        public FrmAdo()
        {
            InitializeComponent();
        }

        private void FrmAdo_Load(object sender, EventArgs e)
        {

        }

        private void btnConRel_Click(object sender, EventArgs e)
        {
            ds = dato.obtenerTablas();
            ds.Relations.Add("Exhibir producto", ds.Tables[0].Columns[0], ds.Tables[1].Columns[2]);
            this.dgDatos.DataSource= ds;
            this.dgDatos.DataMember = "Categoria";
        }
        
        private void btnSinRel_Click(object sender, EventArgs e)
        {
            ds = dato.obtenerTablas();
            //ds.Relations.Add("Exhibir producto", ds.Tables[0].Columns[0], ds.Tables[1].Columns[2]);
            this.dgDatos.DataSource = ds;
            this.dgDatos.DataMember = "Categoria";
        }
    }
}
