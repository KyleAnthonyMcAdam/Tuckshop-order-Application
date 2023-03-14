namespace Tuckshop_forms
{
    partial class UpdateForm
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
            this.lblUpdateItems = new System.Windows.Forms.Label();
            this.lblTuckshopUpdate = new System.Windows.Forms.Label();
            this.lblQuantityUpdate = new System.Windows.Forms.Label();
            this.textUpdateQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackUpdate = new System.Windows.Forms.Button();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblItemNameUpdate = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateItem = new System.Windows.Forms.TextBox();
            this.dataGridItemsUpdate = new System.Windows.Forms.DataGridView();
            this.lblItemtoUpdate = new System.Windows.Forms.Label();
            this.txtboxItemUpdating = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateItems
            // 
            this.lblUpdateItems.AutoSize = true;
            this.lblUpdateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItems.Location = new System.Drawing.Point(297, 82);
            this.lblUpdateItems.Name = "lblUpdateItems";
            this.lblUpdateItems.Size = new System.Drawing.Size(206, 37);
            this.lblUpdateItems.TabIndex = 6;
            this.lblUpdateItems.Text = "Update Items";
            // 
            // lblTuckshopUpdate
            // 
            this.lblTuckshopUpdate.AutoSize = true;
            this.lblTuckshopUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopUpdate.Location = new System.Drawing.Point(245, 9);
            this.lblTuckshopUpdate.Name = "lblTuckshopUpdate";
            this.lblTuckshopUpdate.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopUpdate.TabIndex = 5;
            this.lblTuckshopUpdate.Text = "Tuckshop";
            // 
            // lblQuantityUpdate
            // 
            this.lblQuantityUpdate.AutoSize = true;
            this.lblQuantityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityUpdate.Location = new System.Drawing.Point(10, 333);
            this.lblQuantityUpdate.Name = "lblQuantityUpdate";
            this.lblQuantityUpdate.Size = new System.Drawing.Size(192, 25);
            this.lblQuantityUpdate.TabIndex = 21;
            this.lblQuantityUpdate.Text = "New Item Quantity:";
            // 
            // textUpdateQuantity
            // 
            this.textUpdateQuantity.Location = new System.Drawing.Point(209, 338);
            this.textUpdateQuantity.Name = "textUpdateQuantity";
            this.textUpdateQuantity.Size = new System.Drawing.Size(152, 20);
            this.textUpdateQuantity.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(254, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 48);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBackUpdate
            // 
            this.btnBackUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUpdate.Location = new System.Drawing.Point(67, 385);
            this.btnBackUpdate.Name = "btnBackUpdate";
            this.btnBackUpdate.Size = new System.Drawing.Size(152, 48);
            this.btnBackUpdate.TabIndex = 18;
            this.btnBackUpdate.Text = "Back";
            this.btnBackUpdate.UseVisualStyleBackColor = true;
            this.btnBackUpdate.Click += new System.EventHandler(this.btnBackUpdate_Click);
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceUpdate.Location = new System.Drawing.Point(30, 299);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(161, 25);
            this.lblPriceUpdate.TabIndex = 17;
            this.lblPriceUpdate.Text = "New Item Price:";
            // 
            // lblItemNameUpdate
            // 
            this.lblItemNameUpdate.AutoSize = true;
            this.lblItemNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNameUpdate.Location = new System.Drawing.Point(30, 264);
            this.lblItemNameUpdate.Name = "lblItemNameUpdate";
            this.lblItemNameUpdate.Size = new System.Drawing.Size(168, 25);
            this.lblItemNameUpdate.TabIndex = 16;
            this.lblItemNameUpdate.Text = "New Item Name:";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(209, 304);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(152, 20);
            this.txtUpdatePrice.TabIndex = 15;
            // 
            // txtUpdateItem
            // 
            this.txtUpdateItem.Location = new System.Drawing.Point(209, 269);
            this.txtUpdateItem.Name = "txtUpdateItem";
            this.txtUpdateItem.Size = new System.Drawing.Size(152, 20);
            this.txtUpdateItem.TabIndex = 14;
            // 
            // dataGridItemsUpdate
            // 
            this.dataGridItemsUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsUpdate.Location = new System.Drawing.Point(428, 164);
            this.dataGridItemsUpdate.Name = "dataGridItemsUpdate";
            this.dataGridItemsUpdate.Size = new System.Drawing.Size(500, 269);
            this.dataGridItemsUpdate.TabIndex = 22;
            // 
            // lblItemtoUpdate
            // 
            this.lblItemtoUpdate.AutoSize = true;
            this.lblItemtoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemtoUpdate.Location = new System.Drawing.Point(25, 184);
            this.lblItemtoUpdate.Name = "lblItemtoUpdate";
            this.lblItemtoUpdate.Size = new System.Drawing.Size(183, 25);
            this.lblItemtoUpdate.TabIndex = 24;
            this.lblItemtoUpdate.Text = "Item ID to Update:";
            // 
            // txtboxItemUpdating
            // 
            this.txtboxItemUpdating.Location = new System.Drawing.Point(209, 190);
            this.txtboxItemUpdating.Name = "txtboxItemUpdating";
            this.txtboxItemUpdating.Size = new System.Drawing.Size(152, 20);
            this.txtboxItemUpdating.TabIndex = 23;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.lblItemtoUpdate);
            this.Controls.Add(this.txtboxItemUpdating);
            this.Controls.Add(this.dataGridItemsUpdate);
            this.Controls.Add(this.lblQuantityUpdate);
            this.Controls.Add(this.textUpdateQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBackUpdate);
            this.Controls.Add(this.lblPriceUpdate);
            this.Controls.Add(this.lblItemNameUpdate);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.txtUpdateItem);
            this.Controls.Add(this.lblUpdateItems);
            this.Controls.Add(this.lblTuckshopUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateItems;
        private System.Windows.Forms.Label lblTuckshopUpdate;
        private System.Windows.Forms.Label lblQuantityUpdate;
        private System.Windows.Forms.TextBox textUpdateQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblItemNameUpdate;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateItem;
        private System.Windows.Forms.DataGridView dataGridItemsUpdate;
        private System.Windows.Forms.Label lblItemtoUpdate;
        private System.Windows.Forms.TextBox txtboxItemUpdating;
    }
}