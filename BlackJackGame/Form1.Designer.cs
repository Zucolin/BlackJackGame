namespace BlackJackGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ganhou = new System.Windows.Forms.Label();
            this.resetbutton = new System.Windows.Forms.Button();
            this.perdeu1 = new System.Windows.Forms.Label();
            this.perdeu2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(278, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "BLACKJACK";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(228, 259);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(87, 95);
            this.num1.TabIndex = 5;
            this.num1.Text = "0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(936, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 59);
            this.button3.TabIndex = 7;
            this.button3.Text = "Parar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(755, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 59);
            this.button4.TabIndex = 6;
            this.button4.Text = "Continuar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(892, 259);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(87, 95);
            this.num2.TabIndex = 8;
            this.num2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(173, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jogador 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(832, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 58);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jogador 2";
            // 
            // ganhou
            // 
            this.ganhou.AutoSize = true;
            this.ganhou.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganhou.Location = new System.Drawing.Point(262, 259);
            this.ganhou.Name = "ganhou";
            this.ganhou.Size = new System.Drawing.Size(654, 95);
            this.ganhou.TabIndex = 11;
            this.ganhou.Text = "Usuario Ganhou";
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(515, 433);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(175, 59);
            this.resetbutton.TabIndex = 12;
            this.resetbutton.Text = "Jogar Novamente";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // perdeu1
            // 
            this.perdeu1.AutoSize = true;
            this.perdeu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdeu1.ForeColor = System.Drawing.Color.Red;
            this.perdeu1.Location = new System.Drawing.Point(210, 199);
            this.perdeu1.Name = "perdeu1";
            this.perdeu1.Size = new System.Drawing.Size(90, 29);
            this.perdeu1.TabIndex = 13;
            this.perdeu1.Text = "perdeu";
            this.perdeu1.Visible = false;
            // 
            // perdeu2
            // 
            this.perdeu2.AutoSize = true;
            this.perdeu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdeu2.ForeColor = System.Drawing.Color.Red;
            this.perdeu2.Location = new System.Drawing.Point(889, 199);
            this.perdeu2.Name = "perdeu2";
            this.perdeu2.Size = new System.Drawing.Size(90, 29);
            this.perdeu2.TabIndex = 14;
            this.perdeu2.Text = "perdeu";
            this.perdeu2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 586);
            this.Controls.Add(this.perdeu2);
            this.Controls.Add(this.perdeu1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.ganhou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ganhou;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label perdeu1;
        private System.Windows.Forms.Label perdeu2;
    }
}

