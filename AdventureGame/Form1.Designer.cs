namespace AdventureGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.HPText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoldText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PotsText = new System.Windows.Forms.Label();
            this.FightBtn = new System.Windows.Forms.Button();
            this.DetailText = new System.Windows.Forms.TextBox();
            this.healthButton = new System.Windows.Forms.Button();
            this.PotBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP:";
            // 
            // HPText
            // 
            this.HPText.AutoSize = true;
            this.HPText.Location = new System.Drawing.Point(51, 9);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(13, 13);
            this.HPText.TabIndex = 1;
            this.HPText.Text = "0";
            this.HPText.Click += new System.EventHandler(this.HPText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gold:";
            // 
            // GoldText
            // 
            this.GoldText.AutoSize = true;
            this.GoldText.Location = new System.Drawing.Point(51, 26);
            this.GoldText.Name = "GoldText";
            this.GoldText.Size = new System.Drawing.Size(13, 13);
            this.GoldText.TabIndex = 3;
            this.GoldText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Health Pots:";
            // 
            // PotsText
            // 
            this.PotsText.AutoSize = true;
            this.PotsText.Location = new System.Drawing.Point(84, 48);
            this.PotsText.Name = "PotsText";
            this.PotsText.Size = new System.Drawing.Size(13, 13);
            this.PotsText.TabIndex = 5;
            this.PotsText.Text = "0";
            // 
            // FightBtn
            // 
            this.FightBtn.Location = new System.Drawing.Point(54, 400);
            this.FightBtn.Name = "FightBtn";
            this.FightBtn.Size = new System.Drawing.Size(75, 23);
            this.FightBtn.TabIndex = 6;
            this.FightBtn.Text = "Fight";
            this.FightBtn.UseVisualStyleBackColor = true;
            this.FightBtn.Click += new System.EventHandler(this.FightBtn_Click);
            // 
            // DetailText
            // 
            this.DetailText.AcceptsReturn = true;
            this.DetailText.AcceptsTab = true;
            this.DetailText.Location = new System.Drawing.Point(15, 127);
            this.DetailText.Multiline = true;
            this.DetailText.Name = "DetailText";
            this.DetailText.ReadOnly = true;
            this.DetailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailText.Size = new System.Drawing.Size(477, 248);
            this.DetailText.TabIndex = 7;
            // 
            // healthButton
            // 
            this.healthButton.Location = new System.Drawing.Point(188, 400);
            this.healthButton.Name = "healthButton";
            this.healthButton.Size = new System.Drawing.Size(75, 23);
            this.healthButton.TabIndex = 8;
            this.healthButton.Text = "Use HP";
            this.healthButton.UseVisualStyleBackColor = true;
            this.healthButton.Click += new System.EventHandler(this.healthButton_Click);
            // 
            // PotBtn
            // 
            this.PotBtn.Location = new System.Drawing.Point(312, 400);
            this.PotBtn.Name = "PotBtn";
            this.PotBtn.Size = new System.Drawing.Size(75, 23);
            this.PotBtn.TabIndex = 9;
            this.PotBtn.Text = "Buy Pot";
            this.PotBtn.UseVisualStyleBackColor = true;
            this.PotBtn.Click += new System.EventHandler(this.PotBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 484);
            this.Controls.Add(this.PotBtn);
            this.Controls.Add(this.healthButton);
            this.Controls.Add(this.DetailText);
            this.Controls.Add(this.FightBtn);
            this.Controls.Add(this.PotsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoldText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HPText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GoldText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PotsText;
        private System.Windows.Forms.Button FightBtn;
        public System.Windows.Forms.TextBox DetailText;
        private System.Windows.Forms.Button healthButton;
        private System.Windows.Forms.Button PotBtn;
    }
}

