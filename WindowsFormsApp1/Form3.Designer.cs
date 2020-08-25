namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fefewfefdafdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfijdafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fadffewrerffafereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdferqfwefcdadwqeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fefsferqeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(861, 55);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 50);
            this.toolStripStatusLabel1.Text = "Logged in as:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(199, 50);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to Stock Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.fefewfefdafdfToolStripMenuItem,
            this.addVendorToolStripMenuItem,
            this.dfijdafToolStripMenuItem,
            this.fadffewrerffafereToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.fdferqfwefcdadwqeeToolStripMenuItem,
            this.fefsferqeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 103);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.insertQuantityToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_plus_64;
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 99);
            this.fileToolStripMenuItem.Text = "Insert";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.newToolStripMenuItem.Text = "Insert New Product";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // insertQuantityToolStripMenuItem
            // 
            this.insertQuantityToolStripMenuItem.Name = "insertQuantityToolStripMenuItem";
            this.insertQuantityToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.insertQuantityToolStripMenuItem.Text = "Insert Quantity";
            this.insertQuantityToolStripMenuItem.Click += new System.EventHandler(this.insertQuantityToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.AutoSize = false;
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem,
            this.viewStocksToolStripMenuItem,
            this.viewVendorToolStripMenuItem,
            this.viewCustomerToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_view_50;
            this.viewToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(70, 77);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.viewProductsToolStripMenuItem.Text = "View Product List";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // viewStocksToolStripMenuItem
            // 
            this.viewStocksToolStripMenuItem.Name = "viewStocksToolStripMenuItem";
            this.viewStocksToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.viewStocksToolStripMenuItem.Text = "View sold items";
            this.viewStocksToolStripMenuItem.Click += new System.EventHandler(this.viewStocksToolStripMenuItem_Click);
            // 
            // viewVendorToolStripMenuItem
            // 
            this.viewVendorToolStripMenuItem.Name = "viewVendorToolStripMenuItem";
            this.viewVendorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.viewVendorToolStripMenuItem.Text = "View Vendor";
            this.viewVendorToolStripMenuItem.Click += new System.EventHandler(this.viewVendorToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // fefewfefdafdfToolStripMenuItem
            // 
            this.fefewfefdafdfToolStripMenuItem.AutoSize = false;
            this.fefewfefdafdfToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_48;
            this.fefewfefdafdfToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fefewfefdafdfToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fefewfefdafdfToolStripMenuItem.Name = "fefewfefdafdfToolStripMenuItem";
            this.fefewfefdafdfToolStripMenuItem.Size = new System.Drawing.Size(93, 79);
            this.fefewfefdafdfToolStripMenuItem.Text = "Search  Product";
            this.fefewfefdafdfToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.fefewfefdafdfToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fefewfefdafdfToolStripMenuItem.Click += new System.EventHandler(this.fefewfefdafdfToolStripMenuItem_Click);
            // 
            // addVendorToolStripMenuItem
            // 
            this.addVendorToolStripMenuItem.AutoSize = false;
            this.addVendorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addVendorToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_add_administrator_50;
            this.addVendorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addVendorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addVendorToolStripMenuItem.Name = "addVendorToolStripMenuItem";
            this.addVendorToolStripMenuItem.Size = new System.Drawing.Size(72, 80);
            this.addVendorToolStripMenuItem.Text = "Add Vendor";
            this.addVendorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addVendorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addVendorToolStripMenuItem.Click += new System.EventHandler(this.addVendorToolStripMenuItem_Click);
            // 
            // dfijdafToolStripMenuItem
            // 
            this.dfijdafToolStripMenuItem.Name = "dfijdafToolStripMenuItem";
            this.dfijdafToolStripMenuItem.Size = new System.Drawing.Size(12, 99);
            this.dfijdafToolStripMenuItem.Visible = false;
            // 
            // fadffewrerffafereToolStripMenuItem
            // 
            this.fadffewrerffafereToolStripMenuItem.Name = "fadffewrerffafereToolStripMenuItem";
            this.fadffewrerffafereToolStripMenuItem.Size = new System.Drawing.Size(293, 99);
            this.fadffewrerffafereToolStripMenuItem.Text = "                                                                    ";
            this.fadffewrerffafereToolStripMenuItem.Click += new System.EventHandler(this.fadffewrerffafereToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.AutoSize = false;
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.logOutToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_rounded_up_50;
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(70, 78);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // fdferqfwefcdadwqeeToolStripMenuItem
            // 
            this.fdferqfwefcdadwqeeToolStripMenuItem.Name = "fdferqfwefcdadwqeeToolStripMenuItem";
            this.fdferqfwefcdadwqeeToolStripMenuItem.Size = new System.Drawing.Size(145, 99);
            this.fdferqfwefcdadwqeeToolStripMenuItem.Text = "                               ";
            // 
            // fefsferqeToolStripMenuItem
            // 
            this.fefsferqeToolStripMenuItem.Name = "fefsferqeToolStripMenuItem";
            this.fefsferqeToolStripMenuItem.Size = new System.Drawing.Size(132, 99);
            this.fefsferqeToolStripMenuItem.Text = "fefsferqefefefefe";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._29967c0267d58120fbcb043020b09858;
            this.ClientSize = new System.Drawing.Size(861, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem dfijdafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fefewfefdafdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fadffewrerffafereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdferqfwefcdadwqeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fefsferqeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
    }
}