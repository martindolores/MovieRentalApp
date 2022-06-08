
namespace loginForm
{
    partial class IssuedReturnedMovies
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
            this.dataGridIssuedList = new System.Windows.Forms.DataGridView();
            this.dataGridReturnedList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIssuedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturnedList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIssuedList
            // 
            this.dataGridIssuedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIssuedList.Location = new System.Drawing.Point(36, 83);
            this.dataGridIssuedList.Name = "dataGridIssuedList";
            this.dataGridIssuedList.RowHeadersWidth = 51;
            this.dataGridIssuedList.RowTemplate.Height = 24;
            this.dataGridIssuedList.Size = new System.Drawing.Size(1177, 280);
            this.dataGridIssuedList.TabIndex = 9;
            // 
            // dataGridReturnedList
            // 
            this.dataGridReturnedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReturnedList.Location = new System.Drawing.Point(36, 456);
            this.dataGridReturnedList.Name = "dataGridReturnedList";
            this.dataGridReturnedList.RowHeadersWidth = 51;
            this.dataGridReturnedList.RowTemplate.Height = 24;
            this.dataGridReturnedList.Size = new System.Drawing.Size(1177, 280);
            this.dataGridReturnedList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Issued Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Returned Movies";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1182, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IssuedReturnedMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 798);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridReturnedList);
            this.Controls.Add(this.dataGridIssuedList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssuedReturnedMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuedReturnedMovies";
            this.Load += new System.EventHandler(this.IssuedReturnedMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIssuedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturnedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIssuedList;
        private System.Windows.Forms.DataGridView dataGridReturnedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}