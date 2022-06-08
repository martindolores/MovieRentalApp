
namespace loginForm
{
    partial class viewCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewCustomers));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmSearch = new System.Windows.Forms.TextBox();
            this.dataGridMovieList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCustDetails = new System.Windows.Forms.Panel();
            this.txtcMemberNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtcPost = new System.Windows.Forms.TextBox();
            this.txtcState = new System.Windows.Forms.TextBox();
            this.txtcSub = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimecSubDate = new System.Windows.Forms.DateTimePicker();
            this.txtcEmail = new System.Windows.Forms.TextBox();
            this.txtcAddr = new System.Windows.Forms.TextBox();
            this.txtcLastName = new System.Windows.Forms.TextBox();
            this.txtcFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtmSearch);
            this.panel3.Location = new System.Drawing.Point(21, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 79);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(694, 26);
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
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Last Name:";

            // 
            // txtmSearch
            // 
            this.txtmSearch.Location = new System.Drawing.Point(486, 27);
            this.txtmSearch.Name = "txtmSearch";
            this.txtmSearch.Size = new System.Drawing.Size(189, 22);
            this.txtmSearch.TabIndex = 0;
            this.txtmSearch.TextChanged += new System.EventHandler(this.txtmSearch_TextChanged);
            // 
            // dataGridMovieList
            // 
            this.dataGridMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovieList.Location = new System.Drawing.Point(21, 194);
            this.dataGridMovieList.Name = "dataGridMovieList";
            this.dataGridMovieList.RowHeadersWidth = 51;
            this.dataGridMovieList.RowTemplate.Height = 24;
            this.dataGridMovieList.Size = new System.Drawing.Size(1177, 341);
            this.dataGridMovieList.TabIndex = 7;
            this.dataGridMovieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMovieList_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(592, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 33);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "View Customers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelCustDetails
            // 
            this.panelCustDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCustDetails.Controls.Add(this.txtcMemberNo);
            this.panelCustDetails.Controls.Add(this.label7);
            this.panelCustDetails.Controls.Add(this.btnDelete);
            this.panelCustDetails.Controls.Add(this.btnClear);
            this.panelCustDetails.Controls.Add(this.btnUpdate);
            this.panelCustDetails.Controls.Add(this.txtcPost);
            this.panelCustDetails.Controls.Add(this.txtcState);
            this.panelCustDetails.Controls.Add(this.txtcSub);
            this.panelCustDetails.Controls.Add(this.panel5);
            this.panelCustDetails.Controls.Add(this.panel4);
            this.panelCustDetails.Controls.Add(this.label8);
            this.panelCustDetails.Controls.Add(this.panel1);
            this.panelCustDetails.Controls.Add(this.label5);
            this.panelCustDetails.Controls.Add(this.datetimecSubDate);
            this.panelCustDetails.Controls.Add(this.txtcEmail);
            this.panelCustDetails.Controls.Add(this.txtcAddr);
            this.panelCustDetails.Controls.Add(this.txtcLastName);
            this.panelCustDetails.Controls.Add(this.txtcFirstName);
            this.panelCustDetails.Controls.Add(this.label6);
            this.panelCustDetails.Controls.Add(this.label4);
            this.panelCustDetails.Controls.Add(this.label3);
            this.panelCustDetails.Controls.Add(this.label2);
            this.panelCustDetails.Location = new System.Drawing.Point(21, 541);
            this.panelCustDetails.Name = "panelCustDetails";
            this.panelCustDetails.Size = new System.Drawing.Size(1177, 439);
            this.panelCustDetails.TabIndex = 10;
            // 
            // txtcMemberNo
            // 
            this.txtcMemberNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcMemberNo.Location = new System.Drawing.Point(7, 83);
            this.txtcMemberNo.Name = "txtcMemberNo";
            this.txtcMemberNo.Size = new System.Drawing.Size(104, 28);
            this.txtcMemberNo.TabIndex = 28;

            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Member No. ";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1050, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(531, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 28);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(7, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtcPost
            // 
            this.txtcPost.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcPost.Location = new System.Drawing.Point(581, 300);
            this.txtcPost.Name = "txtcPost";
            this.txtcPost.Size = new System.Drawing.Size(107, 28);
            this.txtcPost.TabIndex = 23;
            this.txtcPost.Text = "Post Code";
            // 
            // txtcState
            // 
            this.txtcState.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcState.Location = new System.Drawing.Point(448, 300);
            this.txtcState.Name = "txtcState";
            this.txtcState.Size = new System.Drawing.Size(112, 28);
            this.txtcState.TabIndex = 22;
            this.txtcState.Text = "State";
            // 
            // txtcSub
            // 
            this.txtcSub.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcSub.Location = new System.Drawing.Point(310, 300);
            this.txtcSub.Name = "txtcSub";
            this.txtcSub.Size = new System.Drawing.Size(128, 28);
            this.txtcSub.TabIndex = 21;
            this.txtcSub.Text = "Subarb / City";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1176, 10);
            this.panel5.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 10);
            this.panel4.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Customer Address";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 10);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Customer Details";
            // 
            // datetimecSubDate
            // 
            this.datetimecSubDate.Location = new System.Drawing.Point(492, 169);
            this.datetimecSubDate.Name = "datetimecSubDate";
            this.datetimecSubDate.Size = new System.Drawing.Size(240, 22);
            this.datetimecSubDate.TabIndex = 14;
            // 
            // txtcEmail
            // 
            this.txtcEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcEmail.Location = new System.Drawing.Point(492, 130);
            this.txtcEmail.Name = "txtcEmail";
            this.txtcEmail.Size = new System.Drawing.Size(240, 28);
            this.txtcEmail.TabIndex = 10;
            // 
            // txtcAddr
            // 
            this.txtcAddr.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcAddr.Location = new System.Drawing.Point(310, 266);
            this.txtcAddr.Name = "txtcAddr";
            this.txtcAddr.Size = new System.Drawing.Size(564, 28);
            this.txtcAddr.TabIndex = 9;
            this.txtcAddr.Text = "Street Address";
            // 
            // txtcLastName
            // 
            this.txtcLastName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcLastName.Location = new System.Drawing.Point(492, 93);
            this.txtcLastName.Name = "txtcLastName";
            this.txtcLastName.Size = new System.Drawing.Size(240, 28);
            this.txtcLastName.TabIndex = 8;
            // 
            // txtcFirstName
            // 
            this.txtcFirstName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcFirstName.Location = new System.Drawing.Point(492, 50);
            this.txtcFirstName.Name = "txtcFirstName";
            this.txtcFirstName.Size = new System.Drawing.Size(240, 28);
            this.txtcFirstName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Subsciption Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1167, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // viewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 541);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCustDetails);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridMovieList);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCustomers";
            this.Load += new System.EventHandler(this.viewCustomers_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustDetails.ResumeLayout(false);
            this.panelCustDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmSearch;
        private System.Windows.Forms.DataGridView dataGridMovieList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCustDetails;
        private System.Windows.Forms.TextBox txtcPost;
        private System.Windows.Forms.TextBox txtcState;
        private System.Windows.Forms.TextBox txtcSub;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimecSubDate;
        private System.Windows.Forms.TextBox txtcEmail;
        private System.Windows.Forms.TextBox txtcAddr;
        private System.Windows.Forms.TextBox txtcLastName;
        private System.Windows.Forms.TextBox txtcFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtcMemberNo;
        private System.Windows.Forms.Label label7;
    }
}