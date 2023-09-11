namespace FinalProject_1_3
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
            lbsub1 = new Label();
            ddlmain = new ComboBox();
            lbsub2 = new Label();
            label1 = new Label();
            bttgo = new Button();
            lbsub3 = new Label();
            tbsub1 = new TextBox();
            tbsub3 = new TextBox();
            tbsub2 = new TextBox();
            SuspendLayout();
            // 
            // lbsub1
            // 
            lbsub1.AutoSize = true;
            lbsub1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbsub1.Location = new Point(57, 177);
            lbsub1.Name = "lbsub1";
            lbsub1.Size = new Size(107, 41);
            lbsub1.TabIndex = 0;
            lbsub1.Text = "lbsub1";
            // 
            // ddlmain
            // 
            ddlmain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ddlmain.FormattingEnabled = true;
            ddlmain.Items.AddRange(new object[] { "1 สี่เหลี่ยมผืนผ้า", "2 วงกลม", "3 สามเหลี่ยม", "4 สี่เหลี่ยมรูปว่าว", "5 สี่เหลี่ยมด้านขนาน" });
            ddlmain.Location = new Point(389, 31);
            ddlmain.Name = "ddlmain";
            ddlmain.Size = new Size(222, 49);
            ddlmain.TabIndex = 1;
            ddlmain.SelectedIndexChanged += ddlmain_SelectedIndexChanged;
            // 
            // lbsub2
            // 
            lbsub2.AutoSize = true;
            lbsub2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbsub2.Location = new Point(57, 267);
            lbsub2.Name = "lbsub2";
            lbsub2.Size = new Size(107, 41);
            lbsub2.TabIndex = 2;
            lbsub2.Text = "lbsub2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 34);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 3;
            label1.Text = "เลือกรูปเรขาคณิตที่ต้องการ";
            // 
            // bttgo
            // 
            bttgo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bttgo.Location = new Point(742, 190);
            bttgo.Name = "bttgo";
            bttgo.Size = new Size(294, 94);
            bttgo.TabIndex = 4;
            bttgo.Text = "คำนวณ";
            bttgo.UseVisualStyleBackColor = true;
            bttgo.Click += bttgo_Click;
            // 
            // lbsub3
            // 
            lbsub3.AutoSize = true;
            lbsub3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbsub3.Location = new Point(57, 359);
            lbsub3.Name = "lbsub3";
            lbsub3.Size = new Size(107, 41);
            lbsub3.TabIndex = 5;
            lbsub3.Text = "lbsub3";
            // 
            // tbsub1
            // 
            tbsub1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbsub1.Location = new Point(311, 177);
            tbsub1.Name = "tbsub1";
            tbsub1.Size = new Size(177, 47);
            tbsub1.TabIndex = 6;
            // 
            // tbsub3
            // 
            tbsub3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbsub3.Location = new Point(311, 353);
            tbsub3.Name = "tbsub3";
            tbsub3.Size = new Size(177, 47);
            tbsub3.TabIndex = 8;
            // 
            // tbsub2
            // 
            tbsub2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbsub2.Location = new Point(311, 267);
            tbsub2.Name = "tbsub2";
            tbsub2.Size = new Size(177, 47);
            tbsub2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 521);
            Controls.Add(tbsub2);
            Controls.Add(tbsub3);
            Controls.Add(tbsub1);
            Controls.Add(lbsub3);
            Controls.Add(bttgo);
            Controls.Add(label1);
            Controls.Add(lbsub2);
            Controls.Add(ddlmain);
            Controls.Add(lbsub1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbsub1;
        private ComboBox ddlmain;
        private Label lbsub2;
        private Label label1;
        private Button bttgo;
        private Label lbsub3;
        private TextBox tbsub1;
        private TextBox tbsub3;
        private TextBox tbsub2;
    }
}