namespace PrimalLauncherDataViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tcMainGrid = new System.Windows.Forms.TabControl();
            this.lbSheets = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchEquals = new System.Windows.Forms.RadioButton();
            this.searchContains = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1899, 991);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.11236F));
            this.tableLayoutPanel1.Controls.Add(this.tcMainGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbSheets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.093168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.90683F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1899, 991);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tcMainGrid
            // 
            this.tcMainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMainGrid.Location = new System.Drawing.Point(286, 54);
            this.tcMainGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcMainGrid.Name = "tcMainGrid";
            this.tcMainGrid.SelectedIndex = 0;
            this.tcMainGrid.Size = new System.Drawing.Size(1609, 933);
            this.tcMainGrid.TabIndex = 13;
            // 
            // lbSheets
            // 
            this.lbSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSheets.FormattingEnabled = true;
            this.lbSheets.ItemHeight = 16;
            this.lbSheets.Location = new System.Drawing.Point(4, 54);
            this.lbSheets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSheets.Name = "lbSheets";
            this.lbSheets.Size = new System.Drawing.Size(274, 933);
            this.lbSheets.TabIndex = 7;
            this.lbSheets.SelectedIndexChanged += new System.EventHandler(this.lbSheets_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(286, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1609, 42);
            this.panel3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchEquals);
            this.groupBox1.Controls.Add(this.searchContains);
            this.groupBox1.Location = new System.Drawing.Point(787, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search type";
            // 
            // searchEquals
            // 
            this.searchEquals.AutoSize = true;
            this.searchEquals.Location = new System.Drawing.Point(106, 16);
            this.searchEquals.Name = "searchEquals";
            this.searchEquals.Size = new System.Drawing.Size(67, 20);
            this.searchEquals.TabIndex = 1;
            this.searchEquals.TabStop = true;
            this.searchEquals.Text = "Equals";
            this.searchEquals.UseVisualStyleBackColor = true;
            // 
            // searchContains
            // 
            this.searchContains.AutoSize = true;
            this.searchContains.Location = new System.Drawing.Point(11, 16);
            this.searchContains.Name = "searchContains";
            this.searchContains.Size = new System.Drawing.Size(77, 20);
            this.searchContains.TabIndex = 0;
            this.searchContains.TabStop = true;
            this.searchContains.Text = "Contains";
            this.searchContains.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1468, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search All Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1020, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1077, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 991);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "The Primal Data Viewer";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbSheets;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tcMainGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchEquals;
        private System.Windows.Forms.RadioButton searchContains;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

