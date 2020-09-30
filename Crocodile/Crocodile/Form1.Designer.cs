namespace Crocodile
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudStrokeWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChatClients = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrokeWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(484, 427);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(313, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nudStrokeWidth
            // 
            this.nudStrokeWidth.Location = new System.Drawing.Point(234, 468);
            this.nudStrokeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStrokeWidth.Name = "nudStrokeWidth";
            this.nudStrokeWidth.Size = new System.Drawing.Size(60, 20);
            this.nudStrokeWidth.TabIndex = 10;
            this.nudStrokeWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stroke width";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(49, 465);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(95, 23);
            this.btnSetColor.TabIndex = 8;
            this.btnSetColor.Text = "Change color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(8, 458);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(30, 30);
            this.lblColor.TabIndex = 7;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(494, 464);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(246, 20);
            this.tbText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(602, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter text";
            // 
            // lbChatClients
            // 
            this.lbChatClients.FormattingEnabled = true;
            this.lbChatClients.Location = new System.Drawing.Point(495, 13);
            this.lbChatClients.Name = "lbChatClients";
            this.lbChatClients.Size = new System.Drawing.Size(346, 420);
            this.lbChatClients.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(758, 464);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 496);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbChatClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.nudStrokeWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrokeWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudStrokeWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbChatClients;
        private System.Windows.Forms.Button btnSend;
    }
}

