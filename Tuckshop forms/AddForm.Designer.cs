namespace Tuckshop_forms
{
    partial class AddForm
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
            this.lblTuckshopAdd = new System.Windows.Forms.Label();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.btnBackAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textAddQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuckshopAdd
            // 
            this.lblTuckshopAdd.AutoSize = true;
            this.lblTuckshopAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopAdd.Location = new System.Drawing.Point(245, 9);
            this.lblTuckshopAdd.Name = "lblTuckshopAdd";
            this.lblTuckshopAdd.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopAdd.TabIndex = 2;
            this.lblTuckshopAdd.Text = "Tuckshop";
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItems.Location = new System.Drawing.Point(320, 82);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(161, 37);
            this.lblAddItems.TabIndex = 5;
            this.lblAddItems.Text = "Add Items";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(251, 243);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 25);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Item Price:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(251, 183);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(120, 25);
            this.lblItemName.TabIndex = 8;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(398, 243);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(152, 20);
            this.txtAddPrice.TabIndex = 7;
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(398, 183);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(152, 20);
            this.txtAddItem.TabIndex = 6;
            // 
            // btnBackAdd
            // 
            this.btnBackAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAdd.Location = new System.Drawing.Point(258, 370);
            this.btnBackAdd.Name = "btnBackAdd";
            this.btnBackAdd.Size = new System.Drawing.Size(152, 48);
            this.btnBackAdd.TabIndex = 10;
            this.btnBackAdd.Text = "Back";
            this.btnBackAdd.UseVisualStyleBackColor = true;
            this.btnBackAdd.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(443, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(251, 301);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(144, 25);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Item Quantity:";
            // 
            // textAddQuantity
            // 
            this.textAddQuantity.Location = new System.Drawing.Point(398, 301);
            this.textAddQuantity.Name = "textAddQuantity";
            this.textAddQuantity.Size = new System.Drawing.Size(152, 20);
            this.textAddQuantity.TabIndex = 12;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.textAddQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBackAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.lblAddItems);
            this.Controls.Add(this.lblTuckshopAdd);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuckshopAdd;
        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Button btnBackAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textAddQuantity;
    }
}