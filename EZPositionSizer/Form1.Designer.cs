namespace EZPositionSizer
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stopLoss = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_positionSize = new System.Windows.Forms.TextBox();
            this.lb_rrr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_accBalance = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.tb_takeProfitDiff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_rrr = new System.Windows.Forms.TrackBar();
            this.lb_size = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rrr)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop loss distance in pip";
            // 
            // tb_stopLoss
            // 
            this.tb_stopLoss.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stopLoss.Location = new System.Drawing.Point(180, 25);
            this.tb_stopLoss.Name = "tb_stopLoss";
            this.tb_stopLoss.Size = new System.Drawing.Size(164, 21);
            this.tb_stopLoss.TabIndex = 2;
            this.tb_stopLoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stopLoss_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position Size:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(-16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 2);
            this.label4.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 17);
            // 
            // tb_positionSize
            // 
            this.tb_positionSize.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_positionSize.Location = new System.Drawing.Point(16, 129);
            this.tb_positionSize.Name = "tb_positionSize";
            this.tb_positionSize.Size = new System.Drawing.Size(138, 21);
            this.tb_positionSize.TabIndex = 7;
            this.tb_positionSize.MouseEnter += new System.EventHandler(this.tb_positionSize_MouseEnter);
            // 
            // lb_rrr
            // 
            this.lb_rrr.AutoSize = true;
            this.lb_rrr.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rrr.Location = new System.Drawing.Point(286, 70);
            this.lb_rrr.Name = "lb_rrr";
            this.lb_rrr.Size = new System.Drawing.Size(58, 19);
            this.lb_rrr.TabIndex = 10;
            this.lb_rrr.Text = "1:1.5 R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account Balance:";
            // 
            // tb_accBalance
            // 
            this.tb_accBalance.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_accBalance.Location = new System.Drawing.Point(16, 25);
            this.tb_accBalance.Name = "tb_accBalance";
            this.tb_accBalance.Size = new System.Drawing.Size(138, 21);
            this.tb_accBalance.TabIndex = 0;
            this.tb_accBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_accBalance_KeyPress);
            // 
            // btn_calc
            // 
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calc.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(12, 213);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(137, 30);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // tb_takeProfitDiff
            // 
            this.tb_takeProfitDiff.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_takeProfitDiff.Location = new System.Drawing.Point(180, 129);
            this.tb_takeProfitDiff.Name = "tb_takeProfitDiff";
            this.tb_takeProfitDiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_takeProfitDiff.Size = new System.Drawing.Size(164, 21);
            this.tb_takeProfitDiff.TabIndex = 16;
            this.tb_takeProfitDiff.MouseEnter += new System.EventHandler(this.tb_takeProfitDiff_MouseEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(177, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Take Profit (Pip):";
            // 
            // tb_rrr
            // 
            this.tb_rrr.LargeChange = 100;
            this.tb_rrr.Location = new System.Drawing.Point(12, 70);
            this.tb_rrr.Maximum = 500;
            this.tb_rrr.Minimum = 100;
            this.tb_rrr.Name = "tb_rrr";
            this.tb_rrr.Size = new System.Drawing.Size(278, 45);
            this.tb_rrr.SmallChange = 10;
            this.tb_rrr.TabIndex = 17;
            this.tb_rrr.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_rrr.Value = 150;
            this.tb_rrr.Scroll += new System.EventHandler(this.tb_rrr_Scroll);
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_size.Location = new System.Drawing.Point(13, 153);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(28, 13);
            this.lb_size.TabIndex = 18;
            this.lb_size.Text = "###";
            this.lb_size.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_rrr);
            this.Controls.Add(this.tb_takeProfitDiff);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_accBalance);
            this.Controls.Add(this.lb_rrr);
            this.Controls.Add(this.tb_positionSize);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_stopLoss);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZ Position Sizer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rrr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stopLoss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.TextBox tb_positionSize;
        private System.Windows.Forms.Label lb_rrr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_accBalance;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox tb_takeProfitDiff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tb_rrr;
        private System.Windows.Forms.Label lb_size;
    }
}

