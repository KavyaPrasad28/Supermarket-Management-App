
namespace SuperMarketApp2.PresentationLayers
{
    partial class AdminHomePage
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
            this.panelAdminHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSalesInfo = new System.Windows.Forms.Button();
            this.btnViewPurchaseInfo = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminHome
            // 
            this.panelAdminHome.AutoSize = true;
            this.panelAdminHome.BackColor = System.Drawing.Color.Lavender;
            this.panelAdminHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminHome.Location = new System.Drawing.Point(202, 0);
            this.panelAdminHome.Name = "panelAdminHome";
            this.panelAdminHome.Size = new System.Drawing.Size(728, 487);
            this.panelAdminHome.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSalesInfo);
            this.panel1.Controls.Add(this.btnViewPurchaseInfo);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 487);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14F);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(181, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "I";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MistyRose;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(28, 153);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 37);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSalesInfo
            // 
            this.btnSalesInfo.BackColor = System.Drawing.Color.Thistle;
            this.btnSalesInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalesInfo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesInfo.Location = new System.Drawing.Point(28, 278);
            this.btnSalesInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesInfo.Name = "btnSalesInfo";
            this.btnSalesInfo.Size = new System.Drawing.Size(149, 37);
            this.btnSalesInfo.TabIndex = 19;
            this.btnSalesInfo.Text = "Sales Report";
            this.btnSalesInfo.UseVisualStyleBackColor = false;
            this.btnSalesInfo.Click += new System.EventHandler(this.btnSalesInfo_Click);
            // 
            // btnViewPurchaseInfo
            // 
            this.btnViewPurchaseInfo.BackColor = System.Drawing.Color.LightCyan;
            this.btnViewPurchaseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPurchaseInfo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPurchaseInfo.Location = new System.Drawing.Point(28, 216);
            this.btnViewPurchaseInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewPurchaseInfo.Name = "btnViewPurchaseInfo";
            this.btnViewPurchaseInfo.Size = new System.Drawing.Size(149, 40);
            this.btnViewPurchaseInfo.TabIndex = 18;
            this.btnViewPurchaseInfo.Text = "Purchase Report";
            this.btnViewPurchaseInfo.UseVisualStyleBackColor = false;
            this.btnViewPurchaseInfo.Click += new System.EventHandler(this.btnViewPurchaseInfo_Click_1);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Georgia", 14F);
            this.lblMenu.Location = new System.Drawing.Point(72, 92);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(69, 23);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "MENU";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 487);
            this.Controls.Add(this.panelAdminHome);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Activated += new System.EventHandler(this.AdminHomePage_Activated);
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnSalesInfo;
        private System.Windows.Forms.Button btnViewPurchaseInfo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
    }
}