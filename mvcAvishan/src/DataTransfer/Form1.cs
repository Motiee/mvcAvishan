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

            List<string> list1 = DataBaseHelper.GetInstances();
            List<string> list2 = new List<string>(list1);

            connectionStringControl1.Servers = list1;
            connectionStringControl2.Servers = list2;

            connectionStringControl1.set(DBConnection.GetConnectionString(DBConnection.enConnectionType.source));
            connectionStringControl2.set(DBConnection.GetConnectionString(DBConnection.enConnectionType.Target));
        }

      
        private void connectionStringControl1_SelectionChangeCommittedEvent(string serverName)
        {
            connectionStringControl1.DataBases = DataBaseHelper.GetDatabases(serverName);
        }

        private void connectionStringControl2_SelectionChangeCommittedEvent(string serverName)
        {
            connectionStringControl2.DataBases = DataBaseHelper.GetDatabases(serverName);
        }

        private void SourceTestConnectionBTN_Click(object sender, EventArgs e)
        {
            if(DataBaseHelper.TestConnection(connectionStringControl1.Server, connectionStringControl1.UserName, connectionStringControl1.password))
            {
                MessageBox.Show("successful");
                DBConnection.SetConnectionString(DBConnection.enConnectionType.source, connectionStringControl1.Get());
            }
            else
            {

                MessageBox.Show("error!");
            }
        }

        private void TargetTestConnectionBTN_Click(object sender, EventArgs e)
        {
            if (DataBaseHelper.TestConnection(connectionStringControl2.Server, connectionStringControl2.UserName, connectionStringControl2.password))
            {
                MessageBox.Show("successful");
                DBConnection.SetConnectionString(DBConnection.enConnectionType.Target, connectionStringControl2.Get());
            }
            else
            {

                MessageBox.Show("error!");
            }
        }
    }
}
