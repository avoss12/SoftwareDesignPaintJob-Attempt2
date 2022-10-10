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
            this.txtInterfaceEstimate = new System.Windows.Forms.TextBox();
            this.txtApiReturnID = new System.Windows.Forms.TextBox();
            this.lblApiReturnID = new System.Windows.Forms.Label();
            this.btnAPICall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClicktoCalculate
            // 
            this.btnClicktoCalculate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClicktoCalculate.Location = new System.Drawing.Point(128, 472);
            this.btnClicktoCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClicktoCalculate.Name = "btnClicktoCalculate";
            this.btnClicktoCalculate.Size = new System.Drawing.Size(266, 67);
            this.btnClicktoCalculate.TabIndex = 0;
            this.btnClicktoCalculate.Text = "Click to Calculate";
            this.btnClicktoCalculate.UseVisualStyleBackColor = true;
            this.btnClicktoCalculate.Click += new System.EventHandler(this.btnClicktoCalculate_Click);
            // 
            // lblItemLength
            // 
            this.lblItemLength.AutoSize = true;
            this.lblItemLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemLength.Location = new System.Drawing.Point(97, 268);
            this.lblItemLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemLength.Name = "lblItemLength";
            this.lblItemLength.Size = new System.Drawing.Size(140, 27);
            this.lblItemLength.TabIndex = 1;
            this.lblItemLength.Text = "Item Length";
            // 
            // txtItemLength
            // 
            this.txtItemLength.Location = new System.Drawing.Point(253, 260);
            this.txtItemLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemLength.Name = "txtItemLength";
            this.txtItemLength.Size = new System.Drawing.Size(141, 31);
            this.txtItemLength.TabIndex = 2;
            // 
            // txtItemWidthHeight
            // 
            this.txtItemWidthHeight.Location = new System.Drawing.Point(253, 328);
            this.txtItemWidthHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemWidthHeight.Name = "txtItemWidthHeight";
            this.txtItemWidthHeight.Size = new System.Drawing.Size(141, 31);
            this.txtItemWidthHeight.TabIndex = 4;
            // 
            // lblItemWidthHeight
            // 
            this.lblItemWidthHeight.AutoSize = true;
            this.lblItemWidthHeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemWidthHeight.Location = new System.Drawing.Point(26, 337);
            this.lblItemWidthHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemWidthHeight.Name = "lblItemWidthHeight";
            this.lblItemWidthHeight.Size = new System.Drawing.Size(219, 27);
            this.lblItemWidthHeight.TabIndex = 3;
            this.lblItemWidthHeight.Text = "Item Width / Height";
            // 
            // txtItemSF
            // 
            this.txtItemSF.Location = new System.Drawing.Point(939, 202);
            this.txtItemSF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemSF.Name = "txtItemSF";
            this.txtItemSF.Size = new System.Drawing.Size(141, 31);
            this.txtItemSF.TabIndex = 6;
            this.txtItemSF.TextChanged += new System.EventHandler(this.txtCeilingSF_TextChanged);
            // 
            // lblItemSF
            // 
            this.lblItemSF.AutoSize = true;
            this.lblItemSF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemSF.Location = new System.Drawing.Point(793, 205);
            this.lblItemSF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemSF.Name = "lblItemSF";
            this.lblItemSF.Size = new System.Drawing.Size(96, 27);
            this.lblItemSF.TabIndex = 5;
            this.lblItemSF.Text = "Item SF";
            this.lblItemSF.Click += new System.EventHandler(this.lblCeilingSF_Click);
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(253, 387);
            this.txtItemRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(141, 31);
            this.txtItemRate.TabIndex = 8;
            this.txtItemRate.TextChanged += new System.EventHandler(this.txtCeilingRate_TextChanged);
            // 
            // lblItemRate
            // 
            this.lblItemRate.AutoSize = true;
            this.lblItemRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemRate.Location = new System.Drawing.Point(117, 397);
            this.lblItemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemRate.Name = "lblItemRate";
            this.lblItemRate.Size = new System.Drawing.Size(115, 27);
            this.lblItemRate.TabIndex = 7;
            this.lblItemRate.Text = "Item Rate";
            this.lblItemRate.Click += new System.EventHandler(this.lblCeilingRate_Click);
            // 
            // lblItemEstTotal
            // 
            this.lblItemEstTotal.AutoSize = true;
            this.lblItemEstTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemEstTotal.Location = new System.Drawing.Point(674, 287);
            this.lblItemEstTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemEstTotal.Name = "lblItemEstTotal";
            this.lblItemEstTotal.Size = new System.Drawing.Size(215, 27);
            this.lblItemEstTotal.TabIndex = 9;
            this.lblItemEstTotal.Text = "Item Estimate Total";
            // 
            // lblPaintJobEstimator
            // 
            this.lblPaintJobEstimator.AutoSize = true;
            this.lblPaintJobEstimator.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaintJobEstimator.Location = new System.Drawing.Point(430, 20);
            this.lblPaintJobEstimator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaintJobEstimator.Name = "lblPaintJobEstimator";
            this.lblPaintJobEstimator.Size = new System.Drawing.Size(409, 51);
            this.lblPaintJobEstimator.TabIndex = 11;
            this.lblPaintJobEstimator.Text = "Paint Job Estimator";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.Location = new System.Drawing.Point(771, 112);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(145, 27);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(939, 105);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(141, 31);
            this.txtRoomName.TabIndex = 13;
            // 
            // txtItemPaintColor
            // 
            this.txtItemPaintColor.Location = new System.Drawing.Point(253, 185);
            this.txtItemPaintColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemPaintColor.Name = "txtItemPaintColor";
            this.txtItemPaintColor.Size = new System.Drawing.Size(141, 31);
            this.txtItemPaintColor.TabIndex = 15;
            // 
            // lblItemPaintColor
            // 
            this.lblItemPaintColor.AutoSize = true;
            this.lblItemPaintColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemPaintColor.Location = new System.Drawing.Point(53, 193);
            this.lblItemPaintColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPaintColor.Name = "lblItemPaintColor";
            this.lblItemPaintColor.Size = new System.Drawing.Size(184, 27);
            this.lblItemPaintColor.TabIndex = 14;
            this.lblItemPaintColor.Text = "Item Paint Color";
            // 
            // itemNameList
            // 
            this.itemNameList.AllowDrop = true;
            this.itemNameList.FormattingEnabled = true;
            this.itemNameList.ItemHeight = 25;
            this.itemNameList.Items.AddRange(new object[] {
            "Ceilings",
            "Walls",
            "Baseboard",
            "Crown",
            "Doors",
            "Windows"});
            this.itemNameList.Location = new System.Drawing.Point(253, 73);
            this.itemNameList.Name = "itemNameList";
            this.itemNameList.Size = new System.Drawing.Size(180, 79);
            this.itemNameList.TabIndex = 16;
            this.itemNameList.SelectedIndexChanged += new System.EventHandler(this.roomNameList_SelectedIndexChanged);
            // 
            // lblSelectItemList
            // 
            this.lblSelectItemList.AutoSize = true;
            this.lblSelectItemList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectItemList.Location = new System.Drawing.Point(44, 105);
            this.lblSelectItemList.Name = "lblSelectItemList";
            this.lblSelectItemList.Size = new System.Drawing.Size(194, 27);
            this.lblSelectItemList.TabIndex = 17;
            this.lblSelectItemList.Text = "Select Paint Item\r\n";
            // 
            // txtThisType
            // 
            this.txtThisType.Location = new System.Drawing.Point(943, 393);
            this.txtThisType.Name = "txtThisType";
            this.txtThisType.Size = new System.Drawing.Size(150, 31);
            this.txtThisType.TabIndex = 18;
            this.txtThisType.TextChanged += new System.EventHandler(this.txtThisType_TextChanged);
            // 
            // lblReflectionClassType
            // 
            this.lblReflectionClassType.AutoSize = true;
            this.lblReflectionClassType.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReflectionClassType.Location = new System.Drawing.Point(694, 397);
            this.lblReflectionClassType.Name = "lblReflectionClassType";
            this.lblReflectionClassType.Size = new System.Drawing.Size(223, 25);
            this.lblReflectionClassType.TabIndex = 19;
            this.lblReflectionClassType.Text = "Reflection Class Type";
            this.lblReflectionClassType.Click += new System.EventHandler(this.lblReflectionClassType_Click);
            // 
            // txtInterfaceEstimate
            // 
            this.txtInterfaceEstimate.Location = new System.Drawing.Point(939, 287);
            this.txtInterfaceEstimate.Name = "txtInterfaceEstimate";
            this.txtInterfaceEstimate.Size = new System.Drawing.Size(150, 31);
            this.txtInterfaceEstimate.TabIndex = 20;
            this.txtInterfaceEstimate.TextChanged += new System.EventHandler(this.txtInterfaceEstimate_TextChanged);
            // 
            // txtApiReturnID
            // 
            this.txtApiReturnID.Location = new System.Drawing.Point(249, 792);
            this.txtApiReturnID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApiReturnID.Name = "txtApiReturnID";
            this.txtApiReturnID.Size = new System.Drawing.Size(290, 31);
            this.txtApiReturnID.TabIndex = 21;
            this.txtApiReturnID.TextChanged += new System.EventHandler(this.txtApiReturnID_TextChanged);
            // 
            // lblApiReturnID
            // 
            this.lblApiReturnID.AutoSize = true;
            this.lblApiReturnID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApiReturnID.Location = new System.Drawing.Point(66, 798);
            this.lblApiReturnID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApiReturnID.Name = "lblApiReturnID";
            this.lblApiReturnID.Size = new System.Drawing.Size(159, 27);
            this.lblApiReturnID.TabIndex = 22;
            this.lblApiReturnID.Text = "API Return ID";
            this.lblApiReturnID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAPICall
            // 
            this.btnAPICall.Location = new System.Drawing.Point(637, 789);
            this.btnAPICall.Name = "btnAPICall";
            this.btnAPICall.Size = new System.Drawing.Size(112, 34);
            this.btnAPICall.TabIndex = 23;
            this.btnAPICall.Text = "Call API";
            this.btnAPICall.UseVisualStyleBackColor = true;
            this.btnAPICall.Click += new System.EventHandler(this.btnAPICall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1050);
            this.Controls.Add(this.btnAPICall);
            this.Controls.Add(this.lblApiReturnID);
            this.Controls.Add(this.txtApiReturnID);
            this.Controls.Add(this.txtInterfaceEstimate);
            this.Controls.Add(this.lblReflectionClassType);
            this.Controls.Add(this.txtThisType);
            this.Controls.Add(this.lblSelectItemList);
            this.Controls.Add(this.itemNameList);
            this.Controls.Add(this.txtItemPaintColor);
            this.Controls.Add(this.lblItemPaintColor);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblPaintJobEstimator);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private TextBox txtInterfaceEstimate;
        private TextBox txtApiReturnID;
        private Label lblApiReturnID;
        private Button APIButton;
        private Button btnAPICall;
    }
}