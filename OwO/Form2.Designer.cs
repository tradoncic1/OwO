namespace OwO
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
            this.inputStr = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.triggerBtn = new System.Windows.Forms.RadioButton();
            this.emojiBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // inputStr
            // 
            this.inputStr.Font = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStr.Location = new System.Drawing.Point(12, 107);
            this.inputStr.Name = "inputStr";
            this.inputStr.Size = new System.Drawing.Size(269, 29);
            this.inputStr.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(86, 154);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(116, 43);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input";
            // 
            // triggerBtn
            // 
            this.triggerBtn.AutoSize = true;
            this.triggerBtn.BackColor = System.Drawing.Color.Transparent;
            this.triggerBtn.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerBtn.Location = new System.Drawing.Point(16, 46);
            this.triggerBtn.Name = "triggerBtn";
            this.triggerBtn.Size = new System.Drawing.Size(72, 20);
            this.triggerBtn.TabIndex = 5;
            this.triggerBtn.TabStop = true;
            this.triggerBtn.Text = "Trigger";
            this.triggerBtn.UseVisualStyleBackColor = false;
            // 
            // emojiBtn
            // 
            this.emojiBtn.AutoSize = true;
            this.emojiBtn.BackColor = System.Drawing.Color.Transparent;
            this.emojiBtn.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emojiBtn.Location = new System.Drawing.Point(146, 46);
            this.emojiBtn.Name = "emojiBtn";
            this.emojiBtn.Size = new System.Drawing.Size(62, 20);
            this.emojiBtn.TabIndex = 6;
            this.emojiBtn.TabStop = true;
            this.emojiBtn.Text = "Emoji";
            this.emojiBtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OwO.Properties.Resources.large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(293, 209);
            this.Controls.Add(this.emojiBtn);
            this.Controls.Add(this.triggerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.inputStr);
            this.Name = "Form2";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputStr;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton triggerBtn;
        private System.Windows.Forms.RadioButton emojiBtn;
    }
}