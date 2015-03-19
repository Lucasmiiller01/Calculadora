namespace WindowsFormsApplication1
{
    partial class Calculadora
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
            this.Result = new System.Windows.Forms.TextBox();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Diminuir = new System.Windows.Forms.Button();
            this.Somar = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Porcent = new System.Windows.Forms.Button();
            this.Sen = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.MaxLength = 18;
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result.Size = new System.Drawing.Size(459, 49);
            this.Result.TabIndex = 0;
            this.Result.Text = "0";
            this.Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aprovador);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(79, 190);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(60, 50);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Add);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(13, 190);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(60, 50);
            this.Seven.TabIndex = 2;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Add);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(145, 190);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(60, 50);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Add);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(13, 246);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(60, 50);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Add);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(79, 246);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(60, 50);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Add);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(145, 246);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(60, 50);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Add);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(13, 302);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(60, 50);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Add);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(79, 302);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(60, 50);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Add);
            // 
            // Tree
            // 
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree.Location = new System.Drawing.Point(145, 302);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(60, 50);
            this.Tree.TabIndex = 9;
            this.Tree.Text = "3";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Add);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(343, 302);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(126, 106);
            this.Equal.TabIndex = 10;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Total);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(13, 358);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(126, 50);
            this.Zero.TabIndex = 11;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Add);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.Location = new System.Drawing.Point(145, 358);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(60, 50);
            this.Point.TabIndex = 12;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Add);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(211, 190);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(60, 50);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(211, 246);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(60, 50);
            this.Mult.TabIndex = 14;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Diminuir
            // 
            this.Diminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diminuir.Location = new System.Drawing.Point(211, 302);
            this.Diminuir.Name = "Diminuir";
            this.Diminuir.Size = new System.Drawing.Size(60, 50);
            this.Diminuir.TabIndex = 15;
            this.Diminuir.Text = "-";
            this.Diminuir.UseVisualStyleBackColor = true;
            this.Diminuir.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Somar
            // 
            this.Somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.Location = new System.Drawing.Point(211, 358);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(60, 50);
            this.Somar.TabIndex = 16;
            this.Somar.Text = "+";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Potencia
            // 
            this.Potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potencia.Location = new System.Drawing.Point(277, 190);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(60, 50);
            this.Potencia.TabIndex = 18;
            this.Potencia.Text = "^";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Raiz
            // 
            this.Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(277, 246);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(60, 50);
            this.Raiz.TabIndex = 19;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Porcent
            // 
            this.Porcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcent.Location = new System.Drawing.Point(409, 134);
            this.Porcent.Name = "Porcent";
            this.Porcent.Size = new System.Drawing.Size(60, 50);
            this.Porcent.TabIndex = 20;
            this.Porcent.Text = "%";
            this.Porcent.UseVisualStyleBackColor = true;
            this.Porcent.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Sen
            // 
            this.Sen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sen.Location = new System.Drawing.Point(343, 134);
            this.Sen.Name = "Sen";
            this.Sen.Size = new System.Drawing.Size(60, 50);
            this.Sen.TabIndex = 21;
            this.Sen.Text = "Sen";
            this.Sen.UseVisualStyleBackColor = true;
            this.Sen.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cos.Location = new System.Drawing.Point(343, 190);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(60, 50);
            this.Cos.TabIndex = 22;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Tg
            // 
            this.Tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tg.Location = new System.Drawing.Point(343, 246);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(60, 50);
            this.Tg.TabIndex = 23;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Rest
            // 
            this.Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.Location = new System.Drawing.Point(277, 134);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(60, 50);
            this.Rest.TabIndex = 24;
            this.Rest.Text = "Resto";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(79, 134);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(126, 50);
            this.Clear.TabIndex = 25;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Reset);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "±";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Negativar);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Backspace);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(277, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 50);
            this.button6.TabIndex = 31;
            this.button6.Text = "! Re";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(277, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 32;
            this.button3.Text = "! In";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(409, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 50);
            this.button4.TabIndex = 33;
            this.button4.Text = "Fi Re";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(409, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 34;
            this.button5.Text = "Fi In";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 421);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sen);
            this.Controls.Add(this.Porcent);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.Diminuir);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Result);
            this.Name = "Calculadora";
            this.Text = "Calculadora do Emanuel/Miller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Diminuir;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Porcent;
        private System.Windows.Forms.Button Sen;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

