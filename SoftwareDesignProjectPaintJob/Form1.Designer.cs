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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCeilngPaintColor = new System.Windows.Forms.TextBox();
            this.lblCeilingPaintColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClicktoCalculate
            // 
            this.btnClicktoCalculate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClicktoCalculate.Location = new System.Drawing.Point(511, 365);
            this.btnClicktoCalculate.Name = "btnClicktoCalculate";
            this.btnClicktoCalculate.Size = new System.Drawing.Size(266, 50);
            this.btnClicktoCalculate.TabIndex = 0;
            this.btnClicktoCalculate.Text = "Click to Calculate";
            this.btnClicktoCalculate.UseVisualStyleBackColor = true;
            this.btnClicktoCalculate.Click += new System.EventHandler(this.btnClicktoCalculate_Click);
            // 
            // lblCeilingLength
            // 
            this.lblCeilingLength.AutoSize = true;
            this.lblCeilingLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingLength.Location = new System.Drawing.Point(63, 161);
            this.lblCeilingLength.Name = "lblCeilingLength";
            this.lblCeilingLength.Size = new System.Drawing.Size(108, 18);
            this.lblCeilingLength.TabIndex = 1;
            this.lblCeilingLength.Text = "Ceiling Length";
            // 
            // txtCeilingLength
            // 
            this.txtCeilingLength.Location = new System.Drawing.Point(177, 156);
            this.txtCeilingLength.Name = "txtCeilingLength";
            this.txtCeilingLength.Size = new System.Drawing.Size(100, 23);
            this.txtCeilingLength.TabIndex = 2;
            // 
            // txtCeilingWidth
            // 
            this.txtCeilingWidth.Location = new System.Drawing.Point(177, 190);
            this.txtCeilingWidth.Name = "txtCeilingWidth";
            this.txtCeilingWidth.Size = new System.Drawing.Size(100, 23);
            this.txtCeilingWidth.TabIndex = 4;
            // 
            // lblCeilingWidth
            // 
            this.lblCeilingWidth.AutoSize = true;
            this.lblCeilingWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingWidth.Location = new System.Drawing.Point(70, 195);
            this.lblCeilingWidth.Name = "lblCeilingWidth";
            this.lblCeilingWidth.Size = new System.Drawing.Size(101, 18);
            this.lblCeilingWidth.TabIndex = 3;
            this.lblCeilingWidth.Text = "Ceiling Width";
            // 
            // txtCeilingSF
            // 
            this.txtCeilingSF.Location = new System.Drawing.Point(177, 230);
            this.txtCeilingSF.Name = "txtCeilingSF";
            this.txtCeilingSF.Size = new System.Drawing.Size(100, 23);
            this.txtCeilingSF.TabIndex = 6;
            this.txtCeilingSF.TextChanged += new System.EventHandler(this.txtCeilingSF_TextChanged);
            // 
            // lblCeilingSF
            // 
            this.lblCeilingSF.AutoSize = true;
            this.lblCeilingSF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingSF.Location = new System.Drawing.Point(89, 235);
            this.lblCeilingSF.Name = "lblCeilingSF";
            this.lblCeilingSF.Size = new System.Drawing.Size(82, 18);
            this.lblCeilingSF.TabIndex = 5;
            this.lblCeilingSF.Text = "Ceiling SF";
            this.lblCeilingSF.Click += new System.EventHandler(this.lblCeilingSF_Click);
            // 
            // txtCeilingRate
            // 
            this.txtCeilingRate.Location = new System.Drawing.Point(177, 267);
            this.txtCeilingRate.Name = "txtCeilingRate";
            this.txtCeilingRate.Size = new System.Drawing.Size(100, 23);
            this.txtCeilingRate.TabIndex = 8;
            this.txtCeilingRate.TextChanged += new System.EventHandler(this.txtCeilingRate_TextChanged);
            // 
            // lblCeilingRate
            // 
            this.lblCeilingRate.AutoSize = true;
            this.lblCeilingRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingRate.Location = new System.Drawing.Point(77, 272);
            this.lblCeilingRate.Name = "lblCeilingRate";
            this.lblCeilingRate.Size = new System.Drawing.Size(94, 18);
            this.lblCeilingRate.TabIndex = 7;
            this.lblCeilingRate.Text = "Ceiling Rate";
            this.lblCeilingRate.Click += new System.EventHandler(this.lblCeilingRate_Click);
            // 
            // txtCeilingEstimateTotal
            // 
            this.txtCeilingEstimateTotal.Location = new System.Drawing.Point(177, 314);
            this.txtCeilingEstimateTotal.Name = "txtCeilingEstimateTotal";
            this.txtCeilingEstimateTotal.Size = new System.Drawing.Size(100, 23);
            this.txtCeilingEstimateTotal.TabIndex = 10;
            this.txtCeilingEstimateTotal.TextChanged += new System.EventHandler(this.txtCeilingEstimateTotal_TextChanged);
            // 
            // lblCeilingEstimateTotal
            // 
            this.lblCeilingEstimateTotal.AutoSize = true;
            this.lblCeilingEstimateTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingEstimateTotal.Location = new System.Drawing.Point(12, 319);
            this.lblCeilingEstimateTotal.Name = "lblCeilingEstimateTotal";
            this.lblCeilingEstimateTotal.Size = new System.Drawing.Size(159, 18);
            this.lblCeilingEstimateTotal.TabIndex = 9;
            this.lblCeilingEstimateTotal.Text = "Ceiling Estimate Total";
            // 
            // lblPaintJobEstimator
            // 
            this.lblPaintJobEstimator.AutoSize = true;
            this.lblPaintJobEstimator.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaintJobEstimator.Location = new System.Drawing.Point(502, 9);
            this.lblPaintJobEstimator.Name = "lblPaintJobEstimator";
            this.lblPaintJobEstimator.Size = new System.Drawing.Size(275, 33);
            this.lblPaintJobEstimator.TabIndex = 11;
            this.lblPaintJobEstimator.Text = "Paint Job Estimator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // txtCeilngPaintColor
            // 
            this.txtCeilngPaintColor.Location = new System.Drawing.Point(177, 111);
            this.txtCeilngPaintColor.Name = "txtCeilngPaintColor";
            this.txtCeilngPaintColor.Size = new System.Drawing.Size(100, 23);
            this.txtCeilngPaintColor.TabIndex = 15;
            // 
            // lblCeilingPaintColor
            // 
            this.lblCeilingPaintColor.AutoSize = true;
            this.lblCeilingPaintColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCeilingPaintColor.Location = new System.Drawing.Point(32, 116);
            this.lblCeilingPaintColor.Name = "lblCeilingPaintColor";
            this.lblCeilingPaintColor.Size = new System.Drawing.Size(139, 18);
            this.lblCeilingPaintColor.TabIndex = 14;
            this.lblCeilingPaintColor.Text = "Ceiling Paint Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.Controls.Add(this.txtCeilngPaintColor);
            this.Controls.Add(this.lblCeilingPaintColor);
            this.Controls.Add(this.textBox1);
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
        private TextBox textBox1;
        private TextBox txtCeilngPaintColor;
        private Label lblCeilingPaintColor;
    }
}