
namespace SuperMarketApp2.PresentationLayers
{
    partial class SalesInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInfo));
            this.lblPurchase = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnPrintSales = new System.Windows.Forms.Button();
            this.ppdSales = new System.Windows.Forms.PrintPreviewDialog();
            this.pdSales = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(23, 41);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(168, 25);
            this.lblPurchase.TabIndex = 10;
            this.lblPurchase.Text = "SALES REPORT";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(28, 143);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(671, 270);
            this.dgvSales.TabIndex = 9;
            // 
            // btnPrintSales
            // 
            this.btnPrintSales.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPrintSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintSales.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSales.Location = new System.Drawing.Point(562, 427);
            this.btnPrintSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintSales.Name = "btnPrintSales";
            this.btnPrintSales.Size = new System.Drawing.Size(91, 29);
            this.btnPrintSales.TabIndex = 22;
            this.btnPrintSales.Text = "Print";
            this.btnPrintSales.UseVisualStyleBackColor = false;
            this.btnPrintSales.Click += new System.EventHandler(this.btnPrintSales_Click);
            // 
            // ppdSales
            // 
            this.ppdSales.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdSales.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdSales.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdSales.Document = this.pdSales;
            this.ppdSales.Enabled = true;
            this.ppdSales.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdSales.Icon")));
            this.ppdSales.Name = "ppdSales";
            this.ppdSales.Visible = false;
            // 
            // pdSales
            // 
            this.pdSales.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdSales_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(253, 99);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 27;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.dtpTo.Location = new System.Drawing.Point(499, 95);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 26;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // SalesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnPrintSales);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.dgvSales);
            this.Name = "SalesInfo";
            this.Size = new System.Drawing.Size(731, 477);
            this.Load += new System.EventHandler(this.SalesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnPrintSales;
        private System.Windows.Forms.PrintPreviewDialog ppdSales;
        private System.Drawing.Printing.PrintDocument pdSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}
