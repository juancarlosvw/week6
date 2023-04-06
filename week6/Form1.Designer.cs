namespace week6
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
            this.components = new System.ComponentModel.Container();
            this.label_wordleform1 = new System.Windows.Forms.Label();
            this.label_setguess = new System.Windows.Forms.Label();
            this.txtbox_setguess = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_wordleform1
            // 
            this.label_wordleform1.AutoSize = true;
            this.label_wordleform1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_wordleform1.Location = new System.Drawing.Point(155, 26);
            this.label_wordleform1.Name = "label_wordleform1";
            this.label_wordleform1.Size = new System.Drawing.Size(172, 35);
            this.label_wordleform1.TabIndex = 0;
            this.label_wordleform1.Text = "WORDLE";
            // 
            // label_setguess
            // 
            this.label_setguess.AutoSize = true;
            this.label_setguess.Location = new System.Drawing.Point(160, 73);
            this.label_setguess.Name = "label_setguess";
            this.label_setguess.Size = new System.Drawing.Size(167, 15);
            this.label_setguess.TabIndex = 1;
            this.label_setguess.Text = "Set How Much You Can Guess";
            // 
            // txtbox_setguess
            // 
            this.txtbox_setguess.Location = new System.Drawing.Point(185, 107);
            this.txtbox_setguess.Name = "txtbox_setguess";
            this.txtbox_setguess.Size = new System.Drawing.Size(100, 23);
            this.txtbox_setguess.TabIndex = 2;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(195, 150);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 37);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "PLAY!";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 221);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.txtbox_setguess);
            this.Controls.Add(this.label_setguess);
            this.Controls.Add(this.label_wordleform1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_wordleform1;
        private Label label_setguess;
        private TextBox txtbox_setguess;
        private Button button_play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}