namespace RABBIT_TOYS
{
    partial class VendorDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.VendorIDlbl = new System.Windows.Forms.Label();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.Vendornamelbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 78;
            this.label1.Text = "../Vendor Delete";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(340, 553);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(384, 48);
            this.Delete.TabIndex = 82;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // VendorID
            // 
            this.VendorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(340, 354);
            this.VendorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(384, 31);
            this.VendorID.TabIndex = 81;
            // 
            // VendorIDlbl
            // 
            this.VendorIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendorIDlbl.AutoSize = true;
            this.VendorIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDlbl.Location = new System.Drawing.Point(335, 313);
            this.VendorIDlbl.Name = "VendorIDlbl";
            this.VendorIDlbl.Size = new System.Drawing.Size(107, 25);
            this.VendorIDlbl.TabIndex = 80;
            this.VendorIDlbl.Text = "Vendor ID";
            // 
            // VendorName
            // 
            this.VendorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName.Location = new System.Drawing.Point(340, 256);
            this.VendorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(384, 30);
            this.VendorName.TabIndex = 79;
            // 
            // Vendornamelbl
            // 
            this.Vendornamelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vendornamelbl.AutoSize = true;
            this.Vendornamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendornamelbl.Location = new System.Drawing.Point(335, 218);
            this.Vendornamelbl.Name = "Vendornamelbl";
            this.Vendornamelbl.Size = new System.Drawing.Size(133, 25);
            this.Vendornamelbl.TabIndex = 83;
            this.Vendornamelbl.Text = "Vendor Name";
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(340, 465);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(384, 52);
            this.Search.TabIndex = 91;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // VendorDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.VendorIDlbl);
            this.Controls.Add(this.VendorName);
            this.Controls.Add(this.Vendornamelbl);
            this.Controls.Add(this.label1);
            this.Name = "VendorDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.VendorDelete_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label VendorIDlbl;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Label Vendornamelbl;
        private System.Windows.Forms.Button Search;
    }
}