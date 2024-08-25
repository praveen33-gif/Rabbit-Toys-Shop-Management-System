namespace RABBIT_TOYS
{
    partial class ProductDelete
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
            this.Deletebtn = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProdIDlbl = new System.Windows.Forms.Label();
            this.ProduCTName = new System.Windows.Forms.TextBox();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(381, 483);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(462, 45);
            this.Deletebtn.TabIndex = 62;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ProductID
            // 
            this.ProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(381, 306);
            this.ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(462, 30);
            this.ProductID.TabIndex = 61;
            // 
            // ProdIDlbl
            // 
            this.ProdIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProdIDlbl.AutoSize = true;
            this.ProdIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDlbl.Location = new System.Drawing.Point(376, 238);
            this.ProdIDlbl.Name = "ProdIDlbl";
            this.ProdIDlbl.Size = new System.Drawing.Size(103, 25);
            this.ProdIDlbl.TabIndex = 60;
            this.ProdIDlbl.Text = "Product ID";
            // 
            // ProduCTName
            // 
            this.ProduCTName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProduCTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduCTName.Location = new System.Drawing.Point(381, 183);
            this.ProduCTName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProduCTName.Name = "ProduCTName";
            this.ProduCTName.Size = new System.Drawing.Size(462, 30);
            this.ProduCTName.TabIndex = 58;
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(376, 144);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(136, 25);
            this.ProductNamelbl.TabIndex = 57;
            this.ProductNamelbl.Text = "Product Name";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(381, 404);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(462, 52);
            this.Searchbtn.TabIndex = 84;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 85;
            this.label1.Text = "../Product Delete";
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.ProdIDlbl);
            this.Controls.Add(this.ProduCTName);
            this.Controls.Add(this.ProductNamelbl);
            this.Name = "ProductDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.ProductDelete_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label ProdIDlbl;
        private System.Windows.Forms.TextBox ProduCTName;
        private System.Windows.Forms.Label ProductNamelbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label label1;
    }
}