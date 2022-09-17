namespace SoftwareDesignProjectPaintJob
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClicktoCalculate = new System.Windows.Forms.Button();
            this.lblItemLength = new System.Windows.Forms.Label();
            this.txtItemLength = new System.Windows.Forms.TextBox();
            this.txtItemWidthHeight = new System.Windows.Forms.TextBox();
            this.lblItemWidthHeight = new System.Windows.Forms.Label();
            this.txtItemSF = new System.Windows.Forms.TextBox();
            this.lblItemSF = new System.Windows.Forms.Label();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.lblItemRate = new System.Windows.Forms.Label();
            this.txtItemEstTotal = new System.Windows.Forms.TextBox();
            this.lblItemEstTotal = new System.Windows.Forms.Label();
            this.lblPaintJobEstimator = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtItemPaintColor = new System.Windows.Forms.TextBox();
            this.lblItemPaintColor = new System.Windows.Forms.Label();
            this.itemNameList = new System.Windows.Forms.ListBox();
            this.lblSelectItemList = new System.Windows.Forms.Label();
            this.txtThisType = new System.Windows.Forms.TextBox();
            this.lblReflectionClassType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClicktoCalculate
            // 
            this.btnClicktoCalculate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClicktoCalculate.Location = new System.Drawing.Point(499, 456);
            this.btnClicktoCalculate.Name = "btnClicktoCalculate";
            this.btnClicktoCalculate.Size = new System.Drawing.Size(186, 40);
            this.btnClicktoCalculate.TabIndex = 0;
            this.btnClicktoCalculate.Text = "Click to Calculate";
            this.btnClicktoCalculate.UseVisualStyleBackColor = true;
            this.btnClicktoCalculate.Click += new System.EventHandler(this.btnClicktoCalculate_Click);
            // 
            // lblItemLength
            // 
            this.lblItemLength.AutoSize = true;
            this.lblItemLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemLength.Location = new System.Drawing.Point(68, 161);
            this.lblItemLength.Name = "lblItemLength";
            this.lblItemLength.Size = new System.Drawing.Size(88, 18);
            this.lblItemLength.TabIndex = 1;
            this.lblItemLength.Text = "Item Length";
            // 
            // txtItemLength
            // 
            this.txtItemLength.Location = new System.Drawing.Point(177, 156);
            this.txtItemLength.Name = "txtItemLength";
            this.txtItemLength.Size = new System.Drawing.Size(100, 23);
            this.txtItemLength.TabIndex = 2;
            // 
            // txtItemWidthHeight
            // 
            this.txtItemWidthHeight.Location = new System.Drawing.Point(177, 197);
            this.txtItemWidthHeight.Name = "txtItemWidthHeight";
            this.txtItemWidthHeight.Size = new System.Drawing.Size(100, 23);
            this.txtItemWidthHeight.TabIndex = 4;
            // 
            // lblItemWidthHeight
            // 
            this.lblItemWidthHeight.AutoSize = true;
            this.lblItemWidthHeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemWidthHeight.Location = new System.Drawing.Point(18, 202);
            this.lblItemWidthHeight.Name = "lblItemWidthHeight";
            this.lblItemWidthHeight.Size = new System.Drawing.Size(138, 18);
            this.lblItemWidthHeight.TabIndex = 3;
            this.lblItemWidthHeight.Text = "Item Width / Height";
            // 
            // txtItemSF
            // 
            this.txtItemSF.Location = new System.Drawing.Point(657, 121);
            this.txtItemSF.Name = "txtItemSF";
            this.txtItemSF.Size = new System.Drawing.Size(100, 23);
            this.txtItemSF.TabIndex = 6;
            this.txtItemSF.TextChanged += new System.EventHandler(this.txtCeilingSF_TextChanged);
            // 
            // lblItemSF
            // 
            this.lblItemSF.AutoSize = true;
            this.lblItemSF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemSF.Location = new System.Drawing.Point(555, 123);
            this.lblItemSF.Name = "lblItemSF";
            this.lblItemSF.Size = new System.Drawing.Size(62, 18);
            this.lblItemSF.TabIndex = 5;
            this.lblItemSF.Text = "Item SF";
            this.lblItemSF.Click += new System.EventHandler(this.lblCeilingSF_Click);
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(177, 232);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(100, 23);
            this.txtItemRate.TabIndex = 8;
            this.txtItemRate.TextChanged += new System.EventHandler(this.txtCeilingRate_TextChanged);
            // 
            // lblItemRate
            // 
            this.lblItemRate.AutoSize = true;
            this.lblItemRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemRate.Location = new System.Drawing.Point(82, 238);
            this.lblItemRate.Name = "lblItemRate";
            this.lblItemRate.Size = new System.Drawing.Size(74, 18);
            this.lblItemRate.TabIndex = 7;
            this.lblItemRate.Text = "Item Rate";
            this.lblItemRate.Click += new System.EventHandler(this.lblCeilingRate_Click);
            // 
            // txtItemEstTotal
            // 
            this.txtItemEstTotal.Location = new System.Drawing.Point(657, 169);
            this.txtItemEstTotal.Name = "txtItemEstTotal";
            this.txtItemEstTotal.Size = new System.Drawing.Size(100, 23);
            this.txtItemEstTotal.TabIndex = 10;
            this.txtItemEstTotal.TextChanged += new System.EventHandler(this.txtCeilingEstimateTotal_TextChanged);
            // 
            // lblItemEstTotal
            // 
            this.lblItemEstTotal.AutoSize = true;
            this.lblItemEstTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemEstTotal.Location = new System.Drawing.Point(472, 172);
            this.lblItemEstTotal.Name = "lblItemEstTotal";
            this.lblItemEstTotal.Size = new System.Drawing.Size(139, 18);
            this.lblItemEstTotal.TabIndex = 9;
            this.lblItemEstTotal.Text = "Item Estimate Total";
            // 
            // lblPaintJobEstimator
            // 
            this.lblPaintJobEstimator.AutoSize = true;
            this.lblPaintJobEstimator.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaintJobEstimator.Location = new System.Drawing.Point(301, 12);
            this.lblPaintJobEstimator.Name = "lblPaintJobEstimator";
            this.lblPaintJobEstimator.Size = new System.Drawing.Size(275, 33);
            this.lblPaintJobEstimator.TabIndex = 11;
            this.lblPaintJobEstimator.Text = "Paint Job Estimator";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.Location = new System.Drawing.Point(540, 67);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(96, 18);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(657, 63);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 23);
            this.txtRoomName.TabIndex = 13;
            // 
            // txtItemPaintColor
            // 
            this.txtItemPaintColor.Location = new System.Drawing.Point(177, 111);
            this.txtItemPaintColor.Name = "txtItemPaintColor";
            this.txtItemPaintColor.Size = new System.Drawing.Size(100, 23);
            this.txtItemPaintColor.TabIndex = 15;
            // 
            // lblItemPaintColor
            // 
            this.lblItemPaintColor.AutoSize = true;
            this.lblItemPaintColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemPaintColor.Location = new System.Drawing.Point(37, 116);
            this.lblItemPaintColor.Name = "lblItemPaintColor";
            this.lblItemPaintColor.Size = new System.Drawing.Size(119, 18);
            this.lblItemPaintColor.TabIndex = 14;
            this.lblItemPaintColor.Text = "Item Paint Color";
            // 
            // itemNameList
            // 
            this.itemNameList.AllowDrop = true;
            this.itemNameList.FormattingEnabled = true;
            this.itemNameList.ItemHeight = 15;
            this.itemNameList.Items.AddRange(new object[] {
            "Ceilings",
            "Walls",
            "Baseboard",
            "Crown",
            "Doors",
            "Windows"});
            this.itemNameList.Location = new System.Drawing.Point(177, 44);
            this.itemNameList.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameList.Name = "itemNameList";
            this.itemNameList.Size = new System.Drawing.Size(127, 49);
            this.itemNameList.TabIndex = 16;
            this.itemNameList.SelectedIndexChanged += new System.EventHandler(this.roomNameList_SelectedIndexChanged);
            // 
            // lblSelectItemList
            // 
            this.lblSelectItemList.AutoSize = true;
            this.lblSelectItemList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectItemList.Location = new System.Drawing.Point(31, 63);
            this.lblSelectItemList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectItemList.Name = "lblSelectItemList";
            this.lblSelectItemList.Size = new System.Drawing.Size(125, 18);
            this.lblSelectItemList.TabIndex = 17;
            this.lblSelectItemList.Text = "Select Paint Item\r\n";
            // 
            // txtThisType
            // 
            this.txtThisType.Location = new System.Drawing.Point(660, 236);
            this.txtThisType.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType.Name = "txtThisType";
            this.txtThisType.Size = new System.Drawing.Size(106, 23);
            this.txtThisType.TabIndex = 18;
            this.txtThisType.TextChanged += new System.EventHandler(this.txtThisType_TextChanged);
            // 
            // lblReflectionClassType
            // 
            this.lblReflectionClassType.AutoSize = true;
            this.lblReflectionClassType.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReflectionClassType.Location = new System.Drawing.Point(486, 238);
            this.lblReflectionClassType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReflectionClassType.Name = "lblReflectionClassType";
            this.lblReflectionClassType.Size = new System.Drawing.Size(150, 17);
            this.lblReflectionClassType.TabIndex = 19;
            this.lblReflectionClassType.Text = "Reflection Class Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 657);
            this.Controls.Add(this.lblReflectionClassType);
            this.Controls.Add(this.txtThisType);
            this.Controls.Add(this.lblSelectItemList);
            this.Controls.Add(this.itemNameList);
            this.Controls.Add(this.txtItemPaintColor);
            this.Controls.Add(this.lblItemPaintColor);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblPaintJobEstimator);
            this.Controls.Add(this.txtItemEstTotal);
            this.Controls.Add(this.lblItemEstTotal);
            this.Controls.Add(this.txtItemRate);
            this.Controls.Add(this.lblItemRate);
            this.Controls.Add(this.txtItemSF);
            this.Controls.Add(this.lblItemSF);
            this.Controls.Add(this.txtItemWidthHeight);
            this.Controls.Add(this.lblItemWidthHeight);
            this.Controls.Add(this.txtItemLength);
            this.Controls.Add(this.lblItemLength);
            this.Controls.Add(this.btnClicktoCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClicktoCalculate;
        private Label lblItemLength;
        private TextBox txtItemLength;
        private TextBox txtItemWidthHeight;
        private Label lblItemWidthHeight;
        private TextBox txtItemSF;
        private Label lblItemSF;
        private TextBox txtItemRate;
        private Label lblItemRate;
        private TextBox txtItemEstTotal;
        private Label lblItemEstTotal;
        private Label lblPaintJobEstimator;
        private Label lblRoomName;
        private TextBox txtRoomName;
        private TextBox txtItemPaintColor;
        private Label lblItemPaintColor;
        private ListBox itemNameList;
        private Label lblSelectItemList;
        private TextBox txtThisType;
        private Label lblReflectionClassType;
    }
}