
namespace loginForm
{
    partial class returnMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnMovies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustExit = new System.Windows.Forms.Button();
            this.btnCustRefresh = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridCustList = new System.Windows.Forms.DataGridView();
            this.panelReturnMovie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeiReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustList)).BeginInit();
            this.panelReturnMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 102);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Movie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.btnCustExit);
            this.panel2.Controls.Add(this.btnCustRefresh);
            this.panel2.Controls.Add(this.btnCustSearch);
            this.panel2.Controls.Add(this.txtCustSearch);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 435);
            this.panel2.TabIndex = 4;
            // 
            // btnCustExit
            // 
            this.btnCustExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustExit.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustExit.Location = new System.Drawing.Point(208, 319);
            this.btnCustExit.Name = "btnCustExit";
            this.btnCustExit.Size = new System.Drawing.Size(104, 28);
            this.btnCustExit.TabIndex = 34;
            this.btnCustExit.Text = "Exit";
            this.btnCustExit.UseVisualStyleBackColor = true;
            this.btnCustExit.Click += new System.EventHandler(this.btnCustExit_Click);
            // 
            // btnCustRefresh
            // 
            this.btnCustRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustRefresh.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustRefresh.Location = new System.Drawing.Point(18, 321);
            this.btnCustRefresh.Name = "btnCustRefresh";
            this.btnCustRefresh.Size = new System.Drawing.Size(104, 28);
            this.btnCustRefresh.TabIndex = 33;
            this.btnCustRefresh.Text = "Refresh";
            this.btnCustRefresh.UseVisualStyleBackColor = true;
            this.btnCustRefresh.Click += new System.EventHandler(this.btnCustRefresh_Click);
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustSearch.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch.Location = new System.Drawing.Point(60, 243);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(204, 44);
            this.btnCustSearch.TabIndex = 32;
            this.btnCustSearch.Text = "Search Customer";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.btnCustSearch_Click);
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.Location = new System.Drawing.Point(60, 201);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(204, 22);
            this.txtCustSearch.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Enter Memebr No. :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridCustList
            // 
            this.dataGridCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustList.Location = new System.Drawing.Point(337, 111);
            this.dataGridCustList.Name = "dataGridCustList";
            this.dataGridCustList.RowHeadersWidth = 51;
            this.dataGridCustList.RowTemplate.Height = 24;
            this.dataGridCustList.Size = new System.Drawing.Size(1177, 435);
            this.dataGridCustList.TabIndex = 8;
            this.dataGridCustList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustList_CellClick);
            // 
            // panelReturnMovie
            // 
            this.panelReturnMovie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelReturnMovie.Controls.Add(this.btnReturn);
            this.panelReturnMovie.Controls.Add(this.datetimeiReturnDate);
            this.panelReturnMovie.Controls.Add(this.txtIssueDate);
            this.panelReturnMovie.Controls.Add(this.txtmName);
            this.panelReturnMovie.Controls.Add(this.label4);
            this.panelReturnMovie.Controls.Add(this.label3);
            this.panelReturnMovie.Controls.Add(this.label2);
            this.panelReturnMovie.Location = new System.Drawing.Point(3, 552);
            this.panelReturnMovie.Name = "panelReturnMovie";
            this.panelReturnMovie.Size = new System.Drawing.Size(1511, 349);
            this.panelReturnMovie.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movie Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Return Date:";
            // 
            // datetimeiReturnDate
            // 
            this.datetimeiReturnDate.Location = new System.Drawing.Point(621, 227);
            this.datetimeiReturnDate.Name = "datetimeiReturnDate";
            this.datetimeiReturnDate.Size = new System.Drawing.Size(247, 22);
            this.datetimeiReturnDate.TabIndex = 29;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDate.Location = new System.Drawing.Point(621, 148);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.ReadOnly = true;
            this.txtIssueDate.Size = new System.Drawing.Size(247, 28);
            this.txtIssueDate.TabIndex = 28;
            // 
            // txtmName
            // 
            this.txtmName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmName.Location = new System.Drawing.Point(621, 60);
            this.txtmName.Name = "txtmName";
            this.txtmName.ReadOnly = true;
            this.txtmName.Size = new System.Drawing.Size(247, 28);
            this.txtmName.TabIndex = 27;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(621, 301);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(213, 28);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // returnMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1509, 730);
            this.Controls.Add(this.panelReturnMovie);
            this.Controls.Add(this.dataGridCustList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "returnMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returnMovies";
            this.Load += new System.EventHandler(this.returnMovies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustList)).EndInit();
            this.panelReturnMovie.ResumeLayout(false);
            this.panelReturnMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCustExit;
        private System.Windows.Forms.Button btnCustRefresh;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.TextBox txtCustSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridCustList;
        private System.Windows.Forms.Panel panelReturnMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeiReturnDate;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.TextBox txtmName;
        private System.Windows.Forms.Button btnReturn;
    }
}