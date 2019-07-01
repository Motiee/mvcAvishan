﻿using System;
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

         //   DataBaseHelper.GetInstances();
          
        }
           
  


        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_connectionString frm = new frm_connectionString(DataBaseHelper.Instaces,DBConnection.enConnectionType.SourceConnectionString);
            frm.ShowDialog();
        }

        private void targetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_connectionString frm = new frm_connectionString(DataBaseHelper.Instaces, DBConnection.enConnectionType.TargetConnectionString);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.Source.Source_Facture facture = new DAL.Source.Source_Facture();
            facture.Get_Facture_Service_Kinds();

            DAL.Source.Source_FactureContainer factureContainer = new DAL.Source.Source_FactureContainer();
            factureContainer.Get_Ware_and_Quantity();

            DAL.Source.Source_Ware source_Ware = new DAL.Source.Source_Ware();
            var a = source_Ware.Get_Ware();

            DAL.Source.Source_Setting Source_Setting = new DAL.Source.Source_Setting();
            Source_Setting.Get_Setting();
           


            GenericXMLSerializer<List<DAL.Source.Target_Ware>> genericXMLSerializer = new GenericXMLSerializer<List<DAL.Source.Target_Ware>>("Target_Ware");

             genericXMLSerializer.Serialize(a);


            dataGridView1.DataSource = genericXMLSerializer.Deserialize();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GenericXMLSerializer<List<DAL.Source.Target_Ware>> genericXMLSerializer = new GenericXMLSerializer<List<DAL.Source.Target_Ware>>("Target_Ware");
            List<DAL.Source.Target_Ware> b = dataGridView1.DataSource as List<DAL.Source.Target_Ware>;
            genericXMLSerializer.Serialize(b);
        }
    }
}
