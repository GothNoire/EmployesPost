namespace EmployesPost
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bchange = new System.Windows.Forms.Button();
            this.BInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bexit = new System.Windows.Forms.Button();
            this.dbmecinesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmecinesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Bdelete);
            this.panel1.Controls.Add(this.Bchange);
            this.panel1.Controls.Add(this.BInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 69);
            this.panel1.TabIndex = 0;
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(268, 12);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(89, 34);
            this.Bdelete.TabIndex = 2;
            this.Bdelete.Text = "Удалить";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // Bchange
            // 
            this.Bchange.Location = new System.Drawing.Point(146, 12);
            this.Bchange.Name = "Bchange";
            this.Bchange.Size = new System.Drawing.Size(86, 34);
            this.Bchange.TabIndex = 1;
            this.Bchange.Text = "Изменить";
            this.Bchange.UseVisualStyleBackColor = true;
            this.Bchange.Click += new System.EventHandler(this.Bchange_Click);
            // 
            // BInsert
            // 
            this.BInsert.Location = new System.Drawing.Point(24, 12);
            this.BInsert.Name = "BInsert";
            this.BInsert.Size = new System.Drawing.Size(90, 34);
            this.BInsert.TabIndex = 0;
            this.BInsert.Text = "Добавить";
            this.BInsert.UseVisualStyleBackColor = true;
            this.BInsert.Click += new System.EventHandler(this.BInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(789, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 370;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Должность";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 370;
            // 
            // Bexit
            // 
            this.Bexit.Location = new System.Drawing.Point(692, 382);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(75, 23);
            this.Bexit.TabIndex = 2;
            this.Bexit.Text = "Выход";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // dbmecinesDataSet1BindingSource
            // 
            this.dbmecinesDataSet1BindingSource.CurrentChanged += new System.EventHandler(this.dbmecinesDataSet1BindingSource_CurrentChanged);
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.dbmecinesDataSet1BindingSource;
            this.table1BindingSource.CurrentChanged += new System.EventHandler(this.table1BindingSource_CurrentChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 417);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmecinesDataSet1BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bchange;
        private System.Windows.Forms.Button BInsert;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.BindingSource dbmecinesDataSet1BindingSource;
        
        private System.Windows.Forms.BindingSource table1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}