namespace NMilburn_InventoryApp
{
    partial class PartForm
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
            this.components = new System.ComponentModel.Container();
            this.partFormLabel = new System.Windows.Forms.Label();
            this.inHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.outsourceRadionBtn = new System.Windows.Forms.RadioButton();
            this.partIDInput = new System.Windows.Forms.TextBox();
            this.partNameInput = new System.Windows.Forms.TextBox();
            this.partInventoryInput = new System.Windows.Forms.TextBox();
            this.partCostInput = new System.Windows.Forms.TextBox();
            this.partOriginSpecificInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.partOriginSpecificLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // partFormLabel
            // 
            this.partFormLabel.AutoSize = true;
            this.partFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partFormLabel.Location = new System.Drawing.Point(12, 26);
            this.partFormLabel.Name = "partFormLabel";
            this.partFormLabel.Size = new System.Drawing.Size(88, 25);
            this.partFormLabel.TabIndex = 0;
            this.partFormLabel.Text = "Add Part";
            // 
            // inHouseRadioBtn
            // 
            this.inHouseRadioBtn.AutoSize = true;
            this.inHouseRadioBtn.Checked = true;
            this.inHouseRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseRadioBtn.Location = new System.Drawing.Point(133, 28);
            this.inHouseRadioBtn.Name = "inHouseRadioBtn";
            this.inHouseRadioBtn.Size = new System.Drawing.Size(100, 24);
            this.inHouseRadioBtn.TabIndex = 1;
            this.inHouseRadioBtn.TabStop = true;
            this.inHouseRadioBtn.Text = "In-House";
            this.inHouseRadioBtn.UseVisualStyleBackColor = true;
            this.inHouseRadioBtn.Click += new System.EventHandler(this.inHouseRadioBtn_Click);
            // 
            // outsourceRadionBtn
            // 
            this.outsourceRadionBtn.AutoSize = true;
            this.outsourceRadionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourceRadionBtn.Location = new System.Drawing.Point(276, 28);
            this.outsourceRadionBtn.Name = "outsourceRadionBtn";
            this.outsourceRadionBtn.Size = new System.Drawing.Size(117, 24);
            this.outsourceRadionBtn.TabIndex = 2;
            this.outsourceRadionBtn.Text = "Outsourced";
            this.outsourceRadionBtn.UseVisualStyleBackColor = true;
            this.outsourceRadionBtn.Click += new System.EventHandler(this.outsourceRadionBtn_Click);
            // 
            // partIDInput
            // 
            this.partIDInput.Enabled = false;
            this.partIDInput.Location = new System.Drawing.Point(170, 90);
            this.partIDInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.partIDInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.partIDInput.Name = "partIDInput";
            this.partIDInput.Size = new System.Drawing.Size(200, 20);
            this.partIDInput.TabIndex = 3;
            // 
            // partNameInput
            // 
            this.partNameInput.Location = new System.Drawing.Point(170, 131);
            this.partNameInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.partNameInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.partNameInput.Name = "partNameInput";
            this.partNameInput.Size = new System.Drawing.Size(200, 20);
            this.partNameInput.TabIndex = 4;
            // 
            // partInventoryInput
            // 
            this.partInventoryInput.Location = new System.Drawing.Point(170, 174);
            this.partInventoryInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.partInventoryInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.partInventoryInput.Name = "partInventoryInput";
            this.partInventoryInput.Size = new System.Drawing.Size(200, 20);
            this.partInventoryInput.TabIndex = 5;
            this.partInventoryInput.Validating += new System.ComponentModel.CancelEventHandler(this.partInventoryInput_Validating);
            // 
            // partCostInput
            // 
            this.partCostInput.Location = new System.Drawing.Point(170, 216);
            this.partCostInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.partCostInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.partCostInput.Name = "partCostInput";
            this.partCostInput.Size = new System.Drawing.Size(200, 20);
            this.partCostInput.TabIndex = 6;
            this.partCostInput.Validating += new System.ComponentModel.CancelEventHandler(this.partCostInput_Validating);
            // 
            // partOriginSpecificInput
            // 
            this.partOriginSpecificInput.Location = new System.Drawing.Point(170, 303);
            this.partOriginSpecificInput.MaximumSize = new System.Drawing.Size(200, 25);
            this.partOriginSpecificInput.MinimumSize = new System.Drawing.Size(200, 25);
            this.partOriginSpecificInput.Name = "partOriginSpecificInput";
            this.partOriginSpecificInput.Size = new System.Drawing.Size(200, 20);
            this.partOriginSpecificInput.TabIndex = 7;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(170, 259);
            this.maxInput.MaximumSize = new System.Drawing.Size(125, 25);
            this.maxInput.MinimumSize = new System.Drawing.Size(125, 25);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(125, 20);
            this.maxInput.TabIndex = 8;
            this.maxInput.Validating += new System.ComponentModel.CancelEventHandler(this.maxInput_Validating);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(394, 259);
            this.minInput.MaximumSize = new System.Drawing.Size(125, 25);
            this.minInput.MinimumSize = new System.Drawing.Size(125, 25);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(125, 20);
            this.minInput.TabIndex = 9;
            this.minInput.Validating += new System.ComponentModel.CancelEventHandler(this.minInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min";
            // 
            // partOriginSpecificLabel
            // 
            this.partOriginSpecificLabel.AutoSize = true;
            this.partOriginSpecificLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partOriginSpecificLabel.Location = new System.Drawing.Point(23, 308);
            this.partOriginSpecificLabel.Name = "partOriginSpecificLabel";
            this.partOriginSpecificLabel.Size = new System.Drawing.Size(90, 20);
            this.partOriginSpecificLabel.TabIndex = 16;
            this.partOriginSpecificLabel.Text = "Machine ID";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(305, 387);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(97, 40);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(422, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.partOriginSpecificLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.partOriginSpecificInput);
            this.Controls.Add(this.partCostInput);
            this.Controls.Add(this.partInventoryInput);
            this.Controls.Add(this.partNameInput);
            this.Controls.Add(this.partIDInput);
            this.Controls.Add(this.outsourceRadionBtn);
            this.Controls.Add(this.inHouseRadioBtn);
            this.Controls.Add(this.partFormLabel);
            this.Name = "PartForm";
            this.Text = "Part";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partFormLabel;
        private System.Windows.Forms.RadioButton inHouseRadioBtn;
        private System.Windows.Forms.RadioButton outsourceRadionBtn;
        private System.Windows.Forms.TextBox partIDInput;
        private System.Windows.Forms.TextBox partNameInput;
        private System.Windows.Forms.TextBox partInventoryInput;
        private System.Windows.Forms.TextBox partCostInput;
        private System.Windows.Forms.TextBox partOriginSpecificInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label partOriginSpecificLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}