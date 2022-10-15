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
            this.txtItemPaintColor1 = new System.Windows.Forms.TextBox();
            this.txtItemLength1 = new System.Windows.Forms.TextBox();
            this.txtItemWidthHeight1 = new System.Windows.Forms.TextBox();
            this.txtItemRate1 = new System.Windows.Forms.TextBox();
            this.txtItemSF1 = new System.Windows.Forms.TextBox();
            this.txtInterfaceEstimate1 = new System.Windows.Forms.TextBox();
            this.txtThisType1 = new System.Windows.Forms.TextBox();
            this.lblItemToPaint = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblItemToPaintCeilings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemToPaintBaseboard = new System.Windows.Forms.Label();
            this.lblItemToPaintCrown = new System.Windows.Forms.Label();
            this.lblItemToPaintDoors = new System.Windows.Forms.Label();
            this.lblItemToPaintWindows = new System.Windows.Forms.Label();
            this.txtEstimateTotal = new System.Windows.Forms.TextBox();
            this.lblEstimateTotal = new System.Windows.Forms.Label();
            this.txtItemPaintColor2 = new System.Windows.Forms.TextBox();
            this.txtItemLength2 = new System.Windows.Forms.TextBox();
            this.txtItemWidthHeight2 = new System.Windows.Forms.TextBox();
            this.txtItemRate2 = new System.Windows.Forms.TextBox();
            this.txtItemSF2 = new System.Windows.Forms.TextBox();
            this.txtInterfaceEstimate2 = new System.Windows.Forms.TextBox();
            this.txtThisType2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClicktoCalculate
            // 
            this.btnClicktoCalculate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClicktoCalculate.Location = new System.Drawing.Point(628, 410);
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
            this.lblItemLength.Location = new System.Drawing.Point(326, 67);
            this.lblItemLength.Name = "lblItemLength";
            this.lblItemLength.Size = new System.Drawing.Size(88, 18);
            this.lblItemLength.TabIndex = 1;
            this.lblItemLength.Text = "Item Length";
            // 
            // txtItemLength
            // 
            this.txtItemLength.Location = new System.Drawing.Point(328, 111);
            this.txtItemLength.Name = "txtItemLength";
            this.txtItemLength.Size = new System.Drawing.Size(100, 23);
            this.txtItemLength.TabIndex = 2;
            this.txtItemLength.TextChanged += new System.EventHandler(this.txtItemLength_TextChanged);
            // 
            // txtItemWidthHeight
            // 
            this.txtItemWidthHeight.Location = new System.Drawing.Point(508, 112);
            this.txtItemWidthHeight.Name = "txtItemWidthHeight";
            this.txtItemWidthHeight.Size = new System.Drawing.Size(100, 23);
            this.txtItemWidthHeight.TabIndex = 4;
            this.txtItemWidthHeight.TextChanged += new System.EventHandler(this.txtItemWidthHeight_TextChanged);
            // 
            // lblItemWidthHeight
            // 
            this.lblItemWidthHeight.AutoSize = true;
            this.lblItemWidthHeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemWidthHeight.Location = new System.Drawing.Point(508, 68);
            this.lblItemWidthHeight.Name = "lblItemWidthHeight";
            this.lblItemWidthHeight.Size = new System.Drawing.Size(138, 18);
            this.lblItemWidthHeight.TabIndex = 3;
            this.lblItemWidthHeight.Text = "Item Width / Height";
            // 
            // txtItemSF
            // 
            this.txtItemSF.Location = new System.Drawing.Point(835, 111);
            this.txtItemSF.Name = "txtItemSF";
            this.txtItemSF.Size = new System.Drawing.Size(100, 23);
            this.txtItemSF.TabIndex = 6;
            this.txtItemSF.TextChanged += new System.EventHandler(this.txtCeilingSF_TextChanged);
            // 
            // lblItemSF
            // 
            this.lblItemSF.AutoSize = true;
            this.lblItemSF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemSF.Location = new System.Drawing.Point(835, 67);
            this.lblItemSF.Name = "lblItemSF";
            this.lblItemSF.Size = new System.Drawing.Size(62, 18);
            this.lblItemSF.TabIndex = 5;
            this.lblItemSF.Text = "Item SF";
            this.lblItemSF.Click += new System.EventHandler(this.lblCeilingSF_Click);
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(703, 111);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(100, 23);
            this.txtItemRate.TabIndex = 8;
            this.txtItemRate.TextChanged += new System.EventHandler(this.txtCeilingRate_TextChanged);
            // 
            // lblItemRate
            // 
            this.lblItemRate.AutoSize = true;
            this.lblItemRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemRate.Location = new System.Drawing.Point(703, 67);
            this.lblItemRate.Name = "lblItemRate";
            this.lblItemRate.Size = new System.Drawing.Size(74, 18);
            this.lblItemRate.TabIndex = 7;
            this.lblItemRate.Text = "Item Rate";
            this.lblItemRate.Click += new System.EventHandler(this.lblCeilingRate_Click);
            // 
            // lblItemEstTotal
            // 
            this.lblItemEstTotal.AutoSize = true;
            this.lblItemEstTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemEstTotal.Location = new System.Drawing.Point(1010, 67);
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
            this.lblRoomName.Location = new System.Drawing.Point(718, 542);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(96, 18);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(835, 538);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 23);
            this.txtRoomName.TabIndex = 13;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // txtItemPaintColor
            // 
            this.txtItemPaintColor.Location = new System.Drawing.Point(201, 111);
            this.txtItemPaintColor.Name = "txtItemPaintColor";
            this.txtItemPaintColor.Size = new System.Drawing.Size(100, 23);
            this.txtItemPaintColor.TabIndex = 15;
            this.txtItemPaintColor.TextChanged += new System.EventHandler(this.txtItemPaintColor_TextChanged);
            // 
            // lblItemPaintColor
            // 
            this.lblItemPaintColor.AutoSize = true;
            this.lblItemPaintColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemPaintColor.Location = new System.Drawing.Point(201, 67);
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
            this.itemNameList.Location = new System.Drawing.Point(1124, 498);
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
            this.lblSelectItemList.Location = new System.Drawing.Point(1126, 467);
            this.lblSelectItemList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectItemList.Name = "lblSelectItemList";
            this.lblSelectItemList.Size = new System.Drawing.Size(125, 18);
            this.lblSelectItemList.TabIndex = 17;
            this.lblSelectItemList.Text = "Select Paint Item\r\n";
            // 
            // txtThisType
            // 
            this.txtThisType.Location = new System.Drawing.Point(1170, 111);
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
            this.lblReflectionClassType.Location = new System.Drawing.Point(1170, 68);
            this.lblReflectionClassType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReflectionClassType.Name = "lblReflectionClassType";
            this.lblReflectionClassType.Size = new System.Drawing.Size(97, 17);
            this.lblReflectionClassType.TabIndex = 19;
            this.lblReflectionClassType.Text = "Item Selected";
            this.lblReflectionClassType.Click += new System.EventHandler(this.lblReflectionClassType_Click);
            // 
            // txtInterfaceEstimate
            // 
            this.txtInterfaceEstimate.Location = new System.Drawing.Point(1010, 111);
            this.txtInterfaceEstimate.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterfaceEstimate.Name = "txtInterfaceEstimate";
            this.txtInterfaceEstimate.Size = new System.Drawing.Size(106, 23);
            this.txtInterfaceEstimate.TabIndex = 20;
            this.txtInterfaceEstimate.TextChanged += new System.EventHandler(this.txtInterfaceEstimate_TextChanged);
            // 
            // txtApiReturnID
            // 
            this.txtApiReturnID.Location = new System.Drawing.Point(174, 475);
            this.txtApiReturnID.Name = "txtApiReturnID";
            this.txtApiReturnID.Size = new System.Drawing.Size(204, 23);
            this.txtApiReturnID.TabIndex = 21;
            this.txtApiReturnID.TextChanged += new System.EventHandler(this.txtApiReturnID_TextChanged);
            // 
            // lblApiReturnID
            // 
            this.lblApiReturnID.AutoSize = true;
            this.lblApiReturnID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApiReturnID.Location = new System.Drawing.Point(46, 479);
            this.lblApiReturnID.Name = "lblApiReturnID";
            this.lblApiReturnID.Size = new System.Drawing.Size(101, 18);
            this.lblApiReturnID.TabIndex = 22;
            this.lblApiReturnID.Text = "API Return ID";
            this.lblApiReturnID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAPICall
            // 
            this.btnAPICall.Location = new System.Drawing.Point(446, 473);
            this.btnAPICall.Margin = new System.Windows.Forms.Padding(2);
            this.btnAPICall.Name = "btnAPICall";
            this.btnAPICall.Size = new System.Drawing.Size(78, 20);
            this.btnAPICall.TabIndex = 23;
            this.btnAPICall.Text = "Call API";
            this.btnAPICall.UseVisualStyleBackColor = true;
            this.btnAPICall.Click += new System.EventHandler(this.btnAPICall_Click);
            // 
            // txtItemPaintColor1
            // 
            this.txtItemPaintColor1.Location = new System.Drawing.Point(201, 162);
            this.txtItemPaintColor1.Name = "txtItemPaintColor1";
            this.txtItemPaintColor1.Size = new System.Drawing.Size(100, 23);
            this.txtItemPaintColor1.TabIndex = 24;
            this.txtItemPaintColor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtItemLength1
            // 
            this.txtItemLength1.Location = new System.Drawing.Point(328, 162);
            this.txtItemLength1.Name = "txtItemLength1";
            this.txtItemLength1.Size = new System.Drawing.Size(100, 23);
            this.txtItemLength1.TabIndex = 25;
            // 
            // txtItemWidthHeight1
            // 
            this.txtItemWidthHeight1.Location = new System.Drawing.Point(508, 163);
            this.txtItemWidthHeight1.Name = "txtItemWidthHeight1";
            this.txtItemWidthHeight1.Size = new System.Drawing.Size(100, 23);
            this.txtItemWidthHeight1.TabIndex = 26;
            // 
            // txtItemRate1
            // 
            this.txtItemRate1.Location = new System.Drawing.Point(703, 162);
            this.txtItemRate1.Name = "txtItemRate1";
            this.txtItemRate1.Size = new System.Drawing.Size(100, 23);
            this.txtItemRate1.TabIndex = 27;
            // 
            // txtItemSF1
            // 
            this.txtItemSF1.Location = new System.Drawing.Point(835, 162);
            this.txtItemSF1.Name = "txtItemSF1";
            this.txtItemSF1.Size = new System.Drawing.Size(100, 23);
            this.txtItemSF1.TabIndex = 28;
            this.txtItemSF1.TextChanged += new System.EventHandler(this.txtItemSF1_TextChanged);
            // 
            // txtInterfaceEstimate1
            // 
            this.txtInterfaceEstimate1.Location = new System.Drawing.Point(1010, 162);
            this.txtInterfaceEstimate1.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterfaceEstimate1.Name = "txtInterfaceEstimate1";
            this.txtInterfaceEstimate1.Size = new System.Drawing.Size(106, 23);
            this.txtInterfaceEstimate1.TabIndex = 29;
            this.txtInterfaceEstimate1.TextChanged += new System.EventHandler(this.txtInterfaceEstimate1_TextChanged);
            // 
            // txtThisType1
            // 
            this.txtThisType1.Location = new System.Drawing.Point(1170, 162);
            this.txtThisType1.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType1.Name = "txtThisType1";
            this.txtThisType1.Size = new System.Drawing.Size(106, 23);
            this.txtThisType1.TabIndex = 30;
            // 
            // lblItemToPaint
            // 
            this.lblItemToPaint.AutoSize = true;
            this.lblItemToPaint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaint.Location = new System.Drawing.Point(89, 67);
            this.lblItemToPaint.Name = "lblItemToPaint";
            this.lblItemToPaint.Size = new System.Drawing.Size(94, 18);
            this.lblItemToPaint.TabIndex = 31;
            this.lblItemToPaint.Text = "Item to Paint";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1124, 552);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 32;
            // 
            // lblItemToPaintCeilings
            // 
            this.lblItemToPaintCeilings.AutoSize = true;
            this.lblItemToPaintCeilings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaintCeilings.Location = new System.Drawing.Point(89, 116);
            this.lblItemToPaintCeilings.Name = "lblItemToPaintCeilings";
            this.lblItemToPaintCeilings.Size = new System.Drawing.Size(65, 18);
            this.lblItemToPaintCeilings.TabIndex = 33;
            this.lblItemToPaintCeilings.Text = "Ceilings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Walls";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblItemToPaintBaseboard
            // 
            this.lblItemToPaintBaseboard.AutoSize = true;
            this.lblItemToPaintBaseboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaintBaseboard.Location = new System.Drawing.Point(89, 214);
            this.lblItemToPaintBaseboard.Name = "lblItemToPaintBaseboard";
            this.lblItemToPaintBaseboard.Size = new System.Drawing.Size(94, 18);
            this.lblItemToPaintBaseboard.TabIndex = 35;
            this.lblItemToPaintBaseboard.Text = "Baseboards";
            // 
            // lblItemToPaintCrown
            // 
            this.lblItemToPaintCrown.AutoSize = true;
            this.lblItemToPaintCrown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaintCrown.Location = new System.Drawing.Point(89, 265);
            this.lblItemToPaintCrown.Name = "lblItemToPaintCrown";
            this.lblItemToPaintCrown.Size = new System.Drawing.Size(53, 18);
            this.lblItemToPaintCrown.TabIndex = 36;
            this.lblItemToPaintCrown.Text = "Crown";
            // 
            // lblItemToPaintDoors
            // 
            this.lblItemToPaintDoors.AutoSize = true;
            this.lblItemToPaintDoors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaintDoors.Location = new System.Drawing.Point(89, 307);
            this.lblItemToPaintDoors.Name = "lblItemToPaintDoors";
            this.lblItemToPaintDoors.Size = new System.Drawing.Size(51, 18);
            this.lblItemToPaintDoors.TabIndex = 37;
            this.lblItemToPaintDoors.Text = "Doors";
            // 
            // lblItemToPaintWindows
            // 
            this.lblItemToPaintWindows.AutoSize = true;
            this.lblItemToPaintWindows.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemToPaintWindows.Location = new System.Drawing.Point(89, 351);
            this.lblItemToPaintWindows.Name = "lblItemToPaintWindows";
            this.lblItemToPaintWindows.Size = new System.Drawing.Size(72, 18);
            this.lblItemToPaintWindows.TabIndex = 38;
            this.lblItemToPaintWindows.Text = "Windows";
            // 
            // txtEstimateTotal
            // 
            this.txtEstimateTotal.Location = new System.Drawing.Point(1010, 427);
            this.txtEstimateTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstimateTotal.Name = "txtEstimateTotal";
            this.txtEstimateTotal.Size = new System.Drawing.Size(106, 23);
            this.txtEstimateTotal.TabIndex = 39;
            // 
            // lblEstimateTotal
            // 
            this.lblEstimateTotal.AutoSize = true;
            this.lblEstimateTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimateTotal.Location = new System.Drawing.Point(884, 432);
            this.lblEstimateTotal.Name = "lblEstimateTotal";
            this.lblEstimateTotal.Size = new System.Drawing.Size(106, 18);
            this.lblEstimateTotal.TabIndex = 40;
            this.lblEstimateTotal.Text = "Estimate Total";
            // 
            // txtItemPaintColor2
            // 
            this.txtItemPaintColor2.Location = new System.Drawing.Point(201, 209);
            this.txtItemPaintColor2.Name = "txtItemPaintColor2";
            this.txtItemPaintColor2.Size = new System.Drawing.Size(100, 23);
            this.txtItemPaintColor2.TabIndex = 41;
            // 
            // txtItemLength2
            // 
            this.txtItemLength2.Location = new System.Drawing.Point(326, 209);
            this.txtItemLength2.Name = "txtItemLength2";
            this.txtItemLength2.Size = new System.Drawing.Size(100, 23);
            this.txtItemLength2.TabIndex = 42;
            // 
            // txtItemWidthHeight2
            // 
            this.txtItemWidthHeight2.Location = new System.Drawing.Point(508, 209);
            this.txtItemWidthHeight2.Name = "txtItemWidthHeight2";
            this.txtItemWidthHeight2.Size = new System.Drawing.Size(100, 23);
            this.txtItemWidthHeight2.TabIndex = 43;
            // 
            // txtItemRate2
            // 
            this.txtItemRate2.Location = new System.Drawing.Point(703, 209);
            this.txtItemRate2.Name = "txtItemRate2";
            this.txtItemRate2.Size = new System.Drawing.Size(100, 23);
            this.txtItemRate2.TabIndex = 44;
            // 
            // txtItemSF2
            // 
            this.txtItemSF2.Location = new System.Drawing.Point(835, 209);
            this.txtItemSF2.Name = "txtItemSF2";
            this.txtItemSF2.Size = new System.Drawing.Size(100, 23);
            this.txtItemSF2.TabIndex = 45;
            // 
            // txtInterfaceEstimate2
            // 
            this.txtInterfaceEstimate2.Location = new System.Drawing.Point(1010, 209);
            this.txtInterfaceEstimate2.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterfaceEstimate2.Name = "txtInterfaceEstimate2";
            this.txtInterfaceEstimate2.Size = new System.Drawing.Size(106, 23);
            this.txtInterfaceEstimate2.TabIndex = 46;
            // 
            // txtThisType2
            // 
            this.txtThisType2.Location = new System.Drawing.Point(1170, 209);
            this.txtThisType2.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType2.Name = "txtThisType2";
            this.txtThisType2.Size = new System.Drawing.Size(106, 23);
            this.txtThisType2.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 630);
            this.Controls.Add(this.txtThisType2);
            this.Controls.Add(this.txtInterfaceEstimate2);
            this.Controls.Add(this.txtItemSF2);
            this.Controls.Add(this.txtItemRate2);
            this.Controls.Add(this.txtItemWidthHeight2);
            this.Controls.Add(this.txtItemLength2);
            this.Controls.Add(this.txtItemPaintColor2);
            this.Controls.Add(this.lblEstimateTotal);
            this.Controls.Add(this.txtEstimateTotal);
            this.Controls.Add(this.lblItemToPaintWindows);
            this.Controls.Add(this.lblItemToPaintDoors);
            this.Controls.Add(this.lblItemToPaintCrown);
            this.Controls.Add(this.lblItemToPaintBaseboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemToPaintCeilings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblItemToPaint);
            this.Controls.Add(this.txtThisType1);
            this.Controls.Add(this.txtInterfaceEstimate1);
            this.Controls.Add(this.txtItemSF1);
            this.Controls.Add(this.txtItemRate1);
            this.Controls.Add(this.txtItemWidthHeight1);
            this.Controls.Add(this.txtItemLength1);
            this.Controls.Add(this.txtItemPaintColor1);
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
        private TextBox txtItemPaintColor1;
        private TextBox txtItemLength1;
        private TextBox txtItemWidthHeight1;
        private TextBox txtItemRate1;
        private TextBox txtItemSF1;
        private TextBox txtInterfaceEstimate1;
        private TextBox txtThisType1;
        private Label lblItemToPaint;
        private TextBox textBox1;
        private Label lblItemToPaintCeilings;
        private Label label1;
        private Label lblItemToPaintBaseboard;
        private Label lblItemToPaintCrown;
        private Label lblItemToPaintDoors;
        private Label lblItemToPaintWindows;
        private TextBox txtEstimateTotal;
        private Label lblEstimateTotal;
        private TextBox txtItemPaintColor2;
        private TextBox txtItemLength2;
        private TextBox txtItemWidthHeight2;
        private TextBox txtItemRate2;
        private TextBox txtItemSF2;
        private TextBox txtInterfaceEstimate2;
        private TextBox txtThisType2;
    }
}