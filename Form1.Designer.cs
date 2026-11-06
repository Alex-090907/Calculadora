namespace Calculadora
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
            panelPantalla = new Panel();
            txtPantalla = new TextBox();
            panelBotones = new Panel();
            btnAC = new Button();
            btnIgual = new Button();
            btnPunto = new Button();
            btn0 = new Button();
            btnSumar = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnC = new Button();
            BtnRestar = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnRaiz = new Button();
            btnMultiplicar = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnPorcentaje = new Button();
            btnDividir = new Button();
            btnMmas = new Button();
            btnMmenos = new Button();
            btnMRC = new Button();
            btnOff = new Button();
            panelPantalla.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelPantalla
            // 
            panelPantalla.Controls.Add(txtPantalla);
            panelPantalla.Location = new Point(12, 34);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(579, 150);
            panelPantalla.TabIndex = 0;
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(0, 25);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(579, 96);
            txtPantalla.TabIndex = 0;
            txtPantalla.Text = "0";
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnAC);
            panelBotones.Controls.Add(btnIgual);
            panelBotones.Controls.Add(btnPunto);
            panelBotones.Controls.Add(btn0);
            panelBotones.Controls.Add(btnSumar);
            panelBotones.Controls.Add(btn3);
            panelBotones.Controls.Add(btn2);
            panelBotones.Controls.Add(btn1);
            panelBotones.Controls.Add(btnC);
            panelBotones.Controls.Add(BtnRestar);
            panelBotones.Controls.Add(btn6);
            panelBotones.Controls.Add(btn5);
            panelBotones.Controls.Add(btn4);
            panelBotones.Controls.Add(btnRaiz);
            panelBotones.Controls.Add(btnMultiplicar);
            panelBotones.Controls.Add(btn9);
            panelBotones.Controls.Add(btn8);
            panelBotones.Controls.Add(btn7);
            panelBotones.Controls.Add(btnPorcentaje);
            panelBotones.Controls.Add(btnDividir);
            panelBotones.Controls.Add(btnMmas);
            panelBotones.Controls.Add(btnMmenos);
            panelBotones.Controls.Add(btnMRC);
            panelBotones.Controls.Add(btnOff);
            panelBotones.Location = new Point(12, 218);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(579, 534);
            panelBotones.TabIndex = 1;
            // 
            // btnAC
            // 
            btnAC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAC.Location = new Point(16, 422);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(104, 95);
            btnAC.TabIndex = 23;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btnAC_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIgual.Location = new Point(346, 422);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(104, 95);
            btnIgual.TabIndex = 22;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPunto.Location = new Point(236, 422);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(104, 95);
            btnPunto.TabIndex = 21;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(126, 422);
            btn0.Name = "btn0";
            btn0.Size = new Size(104, 95);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSumar.Location = new Point(456, 321);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(104, 196);
            btnSumar.TabIndex = 18;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(346, 321);
            btn3.Name = "btn3";
            btn3.Size = new Size(104, 95);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(236, 321);
            btn2.Name = "btn2";
            btn2.Size = new Size(104, 95);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(126, 321);
            btn1.Name = "btn1";
            btn1.Size = new Size(104, 95);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn0_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnC.Location = new Point(16, 321);
            btnC.Name = "btnC";
            btnC.Size = new Size(104, 95);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // BtnRestar
            // 
            BtnRestar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRestar.Location = new Point(456, 220);
            BtnRestar.Name = "BtnRestar";
            BtnRestar.Size = new Size(104, 95);
            BtnRestar.TabIndex = 14;
            BtnRestar.Text = "-";
            BtnRestar.UseVisualStyleBackColor = true;
            BtnRestar.Click += btnSumar_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(346, 220);
            btn6.Name = "btn6";
            btn6.Size = new Size(104, 95);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(236, 220);
            btn5.Name = "btn5";
            btn5.Size = new Size(104, 95);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(126, 220);
            btn4.Name = "btn4";
            btn4.Size = new Size(104, 95);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn0_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRaiz.Location = new Point(16, 220);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(104, 95);
            btnRaiz.TabIndex = 9;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(456, 119);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(104, 95);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnSumar_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(346, 119);
            btn9.Name = "btn9";
            btn9.Size = new Size(104, 95);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(236, 119);
            btn8.Name = "btn8";
            btn8.Size = new Size(104, 95);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(126, 119);
            btn7.Name = "btn7";
            btn7.Size = new Size(104, 95);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn0_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPorcentaje.Location = new Point(16, 119);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(104, 95);
            btnPorcentaje.TabIndex = 2;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = true;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDividir.Location = new Point(456, 18);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(104, 95);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnSumar_Click;
            // 
            // btnMmas
            // 
            btnMmas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMmas.Location = new Point(346, 18);
            btnMmas.Name = "btnMmas";
            btnMmas.Size = new Size(104, 95);
            btnMmas.TabIndex = 3;
            btnMmas.Text = "M+";
            btnMmas.UseVisualStyleBackColor = true;
            btnMmas.Click += btnMmas_Click;
            // 
            // btnMmenos
            // 
            btnMmenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMmenos.Location = new Point(236, 18);
            btnMmenos.Name = "btnMmenos";
            btnMmenos.Size = new Size(104, 95);
            btnMmenos.TabIndex = 2;
            btnMmenos.Text = "M-";
            btnMmenos.UseVisualStyleBackColor = true;
            btnMmenos.Click += btnMmenos_Click;
            // 
            // btnMRC
            // 
            btnMRC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMRC.Location = new Point(126, 18);
            btnMRC.Name = "btnMRC";
            btnMRC.Size = new Size(104, 95);
            btnMRC.TabIndex = 1;
            btnMRC.Text = "MRC";
            btnMRC.UseVisualStyleBackColor = true;
            btnMRC.Click += btnMRC_Click;
            // 
            // btnOff
            // 
            btnOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOff.Location = new Point(16, 18);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(104, 95);
            btnOff.TabIndex = 0;
            btnOff.Text = "OFF";
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += btnOff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(616, 777);
            Controls.Add(panelBotones);
            Controls.Add(panelPantalla);
            Name = "Form1";
            Text = "Calculadora";
            panelPantalla.ResumeLayout(false);
            panelPantalla.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPantalla;
        private TextBox txtPantalla;
        private Panel panelBotones;
        private Button btnPunto;
        private Button btn0;
        private Button btnSumar;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnC;
        private Button BtnRestar;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnRaiz;
        private Button btnMultiplicar;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnPorcentaje;
        private Button btnDividir;
        private Button btnMmas;
        private Button btnMmenos;
        private Button btnMRC;
        private Button btnOff;
        private Button btnAC;
        private Button btnIgual;
    }
}
