namespace Calculator
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
            this.Screen1Label = new System.Windows.Forms.Label();
            this.Screen2Label = new System.Windows.Forms.Label();
            this.moduloButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.buttonHalf = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNegPos = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen1Label
            // 
            this.Screen1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Screen1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen1Label.Location = new System.Drawing.Point(12, 64);
            this.Screen1Label.Name = "Screen1Label";
            this.Screen1Label.Size = new System.Drawing.Size(431, 96);
            this.Screen1Label.TabIndex = 0;
            this.Screen1Label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Screen2Label
            // 
            this.Screen2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Screen2Label.Location = new System.Drawing.Point(22, 67);
            this.Screen2Label.Name = "Screen2Label";
            this.Screen2Label.Size = new System.Drawing.Size(417, 23);
            this.Screen2Label.TabIndex = 1;
            this.Screen2Label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Screen2Label.Click += new System.EventHandler(this.Screen2Label_Click);
            // 
            // moduloButton
            // 
            this.moduloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloButton.Location = new System.Drawing.Point(12, 180);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(102, 54);
            this.moduloButton.TabIndex = 2;
            this.moduloButton.Text = "%";
            this.moduloButton.UseVisualStyleBackColor = true;
            this.moduloButton.Click += new System.EventHandler(this.moduloButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootButton.Location = new System.Drawing.Point(123, 180);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(102, 54);
            this.rootButton.TabIndex = 3;
            this.rootButton.Text = "√ ";
            this.rootButton.UseVisualStyleBackColor = true;
            // 
            // buttonSquared
            // 
            this.buttonSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquared.Location = new System.Drawing.Point(231, 180);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(102, 54);
            this.buttonSquared.TabIndex = 4;
            this.buttonSquared.Text = "x ²";
            this.buttonSquared.UseVisualStyleBackColor = true;
            this.buttonSquared.Click += new System.EventHandler(this.buttonSquared_Click);
            // 
            // buttonHalf
            // 
            this.buttonHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHalf.Location = new System.Drawing.Point(344, 180);
            this.buttonHalf.Name = "buttonHalf";
            this.buttonHalf.Size = new System.Drawing.Size(102, 54);
            this.buttonHalf.TabIndex = 5;
            this.buttonHalf.Text = "1/x";
            this.buttonHalf.UseVisualStyleBackColor = true;
            this.buttonHalf.Click += new System.EventHandler(this.buttonHalf_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(12, 250);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(102, 54);
            this.buttonCE.TabIndex = 6;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(126, 250);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(102, 54);
            this.buttonC.TabIndex = 7;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonX
            // 
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(234, 250);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(102, 54);
            this.buttonX.TabIndex = 8;
            this.buttonX.Text = "x";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(344, 250);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(102, 54);
            this.buttonDiv.TabIndex = 9;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(126, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 54);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(234, 320);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 54);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.Location = new System.Drawing.Point(344, 319);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(102, 57);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 54);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(126, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 54);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(234, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 54);
            this.button6.TabIndex = 16;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.Location = new System.Drawing.Point(344, 396);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(102, 54);
            this.buttonSub.TabIndex = 17;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 54);
            this.button2.TabIndex = 19;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(236, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 54);
            this.button3.TabIndex = 20;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(344, 469);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 54);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonNegPos
            // 
            this.buttonNegPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegPos.Location = new System.Drawing.Point(12, 539);
            this.buttonNegPos.Name = "buttonNegPos";
            this.buttonNegPos.Size = new System.Drawing.Size(102, 54);
            this.buttonNegPos.TabIndex = 22;
            this.buttonNegPos.Text = "-+";
            this.buttonNegPos.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(126, 539);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(102, 54);
            this.button0.TabIndex = 23;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(236, 539);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(102, 54);
            this.buttonDot.TabIndex = 24;
            this.buttonDot.Tag = "";
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(344, 539);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(102, 54);
            this.buttonEqual.TabIndex = 25;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 633);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonNegPos);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonHalf);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.moduloButton);
            this.Controls.Add(this.Screen2Label);
            this.Controls.Add(this.Screen1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Screen1Label;
        private System.Windows.Forms.Label Screen2Label;
        private System.Windows.Forms.Button moduloButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button buttonHalf;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNegPos;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqual;
    }
}

