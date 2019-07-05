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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtX = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRestaurantTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestaurantAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.chkHasSeat = new System.Windows.Forms.CheckBox();
            this.chkHasDelivery = new System.Windows.Forms.CheckBox();
            this.chkHasToGo = new System.Windows.Forms.CheckBox();
            this.chkHasPOS = new System.Windows.Forms.CheckBox();
            this.chkHasParking = new System.Windows.Forms.CheckBox();
            this.chkHasHokan = new System.Windows.Forms.CheckBox();
            this.chkHasHealthyFood = new System.Windows.Forms.CheckBox();
            this.chkHasSeaFood = new System.Windows.Forms.CheckBox();
            this.txtTwoPersonCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRestaurantId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.txtX.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStringToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionStringToolStripMenuItem
            // 
            this.connectionStringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.targetToolStripMenuItem});
            this.connectionStringToolStripMenuItem.Name = "connectionStringToolStripMenuItem";
            this.connectionStringToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.connectionStringToolStripMenuItem.Text = "ConnectionString";
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.sourceToolStripMenuItem.Text = "Source";
            this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
            // 
            // targetToolStripMenuItem
            // 
            this.targetToolStripMenuItem.Name = "targetToolStripMenuItem";
            this.targetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.targetToolStripMenuItem.Text = "Target";
            this.targetToolStripMenuItem.Click += new System.EventHandler(this.targetToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.76423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.23577F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.txtX);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 273);
            this.tabControl1.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtX.Controls.Add(this.chkHasSeaFood);
            this.txtX.Controls.Add(this.chkHasHealthyFood);
            this.txtX.Controls.Add(this.chkHasHokan);
            this.txtX.Controls.Add(this.chkHasParking);
            this.txtX.Controls.Add(this.chkHasPOS);
            this.txtX.Controls.Add(this.chkHasToGo);
            this.txtX.Controls.Add(this.chkHasDelivery);
            this.txtX.Controls.Add(this.chkHasSeat);
            this.txtX.Controls.Add(this.lblY);
            this.txtX.Controls.Add(this.lblX);
            this.txtX.Controls.Add(this.label4);
            this.txtX.Controls.Add(this.label3);
            this.txtX.Controls.Add(this.txtY);
            this.txtX.Controls.Add(this.textBox1);
            this.txtX.Controls.Add(this.txtTwoPersonCost);
            this.txtX.Controls.Add(this.txtPhone);
            this.txtX.Controls.Add(this.label2);
            this.txtX.Controls.Add(this.txtRestaurantAddress);
            this.txtX.Controls.Add(this.label5);
            this.txtX.Controls.Add(this.label1);
            this.txtX.Controls.Add(this.txtRestaurantId);
            this.txtX.Controls.Add(this.txtRestaurantTitle);
            this.txtX.Location = new System.Drawing.Point(4, 22);
            this.txtX.Name = "txtX";
            this.txtX.Padding = new System.Windows.Forms.Padding(3);
            this.txtX.Size = new System.Drawing.Size(786, 247);
            this.txtX.TabIndex = 0;
            this.txtX.Text = "Tab_Resturant";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtRestaurantTitle
            // 
            this.txtRestaurantTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestaurantTitle.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurantTitle.Location = new System.Drawing.Point(490, 6);
            this.txtRestaurantTitle.Name = "txtRestaurantTitle";
            this.txtRestaurantTitle.Size = new System.Drawing.Size(198, 33);
            this.txtRestaurantTitle.TabIndex = 0;
            this.txtRestaurantTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام رستوران";
            // 
            // txtRestaurantAddress
            // 
            this.txtRestaurantAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestaurantAddress.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurantAddress.Location = new System.Drawing.Point(204, 42);
            this.txtRestaurantAddress.Name = "txtRestaurantAddress";
            this.txtRestaurantAddress.Size = new System.Drawing.Size(484, 33);
            this.txtRestaurantAddress.TabIndex = 0;
            this.txtRestaurantAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "آدرس رستوران";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(490, 79);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 33);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "تلفن رستوران";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(490, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(695, 123);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 22);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // txtY
            // 
            this.txtY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtY.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(490, 157);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(198, 33);
            this.txtY.TabIndex = 0;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(695, 162);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 22);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // chkHasSeat
            // 
            this.chkHasSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasSeat.AutoSize = true;
            this.chkHasSeat.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasSeat.Location = new System.Drawing.Point(671, 196);
            this.chkHasSeat.Name = "chkHasSeat";
            this.chkHasSeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasSeat.Size = new System.Drawing.Size(109, 31);
            this.chkHasSeat.TabIndex = 2;
            this.chkHasSeat.Text = "محل نشستن";
            this.chkHasSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHasSeat.UseVisualStyleBackColor = true;
            // 
            // chkHasDelivery
            // 
            this.chkHasDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasDelivery.AutoSize = true;
            this.chkHasDelivery.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasDelivery.Location = new System.Drawing.Point(609, 196);
            this.chkHasDelivery.Name = "chkHasDelivery";
            this.chkHasDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasDelivery.Size = new System.Drawing.Size(56, 31);
            this.chkHasDelivery.TabIndex = 2;
            this.chkHasDelivery.Text = "پیک";
            this.chkHasDelivery.UseVisualStyleBackColor = true;
            // 
            // chkHasToGo
            // 
            this.chkHasToGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasToGo.AutoSize = true;
            this.chkHasToGo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasToGo.Location = new System.Drawing.Point(526, 196);
            this.chkHasToGo.Name = "chkHasToGo";
            this.chkHasToGo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasToGo.Size = new System.Drawing.Size(77, 31);
            this.chkHasToGo.TabIndex = 2;
            this.chkHasToGo.Text = "بیرون بر";
            this.chkHasToGo.UseVisualStyleBackColor = true;
            // 
            // chkHasPOS
            // 
            this.chkHasPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasPOS.AutoSize = true;
            this.chkHasPOS.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasPOS.Location = new System.Drawing.Point(426, 196);
            this.chkHasPOS.Name = "chkHasPOS";
            this.chkHasPOS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasPOS.Size = new System.Drawing.Size(94, 31);
            this.chkHasPOS.TabIndex = 2;
            this.chkHasPOS.Text = "کارت خوان";
            this.chkHasPOS.UseVisualStyleBackColor = true;
            // 
            // chkHasParking
            // 
            this.chkHasParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasParking.AutoSize = true;
            this.chkHasParking.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasParking.Location = new System.Drawing.Point(343, 196);
            this.chkHasParking.Name = "chkHasParking";
            this.chkHasParking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasParking.Size = new System.Drawing.Size(77, 31);
            this.chkHasParking.TabIndex = 2;
            this.chkHasParking.Text = "پارکینگ";
            this.chkHasParking.UseVisualStyleBackColor = true;
            // 
            // chkHasHokan
            // 
            this.chkHasHokan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasHokan.AutoSize = true;
            this.chkHasHokan.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasHokan.Location = new System.Drawing.Point(275, 196);
            this.chkHasHokan.Name = "chkHasHokan";
            this.chkHasHokan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasHokan.Size = new System.Drawing.Size(62, 31);
            this.chkHasHokan.TabIndex = 2;
            this.chkHasHokan.Text = "قلیان";
            this.chkHasHokan.UseVisualStyleBackColor = true;
            // 
            // chkHasHealthyFood
            // 
            this.chkHasHealthyFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasHealthyFood.AutoSize = true;
            this.chkHasHealthyFood.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasHealthyFood.Location = new System.Drawing.Point(174, 196);
            this.chkHasHealthyFood.Name = "chkHasHealthyFood";
            this.chkHasHealthyFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasHealthyFood.Size = new System.Drawing.Size(95, 31);
            this.chkHasHealthyFood.TabIndex = 2;
            this.chkHasHealthyFood.Text = "غذای سالم";
            this.chkHasHealthyFood.UseVisualStyleBackColor = true;
            // 
            // chkHasSeaFood
            // 
            this.chkHasSeaFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasSeaFood.AutoSize = true;
            this.chkHasSeaFood.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasSeaFood.Location = new System.Drawing.Point(65, 196);
            this.chkHasSeaFood.Name = "chkHasSeaFood";
            this.chkHasSeaFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHasSeaFood.Size = new System.Drawing.Size(103, 31);
            this.chkHasSeaFood.TabIndex = 2;
            this.chkHasSeaFood.Text = "غذای دریایی";
            this.chkHasSeaFood.UseVisualStyleBackColor = true;
            // 
            // txtTwoPersonCost
            // 
            this.txtTwoPersonCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTwoPersonCost.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwoPersonCost.Location = new System.Drawing.Point(204, 79);
            this.txtTwoPersonCost.Name = "txtTwoPersonCost";
            this.txtTwoPersonCost.Size = new System.Drawing.Size(198, 33);
            this.txtTwoPersonCost.TabIndex = 0;
            this.txtTwoPersonCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "غذا برای 2 نفر";
            // 
            // txtRestaurantId
            // 
            this.txtRestaurantId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestaurantId.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurantId.Location = new System.Drawing.Point(204, 6);
            this.txtRestaurantId.Name = "txtRestaurantId";
            this.txtRestaurantId.Size = new System.Drawing.Size(198, 33);
            this.txtRestaurantId.TabIndex = 0;
            this.txtRestaurantId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = " کد رستوران";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.txtX.ResumeLayout(false);
            this.txtX.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage txtX;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtRestaurantTitle;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestaurantAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHasSeaFood;
        private System.Windows.Forms.CheckBox chkHasHealthyFood;
        private System.Windows.Forms.CheckBox chkHasHokan;
        private System.Windows.Forms.CheckBox chkHasParking;
        private System.Windows.Forms.CheckBox chkHasPOS;
        private System.Windows.Forms.CheckBox chkHasToGo;
        private System.Windows.Forms.CheckBox chkHasDelivery;
        private System.Windows.Forms.CheckBox chkHasSeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTwoPersonCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRestaurantId;
    }
}

