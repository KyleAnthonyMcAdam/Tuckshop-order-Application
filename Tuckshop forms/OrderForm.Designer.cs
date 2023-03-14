namespace Tuckshop_forms
{
    partial class OrderForm
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
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.lblTuckshopOrder = new System.Windows.Forms.Label();
            this.lblItemtoOrder = new System.Windows.Forms.Label();
            this.txtboxItemOrder = new System.Windows.Forms.TextBox();
            this.dataGridItemsOrder = new System.Windows.Forms.DataGridView();
            this.btnBackOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItems.Location = new System.Drawing.Point(308, 82);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(185, 37);
            this.lblOrderItems.TabIndex = 28;
            this.lblOrderItems.Text = "Order Items";
            // 
            // lblTuckshopOrder
            // 
            this.lblTuckshopOrder.AutoSize = true;
            this.lblTuckshopOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopOrder.Location = new System.Drawing.Point(245, 9);
            this.lblTuckshopOrder.Name = "lblTuckshopOrder";
            this.lblTuckshopOrder.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopOrder.TabIndex = 27;
            this.lblTuckshopOrder.Text = "Tuckshop";
            // 
            // lblItemtoOrder
            // 
            this.lblItemtoOrder.AutoSize = true;
            this.lblItemtoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemtoOrder.Location = new System.Drawing.Point(89, 225);
            this.lblItemtoOrder.Name = "lblItemtoOrder";
            this.lblItemtoOrder.Size = new System.Drawing.Size(90, 25);
            this.lblItemtoOrder.TabIndex = 43;
            this.lblItemtoOrder.Text = "Item ID :";
            // 
            // txtboxItemOrder
            // 
            this.txtboxItemOrder.Location = new System.Drawing.Point(244, 230);
            this.txtboxItemOrder.Name = "txtboxItemOrder";
            this.txtboxItemOrder.Size = new System.Drawing.Size(152, 20);
            this.txtboxItemOrder.TabIndex = 42;
            // 
            // dataGridItemsOrder
            // 
            this.dataGridItemsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsOrder.Location = new System.Drawing.Point(418, 300);
            this.dataGridItemsOrder.Name = "dataGridItemsOrder";
            this.dataGridItemsOrder.Size = new System.Drawing.Size(550, 138);
            this.dataGridItemsOrder.TabIndex = 41;
            // 
            // btnBackOrder
            // 
            this.btnBackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOrder.Location = new System.Drawing.Point(57, 390);
            this.btnBackOrder.Name = "btnBackOrder";
            this.btnBackOrder.Size = new System.Drawing.Size(152, 48);
            this.btnBackOrder.TabIndex = 39;
            this.btnBackOrder.Text = "Back";
            this.btnBackOrder.UseVisualStyleBackColor = true;
            this.btnBackOrder.Click += new System.EventHandler(this.btnBackOrder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 44;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(418, 139);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(550, 138);
            this.dataGridViewProducts.TabIndex = 45;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(244, 390);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(152, 48);
            this.btnOrder.TabIndex = 40;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 469);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblItemtoOrder);
            this.Controls.Add(this.txtboxItemOrder);
            this.Controls.Add(this.dataGridItemsOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnBackOrder);
            this.Controls.Add(this.lblOrderItems);
            this.Controls.Add(this.lblTuckshopOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.Label lblTuckshopOrder;
        private System.Windows.Forms.Label lblItemtoOrder;
        private System.Windows.Forms.TextBox txtboxItemOrder;
        private System.Windows.Forms.DataGridView dataGridItemsOrder;
        private System.Windows.Forms.Button btnBackOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnOrder;
    }
}