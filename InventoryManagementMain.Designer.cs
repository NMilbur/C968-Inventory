namespace NMilburn_InventoryApp
{
    partial class InventoryManagementMain
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
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.PartSearchBtn = new System.Windows.Forms.Button();
            this.partSearchInput = new System.Windows.Forms.TextBox();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.partModifyBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.productAddBtn = new System.Windows.Forms.Button();
            this.productModifyBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productSearchInput = new System.Windows.Forms.TextBox();
            this.productSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(12, 167);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 62;
            this.partsDataGridView.Size = new System.Drawing.Size(656, 317);
            this.partsDataGridView.TabIndex = 0;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(716, 167);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.Size = new System.Drawing.Size(655, 317);
            this.productDataGridView.TabIndex = 1;
            // 
            // PartSearchBtn
            // 
            this.PartSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchBtn.Location = new System.Drawing.Point(345, 119);
            this.PartSearchBtn.Name = "PartSearchBtn";
            this.PartSearchBtn.Size = new System.Drawing.Size(86, 32);
            this.PartSearchBtn.TabIndex = 2;
            this.PartSearchBtn.Text = "Search";
            this.PartSearchBtn.UseVisualStyleBackColor = true;
            this.PartSearchBtn.Click += new System.EventHandler(this.partSearchBtn_Click);
            // 
            // partSearchInput
            // 
            this.partSearchInput.Location = new System.Drawing.Point(443, 119);
            this.partSearchInput.MaximumSize = new System.Drawing.Size(225, 30);
            this.partSearchInput.MinimumSize = new System.Drawing.Size(225, 30);
            this.partSearchInput.Name = "partSearchInput";
            this.partSearchInput.Size = new System.Drawing.Size(225, 30);
            this.partSearchInput.TabIndex = 4;
            // 
            // partAddBtn
            // 
            this.partAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAddBtn.Location = new System.Drawing.Point(318, 526);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(103, 53);
            this.partAddBtn.TabIndex = 6;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = true;
            this.partAddBtn.Click += new System.EventHandler(this.partAddBtn_Click);
            // 
            // partModifyBtn
            // 
            this.partModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partModifyBtn.Location = new System.Drawing.Point(443, 526);
            this.partModifyBtn.Name = "partModifyBtn";
            this.partModifyBtn.Size = new System.Drawing.Size(103, 53);
            this.partModifyBtn.TabIndex = 7;
            this.partModifyBtn.Text = "Modify";
            this.partModifyBtn.UseVisualStyleBackColor = true;
            this.partModifyBtn.Click += new System.EventHandler(this.partModifyBtn_Click);
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDeleteBtn.Location = new System.Drawing.Point(565, 526);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(103, 53);
            this.partDeleteBtn.TabIndex = 8;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            this.partDeleteBtn.Click += new System.EventHandler(this.partDeleteBtn_Click);
            // 
            // productAddBtn
            // 
            this.productAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAddBtn.Location = new System.Drawing.Point(1024, 526);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(103, 53);
            this.productAddBtn.TabIndex = 9;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = true;
            this.productAddBtn.Click += new System.EventHandler(this.productAddBtn_Click);
            // 
            // productModifyBtn
            // 
            this.productModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModifyBtn.Location = new System.Drawing.Point(1146, 526);
            this.productModifyBtn.Name = "productModifyBtn";
            this.productModifyBtn.Size = new System.Drawing.Size(103, 53);
            this.productModifyBtn.TabIndex = 10;
            this.productModifyBtn.Text = "Modify";
            this.productModifyBtn.UseVisualStyleBackColor = true;
            this.productModifyBtn.Click += new System.EventHandler(this.productModifyBtn_Click);
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteBtn.Location = new System.Drawing.Point(1268, 526);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(103, 53);
            this.productDeleteBtn.TabIndex = 11;
            this.productDeleteBtn.Text = "Delete";
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            this.productDeleteBtn.Click += new System.EventHandler(this.productDeleteBtn_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(1268, 639);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 53);
            this.button9.TabIndex = 12;
            this.button9.Text = "Exit";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Products";
            // 
            // productSearchInput
            // 
            this.productSearchInput.Location = new System.Drawing.Point(1146, 119);
            this.productSearchInput.MaximumSize = new System.Drawing.Size(225, 30);
            this.productSearchInput.MinimumSize = new System.Drawing.Size(225, 30);
            this.productSearchInput.Name = "productSearchInput";
            this.productSearchInput.Size = new System.Drawing.Size(225, 30);
            this.productSearchInput.TabIndex = 15;
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBtn.Location = new System.Drawing.Point(1041, 119);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(86, 32);
            this.productSearchBtn.TabIndex = 16;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // InventoryManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 747);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.productSearchInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.productDeleteBtn);
            this.Controls.Add(this.productModifyBtn);
            this.Controls.Add(this.productAddBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.partModifyBtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.partSearchInput);
            this.Controls.Add(this.PartSearchBtn);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Name = "InventoryManagementMain";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button PartSearchBtn;
        private System.Windows.Forms.TextBox partSearchInput;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button partModifyBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button productAddBtn;
        private System.Windows.Forms.Button productModifyBtn;
        private System.Windows.Forms.Button productDeleteBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productSearchInput;
        private System.Windows.Forms.Button productSearchBtn;
    }
}

