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
            this.lblCeilingLength = new System.Windows.Forms.Label();
            this.txtCeilingLength = new System.Windows.Forms.TextBox();
            this.txtCeilingWidth = new System.Windows.Forms.TextBox();
            this.lblCeilingWidth = new System.Windows.Forms.Label();
            this.txtCeilingSF = new System.Windows.Forms.TextBox();
            this.lblCeilingSF = new System.Windows.Forms.Label();
            this.txtCeilingRate = new System.Windows.Forms.TextBox();
            this.lblCeilingRate = new System.Windows.Forms.Label();
            this.txtCeilingEstimateTotal = new System.Windows.Forms.TextBox();
            this.lblCeilingEstimateTotal = new System.Windows.Forms.Label();
            this.lblPaintJobEstimator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtCeilngPaintColor = new System.Windows.Forms.TextBox();
            this.lblCeilingPaintColor = new System.Windows.Forms.Label();
            this.roomNameList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThisType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClicktoCalculate
            // 
            this.btnClicktoCalculate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClicktoCalculate.Location = new System.Drawing.Point(129, 449);
            this.btnClicktoCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClicktoCalculate.Name = "btnClicktoCalculate";
            this.btnClicktoCalculate.Size = new System.Drawing.Size(265, 67);
            this.btnClicktoCalculate.TabIndex = 0;
            this.btnClicktoCalculate.Text = "Click to Calculate";
            this.btnClicktoCalculate.UseVisualStyleBackColor = true;
            this.btnClicktoCalculate.Click += new System.EventHandler(this.btnClicktoCalculate_Click);
            // 
            // lblCeilingLength
            // 
            this.lblCeilingLength.AutoSize = true;
            this.lblCeilingLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingLength.Location = new System.Drawing.Point(67, 260);
            this.lblCeilingLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingLength.Name = "lblCeilingLength";
            this.lblCeilingLength.Size = new System.Drawing.Size(168, 27);
            this.lblCeilingLength.TabIndex = 1;
            this.lblCeilingLength.Text = "Ceiling Length";
            // 
            // txtCeilingLength
            // 
            this.txtCeilingLength.Location = new System.Drawing.Point(253, 260);
            this.txtCeilingLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilingLength.Name = "txtCeilingLength";
            this.txtCeilingLength.Size = new System.Drawing.Size(141, 31);
            this.txtCeilingLength.TabIndex = 2;
            // 
            // txtCeilingWidth
            // 
            this.txtCeilingWidth.Location = new System.Drawing.Point(253, 329);
            this.txtCeilingWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilingWidth.Name = "txtCeilingWidth";
            this.txtCeilingWidth.Size = new System.Drawing.Size(141, 31);
            this.txtCeilingWidth.TabIndex = 4;
            // 
            // lblCeilingWidth
            // 
            this.lblCeilingWidth.AutoSize = true;
            this.lblCeilingWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingWidth.Location = new System.Drawing.Point(79, 331);
            this.lblCeilingWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingWidth.Name = "lblCeilingWidth";
            this.lblCeilingWidth.Size = new System.Drawing.Size(156, 27);
            this.lblCeilingWidth.TabIndex = 3;
            this.lblCeilingWidth.Text = "Ceiling Width";
            // 
            // txtCeilingSF
            // 
            this.txtCeilingSF.Location = new System.Drawing.Point(938, 201);
            this.txtCeilingSF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilingSF.Name = "txtCeilingSF";
            this.txtCeilingSF.Size = new System.Drawing.Size(141, 31);
            this.txtCeilingSF.TabIndex = 6;
            this.txtCeilingSF.TextChanged += new System.EventHandler(this.txtCeilingSF_TextChanged);
            // 
            // lblCeilingSF
            // 
            this.lblCeilingSF.AutoSize = true;
            this.lblCeilingSF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingSF.Location = new System.Drawing.Point(793, 205);
            this.lblCeilingSF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingSF.Name = "lblCeilingSF";
            this.lblCeilingSF.Size = new System.Drawing.Size(124, 27);
            this.lblCeilingSF.TabIndex = 5;
            this.lblCeilingSF.Text = "Ceiling SF";
            this.lblCeilingSF.Click += new System.EventHandler(this.lblCeilingSF_Click);
            // 
            // txtCeilingRate
            // 
            this.txtCeilingRate.Location = new System.Drawing.Point(253, 386);
            this.txtCeilingRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilingRate.Name = "txtCeilingRate";
            this.txtCeilingRate.Size = new System.Drawing.Size(141, 31);
            this.txtCeilingRate.TabIndex = 8;
            this.txtCeilingRate.TextChanged += new System.EventHandler(this.txtCeilingRate_TextChanged);
            // 
            // lblCeilingRate
            // 
            this.lblCeilingRate.AutoSize = true;
            this.lblCeilingRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingRate.Location = new System.Drawing.Point(92, 388);
            this.lblCeilingRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingRate.Name = "lblCeilingRate";
            this.lblCeilingRate.Size = new System.Drawing.Size(143, 27);
            this.lblCeilingRate.TabIndex = 7;
            this.lblCeilingRate.Text = "Ceiling Rate";
            this.lblCeilingRate.Click += new System.EventHandler(this.lblCeilingRate_Click);
            // 
            // txtCeilingEstimateTotal
            // 
            this.txtCeilingEstimateTotal.Location = new System.Drawing.Point(938, 282);
            this.txtCeilingEstimateTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilingEstimateTotal.Name = "txtCeilingEstimateTotal";
            this.txtCeilingEstimateTotal.Size = new System.Drawing.Size(141, 31);
            this.txtCeilingEstimateTotal.TabIndex = 10;
            this.txtCeilingEstimateTotal.TextChanged += new System.EventHandler(this.txtCeilingEstimateTotal_TextChanged);
            // 
            // lblCeilingEstimateTotal
            // 
            this.lblCeilingEstimateTotal.AutoSize = true;
            this.lblCeilingEstimateTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingEstimateTotal.Location = new System.Drawing.Point(674, 286);
            this.lblCeilingEstimateTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingEstimateTotal.Name = "lblCeilingEstimateTotal";
            this.lblCeilingEstimateTotal.Size = new System.Drawing.Size(243, 27);
            this.lblCeilingEstimateTotal.TabIndex = 9;
            this.lblCeilingEstimateTotal.Text = "Ceiling Estimate Total";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(772, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(938, 105);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(141, 31);
            this.txtRoomName.TabIndex = 13;
            // 
            // txtCeilngPaintColor
            // 
            this.txtCeilngPaintColor.Location = new System.Drawing.Point(253, 185);
            this.txtCeilngPaintColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCeilngPaintColor.Name = "txtCeilngPaintColor";
            this.txtCeilngPaintColor.Size = new System.Drawing.Size(141, 31);
            this.txtCeilngPaintColor.TabIndex = 15;
            // 
            // lblCeilingPaintColor
            // 
            this.lblCeilingPaintColor.AutoSize = true;
            this.lblCeilingPaintColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingPaintColor.Location = new System.Drawing.Point(23, 185);
            this.lblCeilingPaintColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCeilingPaintColor.Name = "lblCeilingPaintColor";
            this.lblCeilingPaintColor.Size = new System.Drawing.Size(212, 27);
            this.lblCeilingPaintColor.TabIndex = 14;
            this.lblCeilingPaintColor.Text = "Ceiling Paint Color";
            // 
            // roomNameList
            // 
            this.roomNameList.AllowDrop = true;
            this.roomNameList.FormattingEnabled = true;
            this.roomNameList.ItemHeight = 25;
            this.roomNameList.Items.AddRange(new object[] {
            "Kitchen",
            "Living Room",
            "Guest Bath",
            "Primary Bath",
            "Basement"});
            this.roomNameList.Location = new System.Drawing.Point(253, 74);
            this.roomNameList.Name = "roomNameList";
            this.roomNameList.Size = new System.Drawing.Size(180, 79);
            this.roomNameList.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(111, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Room";
            // 
            // txtThisType
            // 
            this.txtThisType.Location = new System.Drawing.Point(943, 393);
            this.txtThisType.Name = "txtThisType";
            this.txtThisType.Size = new System.Drawing.Size(150, 31);
            this.txtThisType.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(694, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reflection Class Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 750);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThisType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomNameList);
            this.Controls.Add(this.txtCeilngPaintColor);
            this.Controls.Add(this.lblCeilingPaintColor);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPaintJobEstimator);
            this.Controls.Add(this.txtCeilingEstimateTotal);
            this.Controls.Add(this.lblCeilingEstimateTotal);
            this.Controls.Add(this.txtCeilingRate);
            this.Controls.Add(this.lblCeilingRate);
            this.Controls.Add(this.txtCeilingSF);
            this.Controls.Add(this.lblCeilingSF);
            this.Controls.Add(this.txtCeilingWidth);
            this.Controls.Add(this.lblCeilingWidth);
            this.Controls.Add(this.txtCeilingLength);
            this.Controls.Add(this.lblCeilingLength);
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
        private Label lblCeilingLength;
        private TextBox txtCeilingLength;
        private TextBox txtCeilingWidth;
        private Label lblCeilingWidth;
        private TextBox txtCeilingSF;
        private Label lblCeilingSF;
        private TextBox txtCeilingRate;
        private Label lblCeilingRate;
        private TextBox txtCeilingEstimateTotal;
        private Label lblCeilingEstimateTotal;
        private Label lblPaintJobEstimator;
        private Label label1;
        private TextBox txtRoomName;
        private TextBox txtCeilngPaintColor;
        private Label lblCeilingPaintColor;
        private ListBox roomNameList;
        private Label label2;
        private TextBox txtThisType;
        private Label label3;
    }
}