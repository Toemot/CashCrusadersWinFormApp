namespace CashCrusaders.WFApp.PurchaseOrder
{
    partial class PurchaseOrderForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlPurchaseOrder = new System.Windows.Forms.Panel();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstPurchaseOrder = new System.Windows.Forms.ListBox();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.pnlSuppliers.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlPurchaseOrder.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1300, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.Controls.Add(this.lstSuppliers);
            this.pnlSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSuppliers.Location = new System.Drawing.Point(0, 100);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(199, 631);
            this.pnlSuppliers.TabIndex = 1;
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.lstProducts);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProducts.Location = new System.Drawing.Point(199, 100);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(189, 631);
            this.pnlProducts.TabIndex = 2;
            // 
            // pnlPurchaseOrder
            // 
            this.pnlPurchaseOrder.Controls.Add(this.lstPurchaseOrder);
            this.pnlPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPurchaseOrder.Location = new System.Drawing.Point(388, 100);
            this.pnlPurchaseOrder.Name = "pnlPurchaseOrder";
            this.pnlPurchaseOrder.Size = new System.Drawing.Size(170, 631);
            this.pnlPurchaseOrder.TabIndex = 3;
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.txtGrandTotal);
            this.pnlMainArea.Controls.Add(this.txtTax);
            this.pnlMainArea.Controls.Add(this.txtSubtotal);
            this.pnlMainArea.Controls.Add(this.txtProductCode);
            this.pnlMainArea.Controls.Add(this.txtSupplierCode);
            this.pnlMainArea.Controls.Add(this.txtQuantity);
            this.pnlMainArea.Controls.Add(this.textBox1);
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.btnCreate);
            this.pnlMainArea.Controls.Add(this.label9);
            this.pnlMainArea.Controls.Add(this.lblGrandTotal);
            this.pnlMainArea.Controls.Add(this.lblTax);
            this.pnlMainArea.Controls.Add(this.lblSubTotal);
            this.pnlMainArea.Controls.Add(this.lblQuantity);
            this.pnlMainArea.Controls.Add(this.lblProductCode);
            this.pnlMainArea.Controls.Add(this.lblCreatedDate);
            this.pnlMainArea.Controls.Add(this.lblSupplierCode);
            this.pnlMainArea.Controls.Add(this.lblPONumber);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(558, 100);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(742, 631);
            this.pnlMainArea.TabIndex = 4;
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 26;
            this.lstSuppliers.Location = new System.Drawing.Point(0, 0);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(199, 631);
            this.lstSuppliers.TabIndex = 0;
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 26;
            this.lstProducts.Location = new System.Drawing.Point(0, 0);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(189, 631);
            this.lstProducts.TabIndex = 0;
            // 
            // lstPurchaseOrder
            // 
            this.lstPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPurchaseOrder.FormattingEnabled = true;
            this.lstPurchaseOrder.ItemHeight = 26;
            this.lstPurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.lstPurchaseOrder.Name = "lstPurchaseOrder";
            this.lstPurchaseOrder.Size = new System.Drawing.Size(170, 631);
            this.lstPurchaseOrder.TabIndex = 0;
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Location = new System.Drawing.Point(56, 37);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(249, 26);
            this.lblPONumber.TabIndex = 0;
            this.lblPONumber.Text = "Purchase Order Number";
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Location = new System.Drawing.Point(355, 37);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(150, 26);
            this.lblSupplierCode.TabIndex = 1;
            this.lblSupplierCode.Text = "Supplier Code";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(70, 147);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(141, 26);
            this.lblCreatedDate.TabIndex = 2;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(360, 147);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(145, 26);
            this.lblProductCode.TabIndex = 3;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(70, 256);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(93, 26);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(360, 246);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(92, 26);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(56, 374);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(47, 26);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(369, 374);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(125, 26);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(90, 546);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 35);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(61, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 32);
            this.textBox1.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(61, 303);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(244, 32);
            this.txtQuantity.TabIndex = 12;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierCode.Location = new System.Drawing.Point(360, 78);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(249, 32);
            this.txtSupplierCode.TabIndex = 13;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(365, 187);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(244, 32);
            this.txtProductCode.TabIndex = 14;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(365, 303);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(244, 32);
            this.txtSubtotal.TabIndex = 15;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(61, 428);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(244, 32);
            this.txtTax.TabIndex = 16;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(365, 428);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(244, 32);
            this.txtGrandTotal.TabIndex = 17;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlPurchaseOrder);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlSuppliers);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PurchaseOrderForm";
            this.Text = "PurchaseOrderForm";
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlPurchaseOrder.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Panel pnlPurchaseOrder;
        private System.Windows.Forms.ListBox lstPurchaseOrder;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtSupplierCode;
    }
}