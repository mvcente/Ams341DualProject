namespace DualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbCon = new System.Windows.Forms.ComboBox();
            this.cbDec = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(107, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 17);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Type of Problem:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.cbType.Location = new System.Drawing.Point(312, 27);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 24);
            this.cbType.TabIndex = 8;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(107, 86);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(199, 17);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Number of Decision Variables:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(107, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(153, 17);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Number of Constraints:";
            // 
            // cbCon
            // 
            this.cbCon.FormattingEnabled = true;
            this.cbCon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbCon.Location = new System.Drawing.Point(312, 55);
            this.cbCon.Name = "cbCon";
            this.cbCon.Size = new System.Drawing.Size(100, 24);
            this.cbCon.TabIndex = 13;
            this.cbCon.SelectedIndexChanged += new System.EventHandler(this.CbCon_SelectedIndexChanged);
            // 
            // cbDec
            // 
            this.cbDec.FormattingEnabled = true;
            this.cbDec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbDec.Location = new System.Drawing.Point(312, 85);
            this.cbDec.Name = "cbDec";
            this.cbDec.Size = new System.Drawing.Size(100, 24);
            this.cbDec.TabIndex = 14;
            this.cbDec.SelectedIndexChanged += new System.EventHandler(this.CbDec_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Info;
            this.btnGenerate.BackgroundImage = global::DualForm.Properties.Resources.colorExplosion;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGenerate.Location = new System.Drawing.Point(110, 114);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(302, 31);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(533, 173);
            this.Controls.Add(this.cbDec);
            this.Controls.Add(this.cbCon);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primal To Dual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbType;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.ComboBox cbCon;
        internal System.Windows.Forms.ComboBox cbDec;
    }
}

