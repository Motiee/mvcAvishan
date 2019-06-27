namespace DataTransfer
{
    partial class Form1
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
            this.MainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderTLP = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceTestConnectionBTN = new System.Windows.Forms.Button();
            this.TargetTestConnectionBTN = new System.Windows.Forms.Button();
            this.connectionStringControl1 = new DataTransfer.ConnectionStringControl();
            this.connectionStringControl2 = new DataTransfer.ConnectionStringControl();
            this.MainTLP.SuspendLayout();
            this.HeaderTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTLP
            // 
            this.MainTLP.ColumnCount = 1;
            this.MainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTLP.Controls.Add(this.HeaderTLP, 0, 0);
            this.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTLP.Location = new System.Drawing.Point(0, 0);
            this.MainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.MainTLP.Name = "MainTLP";
            this.MainTLP.RowCount = 3;
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.MainTLP.Size = new System.Drawing.Size(800, 450);
            this.MainTLP.TabIndex = 0;
            // 
            // HeaderTLP
            // 
            this.HeaderTLP.ColumnCount = 3;
            this.HeaderTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.HeaderTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.47369F));
            this.HeaderTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.HeaderTLP.Controls.Add(this.connectionStringControl1, 1, 0);
            this.HeaderTLP.Controls.Add(this.connectionStringControl2, 1, 1);
            this.HeaderTLP.Controls.Add(this.label1, 0, 0);
            this.HeaderTLP.Controls.Add(this.label2, 0, 1);
            this.HeaderTLP.Controls.Add(this.SourceTestConnectionBTN, 2, 0);
            this.HeaderTLP.Controls.Add(this.TargetTestConnectionBTN, 2, 1);
            this.HeaderTLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTLP.Location = new System.Drawing.Point(0, 0);
            this.HeaderTLP.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderTLP.Name = "HeaderTLP";
            this.HeaderTLP.RowCount = 2;
            this.HeaderTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTLP.Size = new System.Drawing.Size(800, 56);
            this.HeaderTLP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source DB :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target DB:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceTestConnectionBTN
            // 
            this.SourceTestConnectionBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTestConnectionBTN.Location = new System.Drawing.Point(689, 0);
            this.SourceTestConnectionBTN.Margin = new System.Windows.Forms.Padding(0);
            this.SourceTestConnectionBTN.Name = "SourceTestConnectionBTN";
            this.SourceTestConnectionBTN.Size = new System.Drawing.Size(111, 28);
            this.SourceTestConnectionBTN.TabIndex = 2;
            this.SourceTestConnectionBTN.Text = "Test Connection";
            this.SourceTestConnectionBTN.UseVisualStyleBackColor = true;
            this.SourceTestConnectionBTN.Click += new System.EventHandler(this.SourceTestConnectionBTN_Click);
            // 
            // TargetTestConnectionBTN
            // 
            this.TargetTestConnectionBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetTestConnectionBTN.Location = new System.Drawing.Point(689, 28);
            this.TargetTestConnectionBTN.Margin = new System.Windows.Forms.Padding(0);
            this.TargetTestConnectionBTN.Name = "TargetTestConnectionBTN";
            this.TargetTestConnectionBTN.Size = new System.Drawing.Size(111, 28);
            this.TargetTestConnectionBTN.TabIndex = 2;
            this.TargetTestConnectionBTN.Text = "Test Connection";
            this.TargetTestConnectionBTN.UseVisualStyleBackColor = true;
            this.TargetTestConnectionBTN.Click += new System.EventHandler(this.TargetTestConnectionBTN_Click);
            // 
            // connectionStringControl1
            // 
            this.connectionStringControl1.DataBase = "";
            this.connectionStringControl1.DataBases = null;
            this.connectionStringControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionStringControl1.Location = new System.Drawing.Point(72, 0);
            this.connectionStringControl1.Margin = new System.Windows.Forms.Padding(0);
            this.connectionStringControl1.Name = "connectionStringControl1";
            this.connectionStringControl1.password = "";
            this.connectionStringControl1.Server = "";
            this.connectionStringControl1.Servers = null;
            this.connectionStringControl1.Size = new System.Drawing.Size(617, 28);
            this.connectionStringControl1.TabIndex = 0;
            this.connectionStringControl1.UserName = "";
            this.connectionStringControl1.SelectionChangeCommittedEvent += new DataTransfer.ConnectionStringControl.SelectionChangeCommitted(this.connectionStringControl1_SelectionChangeCommittedEvent);
            // 
            // connectionStringControl2
            // 
            this.connectionStringControl2.DataBase = "";
            this.connectionStringControl2.DataBases = null;
            this.connectionStringControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionStringControl2.Location = new System.Drawing.Point(72, 28);
            this.connectionStringControl2.Margin = new System.Windows.Forms.Padding(0);
            this.connectionStringControl2.Name = "connectionStringControl2";
            this.connectionStringControl2.password = "";
            this.connectionStringControl2.Server = "";
            this.connectionStringControl2.Servers = null;
            this.connectionStringControl2.Size = new System.Drawing.Size(617, 28);
            this.connectionStringControl2.TabIndex = 0;
            this.connectionStringControl2.UserName = "";
            this.connectionStringControl2.SelectionChangeCommittedEvent += new DataTransfer.ConnectionStringControl.SelectionChangeCommitted(this.connectionStringControl2_SelectionChangeCommittedEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTLP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTLP.ResumeLayout(false);
            this.HeaderTLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTLP;
        private ConnectionStringControl connectionStringControl1;
        private System.Windows.Forms.TableLayoutPanel HeaderTLP;
        private ConnectionStringControl connectionStringControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SourceTestConnectionBTN;
        private System.Windows.Forms.Button TargetTestConnectionBTN;
    }
}

