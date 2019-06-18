namespace Calculator
{
    partial class CalculatorForm
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
            System.Windows.Forms.Button clear;
            System.Windows.Forms.Button key7;
            System.Windows.Forms.Button key8;
            System.Windows.Forms.Button key9;
            System.Windows.Forms.Button key4;
            System.Windows.Forms.Button key5;
            System.Windows.Forms.Button key6;
            System.Windows.Forms.Button key2;
            System.Windows.Forms.Button key1;
            System.Windows.Forms.Button key3;
            System.Windows.Forms.Button sign;
            System.Windows.Forms.Button key0;
            System.Windows.Forms.Button point;
            System.Windows.Forms.Button divide;
            System.Windows.Forms.Button multiply;
            System.Windows.Forms.Button minus;
            System.Windows.Forms.Button cuberoot;
            System.Windows.Forms.Button squareroot;
            System.Windows.Forms.Button inverse;
            System.Windows.Forms.Button plus;
            System.Windows.Forms.Button tangent;
            System.Windows.Forms.Button cosine;
            System.Windows.Forms.Button sine;
            System.Windows.Forms.Button equals;
            this.displayTextBox = new System.Windows.Forms.TextBox();
            clear = new System.Windows.Forms.Button();
            key7 = new System.Windows.Forms.Button();
            key8 = new System.Windows.Forms.Button();
            key9 = new System.Windows.Forms.Button();
            key4 = new System.Windows.Forms.Button();
            key5 = new System.Windows.Forms.Button();
            key6 = new System.Windows.Forms.Button();
            key2 = new System.Windows.Forms.Button();
            key1 = new System.Windows.Forms.Button();
            key3 = new System.Windows.Forms.Button();
            sign = new System.Windows.Forms.Button();
            key0 = new System.Windows.Forms.Button();
            point = new System.Windows.Forms.Button();
            divide = new System.Windows.Forms.Button();
            multiply = new System.Windows.Forms.Button();
            minus = new System.Windows.Forms.Button();
            cuberoot = new System.Windows.Forms.Button();
            squareroot = new System.Windows.Forms.Button();
            inverse = new System.Windows.Forms.Button();
            plus = new System.Windows.Forms.Button();
            tangent = new System.Windows.Forms.Button();
            cosine = new System.Windows.Forms.Button();
            sine = new System.Windows.Forms.Button();
            equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clear
            // 
            clear.BackColor = System.Drawing.Color.OrangeRed;
            clear.CausesValidation = false;
            clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clear.ForeColor = System.Drawing.Color.White;
            clear.Location = new System.Drawing.Point(13, 55);
            clear.Name = "clear";
            clear.Size = new System.Drawing.Size(46, 34);
            clear.TabIndex = 1;
            clear.TabStop = false;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += new System.EventHandler(this.ClickClearButton);
            // 
            // key7
            // 
            key7.BackColor = System.Drawing.Color.Bisque;
            key7.CausesValidation = false;
            key7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key7.ForeColor = System.Drawing.Color.Black;
            key7.Location = new System.Drawing.Point(13, 95);
            key7.Name = "key7";
            key7.Size = new System.Drawing.Size(46, 34);
            key7.TabIndex = 3;
            key7.TabStop = false;
            key7.Text = "7";
            key7.UseVisualStyleBackColor = false;
            key7.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key8
            // 
            key8.BackColor = System.Drawing.Color.Bisque;
            key8.CausesValidation = false;
            key8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key8.ForeColor = System.Drawing.Color.Black;
            key8.Location = new System.Drawing.Point(66, 95);
            key8.Name = "key8";
            key8.Size = new System.Drawing.Size(46, 34);
            key8.TabIndex = 3;
            key8.TabStop = false;
            key8.Text = "8";
            key8.UseVisualStyleBackColor = false;
            key8.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key9
            // 
            key9.BackColor = System.Drawing.Color.Bisque;
            key9.CausesValidation = false;
            key9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key9.ForeColor = System.Drawing.Color.Black;
            key9.Location = new System.Drawing.Point(117, 95);
            key9.Name = "key9";
            key9.Size = new System.Drawing.Size(46, 34);
            key9.TabIndex = 3;
            key9.TabStop = false;
            key9.Text = "9";
            key9.UseVisualStyleBackColor = false;
            key9.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key4
            // 
            key4.BackColor = System.Drawing.Color.Bisque;
            key4.CausesValidation = false;
            key4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key4.ForeColor = System.Drawing.Color.Black;
            key4.Location = new System.Drawing.Point(13, 135);
            key4.Name = "key4";
            key4.Size = new System.Drawing.Size(46, 34);
            key4.TabIndex = 3;
            key4.TabStop = false;
            key4.Tag = "";
            key4.Text = "4";
            key4.UseVisualStyleBackColor = false;
            key4.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key5
            // 
            key5.BackColor = System.Drawing.Color.Bisque;
            key5.CausesValidation = false;
            key5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key5.ForeColor = System.Drawing.Color.Black;
            key5.Location = new System.Drawing.Point(66, 135);
            key5.Name = "key5";
            key5.Size = new System.Drawing.Size(46, 34);
            key5.TabIndex = 3;
            key5.TabStop = false;
            key5.Text = "5";
            key5.UseVisualStyleBackColor = false;
            key5.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key6
            // 
            key6.BackColor = System.Drawing.Color.Bisque;
            key6.CausesValidation = false;
            key6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key6.ForeColor = System.Drawing.Color.Black;
            key6.Location = new System.Drawing.Point(118, 135);
            key6.Name = "key6";
            key6.Size = new System.Drawing.Size(46, 34);
            key6.TabIndex = 3;
            key6.TabStop = false;
            key6.Text = "6";
            key6.UseVisualStyleBackColor = false;
            key6.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key2
            // 
            key2.BackColor = System.Drawing.Color.Bisque;
            key2.CausesValidation = false;
            key2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key2.ForeColor = System.Drawing.Color.Black;
            key2.Location = new System.Drawing.Point(66, 175);
            key2.Name = "key2";
            key2.Size = new System.Drawing.Size(46, 34);
            key2.TabIndex = 3;
            key2.TabStop = false;
            key2.Tag = "";
            key2.Text = "2";
            key2.UseVisualStyleBackColor = false;
            key2.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key1
            // 
            key1.BackColor = System.Drawing.Color.Bisque;
            key1.CausesValidation = false;
            key1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key1.ForeColor = System.Drawing.Color.Black;
            key1.Location = new System.Drawing.Point(14, 175);
            key1.Name = "key1";
            key1.Size = new System.Drawing.Size(46, 34);
            key1.TabIndex = 1;
            key1.TabStop = false;
            key1.Tag = "";
            key1.Text = "1";
            key1.UseVisualStyleBackColor = false;
            key1.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key3
            // 
            key3.BackColor = System.Drawing.Color.Bisque;
            key3.CausesValidation = false;
            key3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key3.ForeColor = System.Drawing.Color.Black;
            key3.Location = new System.Drawing.Point(118, 175);
            key3.Name = "key3";
            key3.Size = new System.Drawing.Size(46, 34);
            key3.TabIndex = 3;
            key3.TabStop = false;
            key3.Tag = "";
            key3.Text = "3";
            key3.UseVisualStyleBackColor = false;
            key3.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // sign
            // 
            sign.BackColor = System.Drawing.Color.PaleTurquoise;
            sign.CausesValidation = false;
            sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sign.ForeColor = System.Drawing.Color.Black;
            sign.Location = new System.Drawing.Point(14, 215);
            sign.Name = "sign";
            sign.Size = new System.Drawing.Size(46, 34);
            sign.TabIndex = 1;
            sign.TabStop = false;
            sign.Text = "±";
            sign.UseVisualStyleBackColor = false;
            sign.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // key0
            // 
            key0.BackColor = System.Drawing.Color.Bisque;
            key0.CausesValidation = false;
            key0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            key0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            key0.ForeColor = System.Drawing.Color.Black;
            key0.Location = new System.Drawing.Point(65, 215);
            key0.Name = "key0";
            key0.Size = new System.Drawing.Size(46, 34);
            key0.TabIndex = 1;
            key0.TabStop = false;
            key0.Tag = "";
            key0.Text = "0";
            key0.UseVisualStyleBackColor = false;
            key0.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // point
            // 
            point.BackColor = System.Drawing.Color.PaleTurquoise;
            point.CausesValidation = false;
            point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            point.ForeColor = System.Drawing.Color.Black;
            point.Location = new System.Drawing.Point(118, 215);
            point.Name = "point";
            point.Size = new System.Drawing.Size(46, 34);
            point.TabIndex = 1;
            point.TabStop = false;
            point.Text = ".";
            point.UseVisualStyleBackColor = false;
            point.Click += new System.EventHandler(this.ClickDigitDecimalPointOrToggleSignButton);
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.White;
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.CausesValidation = false;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(13, 12);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ShortcutsEnabled = false;
            this.displayTextBox.Size = new System.Drawing.Size(255, 35);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TabStop = false;
            this.displayTextBox.Text = "0";
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayTextBox.WordWrap = false;
            // 
            // divide
            // 
            divide.BackColor = System.Drawing.Color.Plum;
            divide.CausesValidation = false;
            divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            divide.Location = new System.Drawing.Point(170, 95);
            divide.Name = "divide";
            divide.Size = new System.Drawing.Size(46, 34);
            divide.TabIndex = 4;
            divide.TabStop = false;
            divide.Tag = Opcodes.DivisionOperation;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // multiply
            // 
            multiply.BackColor = System.Drawing.Color.Plum;
            multiply.CausesValidation = false;
            multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            multiply.Location = new System.Drawing.Point(170, 135);
            multiply.Name = "multiply";
            multiply.Size = new System.Drawing.Size(46, 34);
            multiply.TabIndex = 4;
            multiply.TabStop = false;
            multiply.Tag = Opcodes.MultiplicationOperation;
            multiply.Text = "✕";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // minus
            // 
            minus.BackColor = System.Drawing.Color.Plum;
            minus.CausesValidation = false;
            minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            minus.Location = new System.Drawing.Point(170, 175);
            minus.Name = "minus";
            minus.Size = new System.Drawing.Size(46, 34);
            minus.TabIndex = 4;
            minus.TabStop = false;
            minus.Tag = Opcodes.SubtractionOperation;
            minus.Text = "－";
            minus.UseVisualStyleBackColor = false;
            minus.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // cuberoot
            // 
            cuberoot.BackColor = System.Drawing.Color.DeepSkyBlue;
            cuberoot.CausesValidation = false;
            cuberoot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cuberoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cuberoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuberoot.ForeColor = System.Drawing.Color.White;
            cuberoot.Location = new System.Drawing.Point(222, 135);
            cuberoot.Name = "cuberoot";
            cuberoot.Size = new System.Drawing.Size(46, 34);
            cuberoot.TabIndex = 4;
            cuberoot.TabStop = false;
            cuberoot.Tag = Opcodes.CubeRootOperation;
            cuberoot.Text = "³√";
            cuberoot.UseVisualStyleBackColor = false;
            cuberoot.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // squareroot
            // 
            squareroot.BackColor = System.Drawing.Color.DeepSkyBlue;
            squareroot.CausesValidation = false;
            squareroot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            squareroot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            squareroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            squareroot.ForeColor = System.Drawing.Color.White;
            squareroot.Location = new System.Drawing.Point(222, 95);
            squareroot.Name = "squareroot";
            squareroot.Size = new System.Drawing.Size(46, 34);
            squareroot.TabIndex = 4;
            squareroot.TabStop = false;
            squareroot.Tag = Opcodes.SquareRootOperation;
            squareroot.Text = "√";
            squareroot.UseVisualStyleBackColor = false;
            squareroot.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // inverse
            // 
            inverse.BackColor = System.Drawing.Color.DeepSkyBlue;
            inverse.CausesValidation = false;
            inverse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inverse.ForeColor = System.Drawing.Color.White;
            inverse.Location = new System.Drawing.Point(222, 55);
            inverse.Name = "inverse";
            inverse.Size = new System.Drawing.Size(46, 34);
            inverse.TabIndex = 4;
            inverse.TabStop = false;
            inverse.Tag = Opcodes.InverseOperation;
            inverse.Text = "¹/𝑥";
            inverse.UseVisualStyleBackColor = false;
            inverse.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // plus
            // 
            plus.BackColor = System.Drawing.Color.Plum;
            plus.CausesValidation = false;
            plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            plus.Location = new System.Drawing.Point(170, 215);
            plus.Name = "plus";
            plus.Size = new System.Drawing.Size(46, 34);
            plus.TabIndex = 4;
            plus.TabStop = false;
            plus.Tag = Opcodes.AdditionOperation;
            plus.Text = "＋";
            plus.UseVisualStyleBackColor = false;
            plus.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // tangent
            // 
            tangent.BackColor = System.Drawing.Color.DodgerBlue;
            tangent.CausesValidation = false;
            tangent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            tangent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tangent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tangent.ForeColor = System.Drawing.Color.White;
            tangent.Location = new System.Drawing.Point(170, 55);
            tangent.Name = "tangent";
            tangent.Size = new System.Drawing.Size(46, 34);
            tangent.TabIndex = 3;
            tangent.TabStop = false;
            tangent.Tag = Opcodes.TangentOperation;
            tangent.Text = "Tan";
            tangent.UseVisualStyleBackColor = false;
            tangent.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // cosine
            // 
            cosine.BackColor = System.Drawing.Color.DodgerBlue;
            cosine.CausesValidation = false;
            cosine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cosine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cosine.ForeColor = System.Drawing.Color.White;
            cosine.Location = new System.Drawing.Point(117, 55);
            cosine.Name = "cosine";
            cosine.Size = new System.Drawing.Size(46, 34);
            cosine.TabIndex = 3;
            cosine.TabStop = false;
            cosine.Tag = Opcodes.CosineOperation;
            cosine.Text = "Cos";
            cosine.UseVisualStyleBackColor = false;
            cosine.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // sine
            // 
            sine.BackColor = System.Drawing.Color.DodgerBlue;
            sine.CausesValidation = false;
            sine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            sine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sine.ForeColor = System.Drawing.Color.White;
            sine.Location = new System.Drawing.Point(65, 55);
            sine.Name = "sine";
            sine.Size = new System.Drawing.Size(46, 34);
            sine.TabIndex = 2;
            sine.TabStop = false;
            sine.Tag = Opcodes.SineOperation;
            sine.Text = "Sin";
            sine.UseVisualStyleBackColor = false;
            sine.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // equals
            // 
            equals.BackColor = System.Drawing.Color.LightGreen;
            equals.CausesValidation = false;
            equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equals.Location = new System.Drawing.Point(222, 175);
            equals.Name = "equals";
            equals.Size = new System.Drawing.Size(46, 74);
            equals.TabIndex = 1;
            equals.TabStop = false;
            equals.Tag = Opcodes.PerformEqualsOperation;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            equals.Click += new System.EventHandler(this.ClickOperationButton);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 262);
            this.Controls.Add(divide);
            this.Controls.Add(multiply);
            this.Controls.Add(minus);
            this.Controls.Add(cuberoot);
            this.Controls.Add(squareroot);
            this.Controls.Add(inverse);
            this.Controls.Add(plus);
            this.Controls.Add(key6);
            this.Controls.Add(key3);
            this.Controls.Add(key2);
            this.Controls.Add(key5);
            this.Controls.Add(key4);
            this.Controls.Add(key9);
            this.Controls.Add(key8);
            this.Controls.Add(key7);
            this.Controls.Add(tangent);
            this.Controls.Add(cosine);
            this.Controls.Add(sine);
            this.Controls.Add(point);
            this.Controls.Add(key0);
            this.Controls.Add(equals);
            this.Controls.Add(sign);
            this.Controls.Add(key1);
            this.Controls.Add(clear);
            this.Controls.Add(this.displayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
    }
}

