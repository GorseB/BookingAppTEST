namespace BookingAppTEST
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
            this.CBX1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Create_Table = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBX1
            // 
            this.CBX1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX1.FormattingEnabled = true;
            this.CBX1.Location = new System.Drawing.Point(12, 12);
            this.CBX1.Name = "CBX1";
            this.CBX1.Size = new System.Drawing.Size(888, 21);
            this.CBX1.TabIndex = 0;
            this.CBX1.SelectedIndexChanged += new System.EventHandler(this.CBX1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(888, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Create_Table
            // 
            this.btn_Create_Table.Location = new System.Drawing.Point(12, 195);
            this.btn_Create_Table.Name = "btn_Create_Table";
            this.btn_Create_Table.Size = new System.Drawing.Size(170, 108);
            this.btn_Create_Table.TabIndex = 2;
            this.btn_Create_Table.Text = "--Create Table--";
            this.btn_Create_Table.UseVisualStyleBackColor = true;
            this.btn_Create_Table.Click += new System.EventHandler(this.btn_Create_Table_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(188, 195);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(170, 108);
            this.btn_Book.TabIndex = 3;
            this.btn_Book.Text = "---Create Booking---";
            this.btn_Book.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 315);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.btn_Create_Table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CBX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Layout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Create_Table;
        private System.Windows.Forms.Button btn_Book;
    }
}

