namespace WinFormsApp1
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
            ListaCalculo = new ListBox();
            q = new Label();
            label1 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            label2 = new Label();
            chkSoma = new RadioButton();
            chkSubtracao = new RadioButton();
            chkDivisao = new RadioButton();
            chkMult = new RadioButton();
            btnCauc = new Button();
            BtnLimpar = new Button();
            SuspendLayout();
            // 
            // ListaCalculo
            // 
            ListaCalculo.FormattingEnabled = true;
            ListaCalculo.ItemHeight = 15;
            ListaCalculo.Location = new Point(30, 342);
            ListaCalculo.Name = "ListaCalculo";
            ListaCalculo.Size = new Size(218, 169);
            ListaCalculo.TabIndex = 0;
            // 
            // q
            // 
            q.AutoSize = true;
            q.Location = new Point(30, 45);
            q.Name = "q";
            q.Size = new Size(63, 15);
            q.TabIndex = 1;
            q.Text = "Numero 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 94);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero 2:";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(99, 42);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(99, 86);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 149);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 5;
            label2.Text = "Selecione a operação";
            // 
            // chkSoma
            // 
            chkSoma.AutoSize = true;
            chkSoma.Location = new Point(30, 178);
            chkSoma.Name = "chkSoma";
            chkSoma.Size = new Size(55, 19);
            chkSoma.TabIndex = 6;
            chkSoma.TabStop = true;
            chkSoma.Text = "Soma";
            chkSoma.UseVisualStyleBackColor = true;
            // 
            // chkSubtracao
            // 
            chkSubtracao.AutoSize = true;
            chkSubtracao.Location = new Point(30, 203);
            chkSubtracao.Name = "chkSubtracao";
            chkSubtracao.Size = new Size(78, 19);
            chkSubtracao.TabIndex = 7;
            chkSubtracao.TabStop = true;
            chkSubtracao.Text = "Subtração";
            chkSubtracao.UseVisualStyleBackColor = true;
            // 
            // chkDivisao
            // 
            chkDivisao.AutoSize = true;
            chkDivisao.Location = new Point(30, 228);
            chkDivisao.Name = "chkDivisao";
            chkDivisao.Size = new Size(63, 19);
            chkDivisao.TabIndex = 8;
            chkDivisao.TabStop = true;
            chkDivisao.Text = "Divisão";
            chkDivisao.UseVisualStyleBackColor = true;
            // 
            // chkMult
            // 
            chkMult.AutoSize = true;
            chkMult.Location = new Point(30, 253);
            chkMult.Name = "chkMult";
            chkMult.Size = new Size(97, 19);
            chkMult.TabIndex = 9;
            chkMult.TabStop = true;
            chkMult.Text = "Multiplicação";
            chkMult.UseVisualStyleBackColor = true;
            // 
            // btnCauc
            // 
            btnCauc.Location = new Point(30, 284);
            btnCauc.Name = "btnCauc";
            btnCauc.Size = new Size(218, 23);
            btnCauc.TabIndex = 10;
            btnCauc.Text = "Caucular";
            btnCauc.UseVisualStyleBackColor = true;
            btnCauc.Click += btnCauc_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(30, 313);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(218, 23);
            BtnLimpar.TabIndex = 11;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(281, 523);
            Controls.Add(BtnLimpar);
            Controls.Add(btnCauc);
            Controls.Add(chkMult);
            Controls.Add(chkDivisao);
            Controls.Add(chkSubtracao);
            Controls.Add(chkSoma);
            Controls.Add(label2);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label1);
            Controls.Add(q);
            Controls.Add(ListaCalculo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListaCalculo;
        private Label q;
        private Label label1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label label2;
        private RadioButton chkSoma;
        private RadioButton chkSubtracao;
        private RadioButton chkDivisao;
        private RadioButton chkMult;
        private Button btnCauc;
        private Button BtnLimpar;
    }
}
