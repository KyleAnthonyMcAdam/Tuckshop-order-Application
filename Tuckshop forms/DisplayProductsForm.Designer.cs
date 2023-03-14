namespace Tuckshop_forms
{
    partial class DisplayProductsForm
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
            this.lblTuckshopDisplay = new System.Windows.Forms.Label();
            this.btnBackItemsAvailable = new System.Windows.Forms.Button();
            this.lblItemsAvailable = new System.Windows.Forms.Label();
            this.gridviewProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuckshopDisplay
            // 
            this.lblTuckshopDisplay.AutoSize = true;
            this.lblTuckshopDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopDisplay.Location = new System.Drawing.Point(245, 9);
            this.lblTuckshopDisplay.Name = "lblTuckshopDisplay";
            this.lblTuckshopDisplay.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopDisplay.TabIndex = 1;
            this.lblTuckshopDisplay.Text = "Tuckshop";
            // 
            // btnBackItemsAvailable
            // 
            this.btnBackItemsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackItemsAvailable.Location = new System.Drawing.Point(324, 390);
            this.btnBackItemsAvailable.Name = "btnBackItemsAvailable";
            this.btnBackItemsAvailable.Size = new System.Drawing.Size(152, 48);
            this.btnBackItemsAvailable.TabIndex = 3;
            this.btnBackItemsAvailable.Text = "Back";
            this.btnBackItemsAvailable.UseVisualStyleBackColor = true;
            this.btnBackItemsAvailable.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblItemsAvailable
            // 
            this.lblItemsAvailable.AutoSize = true;
            this.lblItemsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsAvailable.Location = new System.Drawing.Point(284, 82);
            this.lblItemsAvailable.Name = "lblItemsAvailable";
            this.lblItemsAvailable.Size = new System.Drawing.Size(232, 37);
            this.lblItemsAvailable.TabIndex = 4;
            this.lblItemsAvailable.Text = "Items Available";
            // 
            // gridviewProducts
            // 
            this.gridviewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewProducts.Location = new System.Drawing.Point(153, 143);
            this.gridviewProducts.Name = "gridviewProducts";
            this.gridviewProducts.Size = new System.Drawing.Size(492, 224);
            this.gridviewProducts.TabIndex = 5;
            // 
            // DisplayProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewProducts);
            this.Controls.Add(this.lblItemsAvailable);
            this.Controls.Add(this.btnBackItemsAvailable);
            this.Controls.Add(this.lblTuckshopDisplay);
            this.Name = "DisplayProductsForm";
            this.Text = "DisplayProductsForm";
            this.Load += new System.EventHandler(this.DisplayProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTuckshopDisplay;
        private System.Windows.Forms.Button btnBackItemsAvailable;
        private System.Windows.Forms.Label lblItemsAvailable;
        private System.Windows.Forms.DataGridView gridviewProducts;
    }
}