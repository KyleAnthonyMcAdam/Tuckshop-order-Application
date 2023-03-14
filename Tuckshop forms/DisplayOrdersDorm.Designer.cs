namespace Tuckshop_forms
{
    partial class DisplayOrdersDorm
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
            this.gridviewPastOrders = new System.Windows.Forms.DataGridView();
            this.lblPreviousOrders = new System.Windows.Forms.Label();
            this.btnBackIPastOrders = new System.Windows.Forms.Button();
            this.lblTuckshopDisplayOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPastOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewPastOrders
            // 
            this.gridviewPastOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewPastOrders.Location = new System.Drawing.Point(154, 145);
            this.gridviewPastOrders.Name = "gridviewPastOrders";
            this.gridviewPastOrders.Size = new System.Drawing.Size(492, 224);
            this.gridviewPastOrders.TabIndex = 9;
            // 
            // lblPreviousOrders
            // 
            this.lblPreviousOrders.AutoSize = true;
            this.lblPreviousOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousOrders.Location = new System.Drawing.Point(285, 84);
            this.lblPreviousOrders.Name = "lblPreviousOrders";
            this.lblPreviousOrders.Size = new System.Drawing.Size(209, 37);
            this.lblPreviousOrders.TabIndex = 8;
            this.lblPreviousOrders.Text = "Display Sales";
            // 
            // btnBackIPastOrders
            // 
            this.btnBackIPastOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackIPastOrders.Location = new System.Drawing.Point(325, 392);
            this.btnBackIPastOrders.Name = "btnBackIPastOrders";
            this.btnBackIPastOrders.Size = new System.Drawing.Size(152, 48);
            this.btnBackIPastOrders.TabIndex = 7;
            this.btnBackIPastOrders.Text = "Back";
            this.btnBackIPastOrders.UseVisualStyleBackColor = true;
            this.btnBackIPastOrders.Click += new System.EventHandler(this.btnBackIPastOrders_Click);
            // 
            // lblTuckshopDisplayOrders
            // 
            this.lblTuckshopDisplayOrders.AutoSize = true;
            this.lblTuckshopDisplayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuckshopDisplayOrders.Location = new System.Drawing.Point(246, 11);
            this.lblTuckshopDisplayOrders.Name = "lblTuckshopDisplayOrders";
            this.lblTuckshopDisplayOrders.Size = new System.Drawing.Size(311, 73);
            this.lblTuckshopDisplayOrders.TabIndex = 6;
            this.lblTuckshopDisplayOrders.Text = "Tuckshop";
            // 
            // DisplayOrdersDorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridviewPastOrders);
            this.Controls.Add(this.lblPreviousOrders);
            this.Controls.Add(this.btnBackIPastOrders);
            this.Controls.Add(this.lblTuckshopDisplayOrders);
            this.Name = "DisplayOrdersDorm";
            this.Text = "DisplayOrdersFDorm";
            this.Load += new System.EventHandler(this.DisplayOrdersDorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPastOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewPastOrders;
        private System.Windows.Forms.Label lblPreviousOrders;
        private System.Windows.Forms.Button btnBackIPastOrders;
        private System.Windows.Forms.Label lblTuckshopDisplayOrders;
    }
}