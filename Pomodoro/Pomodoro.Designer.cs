namespace Pomodoro
{
    partial class Pomodoro
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.countdown_text = new System.Windows.Forms.Label();
            this.countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.start_pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(288, 205);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // countdown_text
            // 
            this.countdown_text.AutoSize = true;
            this.countdown_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown_text.Location = new System.Drawing.Point(78, 33);
            this.countdown_text.Name = "countdown_text";
            this.countdown_text.Size = new System.Drawing.Size(119, 46);
            this.countdown_text.TabIndex = 2;
            this.countdown_text.Text = "25:00";
            // 
            // start_pause
            // 
            this.start_pause.Location = new System.Drawing.Point(52, 82);
            this.start_pause.Name = "start_pause";
            this.start_pause.Size = new System.Drawing.Size(75, 23);
            this.start_pause.TabIndex = 3;
            this.start_pause.Text = "Start";
            this.start_pause.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(134, 82);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start_pause);
            this.Controls.Add(this.countdown_text);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label countdown_text;
        private System.Windows.Forms.Timer countdown_timer;
        private System.Windows.Forms.Button start_pause;
        private System.Windows.Forms.Button reset;
    }
}

