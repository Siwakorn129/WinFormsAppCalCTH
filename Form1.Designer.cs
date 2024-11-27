namespace WinFormsAppCalCTH
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
            label1 = new Label();
            txtRadius = new TextBox();
            btnCircleArea = new Button();
            label2 = new Label();
            txtHeight = new TextBox();
            label3 = new Label();
            txtBase = new TextBox();
            btnTriangleArea = new Button();
            btnHexagonArea = new Button();
            label4 = new Label();
            txtHexagonWidht = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblResult = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(20, 88);
            label1.Name = "label1";
            label1.Size = new Size(65, 41);
            label1.TabIndex = 0;
            label1.Text = "รัศมี";
            // 
            // txtRadius
            // 
            txtRadius.Font = new Font("Segoe UI", 18F);
            txtRadius.Location = new Point(127, 85);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(144, 47);
            txtRadius.TabIndex = 1;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Font = new Font("Segoe UI", 18F);
            btnCircleArea.Location = new Point(485, 77);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(253, 96);
            btnCircleArea.TabIndex = 2;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 40);
            label2.TabIndex = 3;
            label2.Text = "ความสูง";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            txtHeight.Location = new Point(229, 53);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 47);
            txtHeight.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label3.Location = new Point(20, 127);
            label3.Name = "label3";
            label3.Size = new Size(138, 40);
            label3.TabIndex = 5;
            label3.Text = "ความยาวฐาน";
            // 
            // txtBase
            // 
            txtBase.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            txtBase.Location = new Point(229, 124);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 47);
            txtBase.TabIndex = 6;
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            btnTriangleArea.Location = new Point(467, 68);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(300, 103);
            btnTriangleArea.TabIndex = 7;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Font = new Font("TH SarabunPSK", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHexagonArea.Location = new Point(447, 61);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(315, 80);
            btnHexagonArea.TabIndex = 8;
            btnHexagonArea.Text = "คำนวณพื้นที่หกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH SarabunPSK", 18F, FontStyle.Bold);
            label4.Location = new Point(21, 78);
            label4.Name = "label4";
            label4.Size = new Size(132, 40);
            label4.TabIndex = 9;
            label4.Text = "ความยาวฐาน";
            // 
            // txtHexagonWidht
            // 
            txtHexagonWidht.Font = new Font("TH SarabunPSK", 18F, FontStyle.Bold);
            txtHexagonWidht.Location = new Point(214, 78);
            txtHexagonWidht.Name = "txtHexagonWidht";
            txtHexagonWidht.Size = new Size(125, 47);
            txtHexagonWidht.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightYellow;
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            groupBox1.Location = new Point(56, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 214);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Pink;
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtBase);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(56, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 240);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PaleGreen;
            groupBox3.Controls.Add(txtHexagonWidht);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Font = new Font("TH SarabunPSK", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(55, 597);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(814, 205);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightSkyBlue;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("TH SarabunPSK", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(923, 211);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(452, 310);
            lblResult.TabIndex = 15;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label6.Location = new Point(1040, 158);
            label6.Name = "label6";
            label6.Size = new Size(190, 40);
            label6.TabIndex = 16;
            label6.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1408, 857);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "WinFormAppCal";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadius;
        private Button btnCircleArea;
        private Label label2;
        private TextBox txtHeight;
        private Label label3;
        private TextBox txtBase;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private Label label4;
        private TextBox txtHexagonWidht;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResult;
        private Label label6;
    }
}
