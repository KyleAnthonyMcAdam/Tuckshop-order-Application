namespace Tuckshop_forms
{
    partial class DeleteIForms
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
            this.lblItemtoDelete = new System.Windows.Forms.Label();
            this.txtboxItemDelete = new System.Windows.Forms.TextBox();
            this.dataGridItemsDelete = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBackUpdate = new System.Windows.Forms.Button();
            this.lblDeleteItems = new System.Windows.Forms.Label();
            this.lblTuckshopDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemtoDelete
            // 
            this.lblItemtoDelete.AutoSize = true;
            this.lblItemtoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemtoDelete.Location = new System.Drawing.Point(30, 224);
            this.lblItemtoDelete.Name = "lblItemtoDelete";
            this.lblItemtoDelete.Size = new System.Drawing.Size(176, 25);
            this.lblItemtoDelete.TabIndex = 37;
            this.lblItemtoDelete.Text = "Item ID to Delete:";
            // 
            // txtboxItemDelete
            // 
            this.txtboxItemDelete.Location = new System.Drawing.Point(229, 229);
            this.txtboxItemDelete.Name = "txtboxItemDelete";
            this.txtboxItemDelete.Size = new System.Drawing.Size(152, 20);
            this.txtboxItemDelete.TabIndex = 36;
            // 
            // dataGridItemsDelete
            // 
            this.dataGridItemsDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsDelete.Location = new System.Drawing.Point(403, 168);
            this.dataGridItemsDelete.Name = "dataGridItemsDelete";
            this.dataGridItemsDelete.Size = new System.Drawing.Size(500, 269);
            this.dataGridItemsDelete.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(229, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 48);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBackUpdate
            // 
            this.btnBackUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUpdate.Location = new System.Drawing.Point(42, 389);
            this.btnBackUpdate.Name = "btnBackUpdate";
            this.btnBackUpdate.Size = new System.Drawing.Size(152, 48);
            this.btnBackUpdate.TabIndex = 31;
            this.btnBackUpdate.Text = "Back";
            this.btnBackUpdate.UseVisualStyleBackColor = true;
            this.btnBackUpdate.Click += new System.EventHandler(this.btnBackUpdate_Click);
            // 
            // lblDeleteItems
            // 
            this.lblDeleteItems.AutoSize = true;
            this.lblDeleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteItems.Location = new System.Drawing.Point(304, 86);
            this.lblDeleteItems.Name = "lblDeleteItems";
            this.lblDeleteItems.Size = new System.Drawing.Size(193, 37);
            this.lblDeleteItems.TabIndex = 26;
            this.lblDeleteItems.Text = "Delete Items";
            // 
            // lblTuckshopDelete
            // 
            this.lblTuckshopDelete.AutoSize = true;
            this.lblTuckshopDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopDelete.Location = new System.Drawing.Point(245, 13);
            this.lblTuckshopDelete.Name = "lblTuckshopDelete";
            this.lblTuckshopDelete.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopDelete.TabIndex = 25;
            this.lblTuckshopDelete.Text = "Tuckshop";
            // 
            // DeleteIForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.lblItemtoDelete);
            this.Controls.Add(this.txtboxItemDelete);
            this.Controls.Add(this.dataGridItemsDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBackUpdate);
            this.Controls.Add(this.lblDeleteItems);
            this.Controls.Add(this.lblTuckshopDelete);
            this.Name = "DeleteIForms";
            this.Text = "DeleteIForms";
            this.Load += new System.EventHandler(this.DeleteIForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemtoDelete;
        private System.Windows.Forms.TextBox txtboxItemDelete;
        private System.Windows.Forms.DataGridView dataGridItemsDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBackUpdate;
        private System.Windows.Forms.Label lblDeleteItems;
        private System.Windows.Forms.Label lblTuckshopDelete;
    }
}