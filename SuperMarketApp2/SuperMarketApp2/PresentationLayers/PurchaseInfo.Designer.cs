
namespace SuperMarketApp2.PresentationLayers
{
    partial class PurchaseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInfo));
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.btnPrintPurchase = new System.Windows.Forms.Button();
            this.ppdPurchase = new System.Windows.Forms.PrintPreviewDialog();
            this.pdPurchase = new System.Drawing.Printing.PrintDocument();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToDeleteRows = false;
            this.dgvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchase.EnableHeadersVisualStyles = false;
            this.dgvPurchase.Location = new System.Drawing.Point(23, 128);
            this.dgvPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchase.RowHeadersVisible = false;
            this.dgvPurchase.RowHeadersWidth = 51;
            this.dgvPurchase.RowTemplate.Height = 24;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(671, 270);
            this.dgvPurchase.TabIndex = 7;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(19, 37);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(217, 25);
            this.lblPurchase.TabIndex = 8;
            this.lblPurchase.Text = "PURCHASE REPORT";
            // 
            // btnPrintPurchase
            // 
            this.btnPrintPurchase.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPrintPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintPurchase.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPurchase.Location = new System.Drawing.Point(588, 433);
            this.btnPrintPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintPurchase.Name = "btnPrintPurchase";
            this.btnPrintPurchase.Size = new System.Drawing.Size(91, 29);
            this.btnPrintPurchase.TabIndex = 21;
            this.btnPrintPurchase.Text = "Print";
            this.btnPrintPurchase.UseVisualStyleBackColor = false;
            this.btnPrintPurchase.Click += new System.EventHandler(this.btnPrintPurchase_Click);
            // 
            // ppdPurchase
            // 
            this.ppdPurchase.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdPurchase.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdPurchase.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdPurchase.Document = this.pdPurchase;
            this.ppdPurchase.Enabled = true;
            this.ppdPurchase.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdPurchase.Icon")));
            this.ppdPurchase.Name = "ppdPurchase";
            this.ppdPurchase.Visible = false;
            // 
            // pdPurchase
            // 
            this.pdPurchase.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPurchase_PrintPage);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.dtpTo.Location = new System.Drawing.Point(513, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 22;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(267, 90);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 23;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "From";
            // 
            // PurchaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnPrintPurchase);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.dgvPurchase);
            this.Name = "PurchaseInfo";
            this.Size = new System.Drawing.Size(731, 477);
            this.Load += new System.EventHandler(this.PurchaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Button btnPrintPurchase;
        private System.Windows.Forms.PrintPreviewDialog ppdPurchase;
        private System.Drawing.Printing.PrintDocument pdPurchase;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
