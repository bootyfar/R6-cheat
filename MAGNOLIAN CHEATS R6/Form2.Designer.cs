namespace MAGNOLIAN_CHEATS_R6
{
    partial class Form2
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
            menu = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.Location = new Point(12, 9);
            menu.Name = "menu";
            menu.Size = new Size(173, 65);
            menu.TabIndex = 0;
            menu.Text = "MENU";
            menu.Click += menu_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 102);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Triggerbot";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 127);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Auto-Fire";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "[+]2d Radar";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 277);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(84, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Shared ESP";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 252);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(97, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Stream-Proof";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(12, 227);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(87, 19);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Anti-Detect";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(12, 202);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(73, 19);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "Anti-Ban";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(12, 177);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(78, 19);
            checkBox8.TabIndex = 8;
            checkBox8.Text = "Rapid Fire";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(12, 152);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(93, 19);
            checkBox9.TabIndex = 9;
            checkBox9.Text = "Auto-Reload";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 40, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox9);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(menu);
            ForeColor = Color.Aqua;
            Name = "Form2";
            Text = "DEV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menu;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
    }
}