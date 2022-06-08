
namespace loginForm
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssuedReturnedDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.issueMovieToolStripMenuItem,
            this.returnMoviesToolStripMenuItem,
            this.IssuedReturnedDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1450, 101);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMovieToolStripMenuItem,
            this.viewMoviesToolStripMenuItem});
            this.moviesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesToolStripMenuItem.Image")));
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(104, 97);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // addNewMovieToolStripMenuItem
            // 
            this.addNewMovieToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewMovieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewMovieToolStripMenuItem.Image")));
            this.addNewMovieToolStripMenuItem.Name = "addNewMovieToolStripMenuItem";
            this.addNewMovieToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.addNewMovieToolStripMenuItem.Text = "Add New Movie";
            this.addNewMovieToolStripMenuItem.Click += new System.EventHandler(this.addNewMovieToolStripMenuItem_Click);
            // 
            // viewMoviesToolStripMenuItem
            // 
            this.viewMoviesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewMoviesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewMoviesToolStripMenuItem.Image")));
            this.viewMoviesToolStripMenuItem.Name = "viewMoviesToolStripMenuItem";
            this.viewMoviesToolStripMenuItem.Size = new System.Drawing.Size(228, 28);
            this.viewMoviesToolStripMenuItem.Text = "View Movies";
            this.viewMoviesToolStripMenuItem.Click += new System.EventHandler(this.viewMoviesToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomerInfoToolStripMenuItem});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(125, 97);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerToolStripMenuItem.Image")));
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomerInfoToolStripMenuItem
            // 
            this.viewCustomerInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCustomerInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewCustomerInfoToolStripMenuItem.Image")));
            this.viewCustomerInfoToolStripMenuItem.Name = "viewCustomerInfoToolStripMenuItem";
            this.viewCustomerInfoToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.viewCustomerInfoToolStripMenuItem.Text = "View Customer Info";
            this.viewCustomerInfoToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerInfoToolStripMenuItem_Click);
            // 
            // issueMovieToolStripMenuItem
            // 
            this.issueMovieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueMovieToolStripMenuItem.Image")));
            this.issueMovieToolStripMenuItem.Name = "issueMovieToolStripMenuItem";
            this.issueMovieToolStripMenuItem.Size = new System.Drawing.Size(151, 97);
            this.issueMovieToolStripMenuItem.Text = "Issue Movies";
            this.issueMovieToolStripMenuItem.Click += new System.EventHandler(this.issueMovieToolStripMenuItem_Click);
            // 
            // returnMoviesToolStripMenuItem
            // 
            this.returnMoviesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnMoviesToolStripMenuItem.Image")));
            this.returnMoviesToolStripMenuItem.Name = "returnMoviesToolStripMenuItem";
            this.returnMoviesToolStripMenuItem.Size = new System.Drawing.Size(166, 97);
            this.returnMoviesToolStripMenuItem.Text = "Return Movies";
            this.returnMoviesToolStripMenuItem.Click += new System.EventHandler(this.returnMoviesToolStripMenuItem_Click);
            // 
            // IssuedReturnedDetailsToolStripMenuItem
            // 
            this.IssuedReturnedDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IssuedReturnedDetailsToolStripMenuItem.Image")));
            this.IssuedReturnedDetailsToolStripMenuItem.Name = "IssuedReturnedDetailsToolStripMenuItem";
            this.IssuedReturnedDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 97);
            this.IssuedReturnedDetailsToolStripMenuItem.Text = "Issued and Returned Movies";
            this.IssuedReturnedDetailsToolStripMenuItem.Click += new System.EventHandler(this.IssuedReturnedDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemLogout,
            this.menuitemClose});
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(75, 97);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuitemLogout
            // 
            this.menuitemLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemLogout.Image = ((System.Drawing.Image)(resources.GetObject("menuitemLogout.Image")));
            this.menuitemLogout.Name = "menuitemLogout";
            this.menuitemLogout.Size = new System.Drawing.Size(151, 28);
            this.menuitemLogout.Text = "Logout";
            this.menuitemLogout.Click += new System.EventHandler(this.menuitemLogout_Click);
            // 
            // menuitemClose
            // 
            this.menuitemClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemClose.Image = ((System.Drawing.Image)(resources.GetObject("menuitemClose.Image")));
            this.menuitemClose.Name = "menuitemClose";
            this.menuitemClose.Size = new System.Drawing.Size(151, 28);
            this.menuitemClose.Text = "Close ";
            this.menuitemClose.Click += new System.EventHandler(this.menuitemClose_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 804);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssuedReturnedDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemLogout;
        private System.Windows.Forms.ToolStripMenuItem menuitemClose;
    }
}