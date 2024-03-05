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
            groupBox1 = new GroupBox();
            btLimpar = new Button();
            btResultado = new Label();
            label4 = new Label();
            label3 = new Label();
            btDividir = new Button();
            btMultiplicar = new Button();
            btSubtrair = new Button();
            btSomar = new Button();
            txtNro2 = new TextBox();
            label2 = new Label();
            txtNro1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btLimpar);
            groupBox1.Controls.Add(btResultado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btDividir);
            groupBox1.Controls.Add(btMultiplicar);
            groupBox1.Controls.Add(btSubtrair);
            groupBox1.Controls.Add(btSomar);
            groupBox1.Controls.Add(txtNro2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNro1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(308, 111);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(94, 48);
            btLimpar.TabIndex = 12;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btResultado
            // 
            btResultado.AutoSize = true;
            btResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btResultado.Location = new Point(90, 248);
            btResultado.Name = "btResultado";
            btResultado.Size = new Size(20, 23);
            btResultado.TabIndex = 11;
            btResultado.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 259);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 248);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "Resultado:";
            // 
            // btDividir
            // 
            btDividir.Location = new Point(308, 176);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(94, 48);
            btDividir.TabIndex = 7;
            btDividir.Text = "Dividir";
            btDividir.UseVisualStyleBackColor = true;
            btDividir.Click += btDividir_Click;
            // 
            // btMultiplicar
            // 
            btMultiplicar.Location = new Point(208, 176);
            btMultiplicar.Name = "btMultiplicar";
            btMultiplicar.Size = new Size(94, 48);
            btMultiplicar.TabIndex = 6;
            btMultiplicar.Text = "Multiplicar";
            btMultiplicar.UseVisualStyleBackColor = true;
            btMultiplicar.Click += btMultiplicar_Click;
            // 
            // btSubtrair
            // 
            btSubtrair.Location = new Point(108, 176);
            btSubtrair.Name = "btSubtrair";
            btSubtrair.Size = new Size(94, 48);
            btSubtrair.TabIndex = 5;
            btSubtrair.Text = "Subtrair";
            btSubtrair.UseVisualStyleBackColor = true;
            btSubtrair.Click += btSubtrair_Click;
            // 
            // btSomar
            // 
            btSomar.Location = new Point(6, 176);
            btSomar.Name = "btSomar";
            btSomar.Size = new Size(94, 48);
            btSomar.TabIndex = 4;
            btSomar.Text = "Somar";
            btSomar.UseVisualStyleBackColor = true;
            btSomar.Click += btSomar_Click;
            // 
            // txtNro2
            // 
            txtNro2.Location = new Point(6, 122);
            txtNro2.Name = "txtNro2";
            txtNro2.Size = new Size(125, 27);
            txtNro2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Segundo Número";
            // 
            // txtNro1
            // 
            txtNro1.Location = new Point(6, 46);
            txtNro1.Name = "txtNro1";
            txtNro1.Size = new Size(125, 27);
            txtNro1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(416, 450);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNro2;
        private Label label2;
        private TextBox txtNro1;
        private Button btDividir;
        private Button btMultiplicar;
        private Button btSubtrair;
        private Button btSomar;
        private Label label4;
        private Label label3;
        private Label btResultado;
        private Button btLimpar;
    }
}
