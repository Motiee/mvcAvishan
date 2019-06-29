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
    public partial class frm_connectionString : Form
    {

        private readonly DBConnection.enConnectionType _enConnectionType;
        private readonly List<string> _Instances;
        public frm_connectionString(List<string> Instance,DBConnection.enConnectionType enConnectionType)
        {
            _Instances = Instance;
            _enConnectionType = enConnectionType;
            InitializeComponent();
        }

        private void frm_connectionString_Load(object sender, EventArgs e)
        {
            this.Text = _enConnectionType.ToString();
            connectionStringControl1.Servers = _Instances;
            connectionStringControl1.set(DBConnection.GetConnectionString(_enConnectionType));
        }

        private void connectionStringControl1_SelectionChangeCommittedEvent(string serverName)
        {
            connectionStringControl1.DataBases = DataBaseHelper.GetDatabases(serverName);
        }
        private void SourceTestConnectionBTN_Click(object sender, EventArgs e)
        {
            if (DataBaseHelper.TestConnection(connectionStringControl1.Server, connectionStringControl1.UserName, connectionStringControl1.password))
            {
                MessageBox.Show("successful");
                DBConnection.SetConnectionString(_enConnectionType, connectionStringControl1.Get());
            }
            else
            {

                MessageBox.Show("error!");
            }
        }
    }
}
