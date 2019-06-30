using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataBaseHelper.GetInstances();
          
        }
           
  


        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_connectionString frm = new frm_connectionString(DataBaseHelper.Instaces,DBConnection.enConnectionType.source);
            frm.ShowDialog();
        }

        private void targetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_connectionString frm = new frm_connectionString(DataBaseHelper.Instaces, DBConnection.enConnectionType.Target);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.Source.Source_Facture facture = new DAL.Source.Source_Facture();
            facture.Get_Facture_Service_Kinds();
        }
    }
}
