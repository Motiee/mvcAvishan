namespace DataTransfer
{
    partial class frm_connectionString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionStringControl1 = new DataTransfer.ConnectionStringControl();
            this.SourceTestConnectionBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionStringControl1
            // 
            this.connectionStringControl1.DataBase = "";
            this.connectionStringControl1.DataBases = null;
            this.connectionStringControl1.Location = new System.Drawing.Point(6, 6);
            this.connectionStringControl1.Margin = new System.Windows.Forms.Padding(0);
            this.connectionStringControl1.Name = "connectionStringControl1";
            this.connectionStringControl1.password = "";
            this.connectionStringControl1.Server = "";
            this.connectionStringControl1.Servers = null;
            this.connectionStringControl1.Size = new System.Drawing.Size(250, 168);
            this.connectionStringControl1.TabIndex = 0;
            this.connectionStringControl1.UserName = "";
            this.connectionStringControl1.SelectionChangeCommittedEvent += new DataTransfer.ConnectionStringControl.SelectionChangeCommitted(this.connectionStringControl1_SelectionChangeCommittedEvent);
            // 
            // SourceTestConnectionBTN
            // 
            this.SourceTestConnectionBTN.Location = new System.Drawing.Point(85, 185);
            this.SourceTestConnectionBTN.Margin = new System.Windows.Forms.Padding(0);
            this.SourceTestConnectionBTN.Name = "SourceTestConnectionBTN";
            this.SourceTestConnectionBTN.Size = new System.Drawing.Size(95, 28);
            this.SourceTestConnectionBTN.TabIndex = 3;
            this.SourceTestConnectionBTN.Text = "Test Connection";
            this.SourceTestConnectionBTN.UseVisualStyleBackColor = true;
            this.SourceTestConnectionBTN.Click += new System.EventHandler(this.SourceTestConnectionBTN_Click);
            // 
            // frm_connectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 222);
            this.Controls.Add(this.SourceTestConnectionBTN);
            this.Controls.Add(this.connectionStringControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_connectionString";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_connectionString_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ConnectionStringControl connectionStringControl1;
        private System.Windows.Forms.Button SourceTestConnectionBTN;
    }
}