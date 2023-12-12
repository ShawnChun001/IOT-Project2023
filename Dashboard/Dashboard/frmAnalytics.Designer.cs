namespace Dashboard
{
    partial class frmAnalytics
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLightValue = new System.Windows.Forms.Label();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            this.lblWaterValue = new System.Windows.Forms.Label();
            this.lblSoundValue = new System.Windows.Forms.Label();
            this.tbTempValue = new System.Windows.Forms.TextBox();
            this.tbLightValue = new System.Windows.Forms.TextBox();
            this.tbWaterValue = new System.Windows.Forms.TextBox();
            this.tbSoundValue = new System.Windows.Forms.TextBox();
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "User and Download Analytics Here";
            // 
            // lblLightValue
            // 
            this.lblLightValue.AutoSize = true;
            this.lblLightValue.Location = new System.Drawing.Point(139, 186);
            this.lblLightValue.Name = "lblLightValue";
            this.lblLightValue.Size = new System.Drawing.Size(83, 17);
            this.lblLightValue.TabIndex = 1;
            this.lblLightValue.Text = "Light Value:";
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.AutoSize = true;
            this.lblTemperatureValue.Location = new System.Drawing.Point(88, 120);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(134, 17);
            this.lblTemperatureValue.TabIndex = 2;
            this.lblTemperatureValue.Text = "Temperature Value:";
            // 
            // lblWaterValue
            // 
            this.lblWaterValue.AutoSize = true;
            this.lblWaterValue.Location = new System.Drawing.Point(492, 117);
            this.lblWaterValue.Name = "lblWaterValue";
            this.lblWaterValue.Size = new System.Drawing.Size(90, 17);
            this.lblWaterValue.TabIndex = 3;
            this.lblWaterValue.Text = "Water Value:";
            // 
            // lblSoundValue
            // 
            this.lblSoundValue.AutoSize = true;
            this.lblSoundValue.Location = new System.Drawing.Point(492, 185);
            this.lblSoundValue.Name = "lblSoundValue";
            this.lblSoundValue.Size = new System.Drawing.Size(93, 17);
            this.lblSoundValue.TabIndex = 4;
            this.lblSoundValue.Text = "Sound Value:";
            // 
            // tbTempValue
            // 
            this.tbTempValue.Location = new System.Drawing.Point(228, 117);
            this.tbTempValue.Name = "tbTempValue";
            this.tbTempValue.ReadOnly = true;
            this.tbTempValue.Size = new System.Drawing.Size(130, 22);
            this.tbTempValue.TabIndex = 5;
            // 
            // tbLightValue
            // 
            this.tbLightValue.Location = new System.Drawing.Point(228, 182);
            this.tbLightValue.Name = "tbLightValue";
            this.tbLightValue.ReadOnly = true;
            this.tbLightValue.Size = new System.Drawing.Size(130, 22);
            this.tbLightValue.TabIndex = 6;
            // 
            // tbWaterValue
            // 
            this.tbWaterValue.Location = new System.Drawing.Point(588, 117);
            this.tbWaterValue.Name = "tbWaterValue";
            this.tbWaterValue.ReadOnly = true;
            this.tbWaterValue.Size = new System.Drawing.Size(130, 22);
            this.tbWaterValue.TabIndex = 7;
            // 
            // tbSoundValue
            // 
            this.tbSoundValue.Location = new System.Drawing.Point(591, 180);
            this.tbSoundValue.Name = "tbSoundValue";
            this.tbSoundValue.ReadOnly = true;
            this.tbSoundValue.Size = new System.Drawing.Size(130, 22);
            this.tbSoundValue.TabIndex = 8;
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.ItemHeight = 16;
            this.lbDataComms.Location = new System.Drawing.Point(91, 243);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(828, 180);
            this.lbDataComms.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(757, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 94);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1147, 583);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbDataComms);
            this.Controls.Add(this.tbSoundValue);
            this.Controls.Add(this.tbWaterValue);
            this.Controls.Add(this.tbLightValue);
            this.Controls.Add(this.tbTempValue);
            this.Controls.Add(this.lblSoundValue);
            this.Controls.Add(this.lblWaterValue);
            this.Controls.Add(this.lblTemperatureValue);
            this.Controls.Add(this.lblLightValue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnalytics";
            this.Load += new System.EventHandler(this.frmAnalytics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLightValue;
        private System.Windows.Forms.Label lblTemperatureValue;
        private System.Windows.Forms.Label lblWaterValue;
        private System.Windows.Forms.Label lblSoundValue;
        private System.Windows.Forms.TextBox tbTempValue;
        private System.Windows.Forms.TextBox tbLightValue;
        private System.Windows.Forms.TextBox tbWaterValue;
        private System.Windows.Forms.TextBox tbSoundValue;
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Button btnClear;
    }
}