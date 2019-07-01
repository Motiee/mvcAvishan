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

            public delegate void SelectionChangeCommitted(string serverName);
        public event SelectionChangeCommitted SelectionChangeCommittedEvent;

        public void set(ConnectionString obj)
        {
            try
            {
                if (obj.Server!= null){ Server = obj.Server; }
                if (obj.DataBase != null) { DataBase = obj.DataBase; }
                if (obj.UserName != null) { UserName = obj.UserName; }
                if (obj.Password != null) { password = obj.Password; }
            }
            catch
            {

            }
        }

        public ConnectionString Get()
        {
            ConnectionString obj = new ConnectionString(Server,DataBase,UserName,password);
            return obj;

        }

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