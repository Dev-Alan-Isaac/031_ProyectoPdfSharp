namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Employee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Client = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Qty = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Price = new System.Windows.Forms.NumericUpDown();
            this.button_removeItem = new System.Windows.Forms.Button();
            this.button_addItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.textBox_Item = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Saved = new System.Windows.Forms.Button();
            this.button_Preview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 587);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(112, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invoice Maker";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Employee);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Client);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(3, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Employee:";
            // 
            // textBox_Employee
            // 
            this.textBox_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Employee.Location = new System.Drawing.Point(9, 135);
            this.textBox_Employee.Name = "textBox_Employee";
            this.textBox_Employee.Size = new System.Drawing.Size(343, 24);
            this.textBox_Employee.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client:";
            // 
            // textBox_Client
            // 
            this.textBox_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Client.Location = new System.Drawing.Point(9, 45);
            this.textBox_Client.Name = "textBox_Client";
            this.textBox_Client.Size = new System.Drawing.Size(343, 24);
            this.textBox_Client.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.numericUpDown_Qty);
            this.groupBox1.Controls.Add(this.numericUpDown_Price);
            this.groupBox1.Controls.Add(this.button_removeItem);
            this.groupBox1.Controls.Add(this.button_addItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.textBox_Item);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // numericUpDown_Qty
            // 
            this.numericUpDown_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_Qty.Location = new System.Drawing.Point(9, 149);
            this.numericUpDown_Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Qty.Name = "numericUpDown_Qty";
            this.numericUpDown_Qty.Size = new System.Drawing.Size(343, 28);
            this.numericUpDown_Qty.TabIndex = 9;
            this.numericUpDown_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_Price.Location = new System.Drawing.Point(9, 97);
            this.numericUpDown_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.Size = new System.Drawing.Size(343, 28);
            this.numericUpDown_Price.TabIndex = 8;
            this.numericUpDown_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_removeItem
            // 
            this.button_removeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_removeItem.BackgroundImage = global::Proyecto.Properties.Resources.icons8_minus_96;
            this.button_removeItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_removeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_removeItem.Location = new System.Drawing.Point(306, 192);
            this.button_removeItem.Name = "button_removeItem";
            this.button_removeItem.Size = new System.Drawing.Size(45, 45);
            this.button_removeItem.TabIndex = 7;
            this.button_removeItem.UseVisualStyleBackColor = true;
            this.button_removeItem.Click += new System.EventHandler(this.button_removeItem_Click);
            // 
            // button_addItem
            // 
            this.button_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_addItem.BackgroundImage = global::Proyecto.Properties.Resources.icons8_add_96;
            this.button_addItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addItem.Location = new System.Drawing.Point(12, 192);
            this.button_addItem.Name = "button_addItem";
            this.button_addItem.Size = new System.Drawing.Size(45, 45);
            this.button_addItem.TabIndex = 6;
            this.button_addItem.UseVisualStyleBackColor = true;
            this.button_addItem.Click += new System.EventHandler(this.button_addItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(9, 28);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(45, 18);
            this.Description.TabIndex = 1;
            this.Description.Text = "Item:";
            // 
            // textBox_Item
            // 
            this.textBox_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Item.Location = new System.Drawing.Point(9, 49);
            this.textBox_Item.Name = "textBox_Item";
            this.textBox_Item.Size = new System.Drawing.Size(343, 24);
            this.textBox_Item.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.button_Print);
            this.panel3.Controls.Add(this.button_Saved);
            this.panel3.Controls.Add(this.button_Preview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 498);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 89);
            this.panel3.TabIndex = 1;
            // 
            // button_Print
            // 
            this.button_Print.BackgroundImage = global::Proyecto.Properties.Resources.icons8_print_96;
            this.button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Print.Location = new System.Drawing.Point(270, 3);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(75, 83);
            this.button_Print.TabIndex = 2;
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Saved
            // 
            this.button_Saved.BackgroundImage = global::Proyecto.Properties.Resources.icons8_save_96;
            this.button_Saved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Saved.Location = new System.Drawing.Point(146, 3);
            this.button_Saved.Name = "button_Saved";
            this.button_Saved.Size = new System.Drawing.Size(75, 83);
            this.button_Saved.TabIndex = 1;
            this.button_Saved.UseVisualStyleBackColor = true;
            this.button_Saved.Click += new System.EventHandler(this.button_Saved_Click);
            // 
            // button_Preview
            // 
            this.button_Preview.BackgroundImage = global::Proyecto.Properties.Resources.icons8_preview_pane_96;
            this.button_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Preview.Location = new System.Drawing.Point(22, 3);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(75, 83);
            this.button_Preview.TabIndex = 0;
            this.button_Preview.UseVisualStyleBackColor = true;
            this.button_Preview.Click += new System.EventHandler(this.button_Preview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(367, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 587);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description_Grid,
            this.Quantity_Grid,
            this.PricePerUnit_Grid,
            this.Total_Grid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 470);
            this.dataGridView1.TabIndex = 2;
            // 
            // Description_Grid
            // 
            this.Description_Grid.HeaderText = "Description";
            this.Description_Grid.MinimumWidth = 6;
            this.Description_Grid.Name = "Description_Grid";
            this.Description_Grid.ReadOnly = true;
            // 
            // Quantity_Grid
            // 
            this.Quantity_Grid.HeaderText = "Quantity";
            this.Quantity_Grid.MinimumWidth = 6;
            this.Quantity_Grid.Name = "Quantity_Grid";
            this.Quantity_Grid.ReadOnly = true;
            // 
            // PricePerUnit_Grid
            // 
            this.PricePerUnit_Grid.HeaderText = "Price per Unit";
            this.PricePerUnit_Grid.MinimumWidth = 6;
            this.PricePerUnit_Grid.Name = "PricePerUnit_Grid";
            this.PricePerUnit_Grid.ReadOnly = true;
            // 
            // Total_Grid
            // 
            this.Total_Grid.HeaderText = "Total";
            this.Total_Grid.MinimumWidth = 6;
            this.Total_Grid.Name = "Total_Grid";
            this.Total_Grid.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(951, 89);
            this.panel4.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.cutsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.yearToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.dayToolStripMenuItem.Text = "Day";
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.monthToolStripMenuItem.Text = "Month";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.yearToolStripMenuItem.Text = "Year";
            // 
            // cutsToolStripMenuItem
            // 
            this.cutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayToolStripMenuItem,
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem1});
            this.cutsToolStripMenuItem.Name = "cutsToolStripMenuItem";
            this.cutsToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.cutsToolStripMenuItem.Text = "Cuts";
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.todayToolStripMenuItem.Text = "Today";
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.weekToolStripMenuItem.Text = "Week";
            // 
            // monthToolStripMenuItem1
            // 
            this.monthToolStripMenuItem1.Name = "monthToolStripMenuItem1";
            this.monthToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.monthToolStripMenuItem1.Text = "Month";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Invoice Maker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Price)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Saved;
        private System.Windows.Forms.Button button_Preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textBox_Item;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_removeItem;
        private System.Windows.Forms.Button button_addItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Qty;
        private System.Windows.Forms.NumericUpDown numericUpDown_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Employee;
    }
}

