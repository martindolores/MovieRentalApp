
namespace loginForm
{
    partial class viewMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMovie));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridMovieList = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.txtmGenres = new System.Windows.Forms.TextBox();
            this.txtmRating = new System.Windows.Forms.TextBox();
            this.dateTimePurDate = new System.Windows.Forms.DateTimePicker();
            this.txtmPrice = new System.Windows.Forms.TextBox();
            this.txtmQuan = new System.Windows.Forms.TextBox();
            this.txtmDirectors = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelMovieInfo = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).BeginInit();
            this.panelMovieInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtmSearch);
            this.panel3.Location = new System.Drawing.Point(24, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1144, 79);
            this.panel3.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(667, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Name:";
            // 
            // txtmSearch
            // 
            this.txtmSearch.Location = new System.Drawing.Point(499, 26);
            this.txtmSearch.Name = "txtmSearch";
            this.txtmSearch.Size = new System.Drawing.Size(153, 22);
            this.txtmSearch.TabIndex = 0;
            this.txtmSearch.TextChanged += new System.EventHandler(this.txtmSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(577, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "View Movies";
            // 
            // dataGridMovieList
            // 
            this.dataGridMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovieList.Location = new System.Drawing.Point(24, 170);
            this.dataGridMovieList.Name = "dataGridMovieList";
            this.dataGridMovieList.RowHeadersWidth = 51;
            this.dataGridMovieList.RowTemplate.Height = 24;
            this.dataGridMovieList.Size = new System.Drawing.Size(1144, 341);
            this.dataGridMovieList.TabIndex = 6;
            this.dataGridMovieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMovieList_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1137, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movie Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Directors:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(729, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Purchase Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Price:";
            // 
            // txtmName
            // 
            this.txtmName.Location = new System.Drawing.Point(140, 61);
            this.txtmName.Name = "txtmName";
            this.txtmName.Size = new System.Drawing.Size(181, 22);
            this.txtmName.TabIndex = 8;
            // 
            // txtmGenres
            // 
            this.txtmGenres.Location = new System.Drawing.Point(140, 253);
            this.txtmGenres.Name = "txtmGenres";
            this.txtmGenres.Size = new System.Drawing.Size(181, 22);
            this.txtmGenres.TabIndex = 13;
            // 
            // txtmRating
            // 
            this.txtmRating.Location = new System.Drawing.Point(140, 157);
            this.txtmRating.Name = "txtmRating";
            this.txtmRating.Size = new System.Drawing.Size(181, 22);
            this.txtmRating.TabIndex = 14;
            // 
            // dateTimePurDate
            // 
            this.dateTimePurDate.Location = new System.Drawing.Point(872, 55);
            this.dateTimePurDate.Name = "dateTimePurDate";
            this.dateTimePurDate.Size = new System.Drawing.Size(225, 22);
            this.dateTimePurDate.TabIndex = 15;
            // 
            // txtmPrice
            // 
            this.txtmPrice.Location = new System.Drawing.Point(505, 156);
            this.txtmPrice.Name = "txtmPrice";
            this.txtmPrice.Size = new System.Drawing.Size(181, 22);
            this.txtmPrice.TabIndex = 16;
            // 
            // txtmQuan
            // 
            this.txtmQuan.Location = new System.Drawing.Point(505, 253);
            this.txtmQuan.Name = "txtmQuan";
            this.txtmQuan.Size = new System.Drawing.Size(181, 22);
            this.txtmQuan.TabIndex = 17;
            // 
            // txtmDirectors
            // 
            this.txtmDirectors.Location = new System.Drawing.Point(505, 61);
            this.txtmDirectors.Name = "txtmDirectors";
            this.txtmDirectors.Size = new System.Drawing.Size(181, 22);
            this.txtmDirectors.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(749, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(872, 248);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 28);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(993, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelMovieInfo
            // 
            this.panelMovieInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMovieInfo.Controls.Add(this.btnDelete);
            this.panelMovieInfo.Controls.Add(this.btnClear);
            this.panelMovieInfo.Controls.Add(this.btnUpdate);
            this.panelMovieInfo.Controls.Add(this.txtmDirectors);
            this.panelMovieInfo.Controls.Add(this.txtmQuan);
            this.panelMovieInfo.Controls.Add(this.txtmPrice);
            this.panelMovieInfo.Controls.Add(this.dateTimePurDate);
            this.panelMovieInfo.Controls.Add(this.txtmRating);
            this.panelMovieInfo.Controls.Add(this.txtmGenres);
            this.panelMovieInfo.Controls.Add(this.txtmName);
            this.panelMovieInfo.Controls.Add(this.label9);
            this.panelMovieInfo.Controls.Add(this.label7);
            this.panelMovieInfo.Controls.Add(this.label6);
            this.panelMovieInfo.Controls.Add(this.label5);
            this.panelMovieInfo.Controls.Add(this.label4);
            this.panelMovieInfo.Controls.Add(this.label3);
            this.panelMovieInfo.Controls.Add(this.label2);
            this.panelMovieInfo.Location = new System.Drawing.Point(24, 517);
            this.panelMovieInfo.Name = "panelMovieInfo";
            this.panelMovieInfo.Size = new System.Drawing.Size(1144, 328);
            this.panelMovieInfo.TabIndex = 7;
            // 
            // viewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 701);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelMovieInfo);
            this.Controls.Add(this.dataGridMovieList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewMovie";
            this.Load += new System.EventHandler(this.viewMovie_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).EndInit();
            this.panelMovieInfo.ResumeLayout(false);
            this.panelMovieInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridMovieList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmName;
        private System.Windows.Forms.TextBox txtmGenres;
        private System.Windows.Forms.TextBox txtmRating;
        private System.Windows.Forms.DateTimePicker dateTimePurDate;
        private System.Windows.Forms.TextBox txtmPrice;
        private System.Windows.Forms.TextBox txtmQuan;
        private System.Windows.Forms.TextBox txtmDirectors;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelMovieInfo;
    }
}