using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransfer
{
    public partial class ConnectionStringControl : UserControl
    {
        public ConnectionStringControl()
        {
            InitializeComponent();
        }

        public Object Servers
        {
            get
            {
                return ServerCombo.DataSource;
            }
            set
            {

                ServerCombo.DataSource = value;
                ServerCombo.SelectedIndex = -1;
            }
        }

        public Object DataBases
        {
            get
            {
                return DataBaseCombo.DataSource;
            }
            set
            {

                DataBaseCombo.DataSource = value;
                DataBaseCombo.SelectedIndex = -1;
            }
        }

        public string Server
        {
            get
            {
                return ServerCombo.Text.Trim();
            }
            set
            {

                ServerCombo.Text = value;
            }
        }

        public string DataBase
        {
            get
            {
                return DataBaseCombo.Text.Trim();
            }
            set
            {

                DataBaseCombo.Text = value;
            }
        }

        public string UserName
        {
            get
            {
                return userTextBox.Text.Trim();
            }
            set
            {

                userTextBox.Text = value;
            }
        }
        public string password
        {
            get
            {
                return passwordTextBox.Text.Trim();
            }
            set
            {

                passwordTextBox.Text = value;
            }
        }

       public string GetConnectionString()
        {
            if (userTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                return String.Format("data source={0};database={1};", ServerCombo.Text, DataBaseCombo);
            }
            else
            {
                return String.Format("data source={0};database={1};uid={2};pwd={3}", ServerCombo.Text, DataBaseCombo, userTextBox, passwordTextBox.Text);
            }
            
        }


        public delegate void SelectionChangeCommitted(string serverName);
        public event SelectionChangeCommitted SelectionChangeCommittedEvent;



        private void ServerCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            if (ServerCombo.SelectedIndex >= 0)
            {
                SelectionChangeCommittedEvent(senderComboBox.SelectedItem.ToString());
            }
        }

        private void ServerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}