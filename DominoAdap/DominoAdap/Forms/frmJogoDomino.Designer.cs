namespace DominoAdap.Forms
{
    partial class frmJogoDomino
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
            this.lsbJogador1 = new System.Windows.Forms.ListBox();
            this.lsbJogador2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lsbDomino = new System.Windows.Forms.ListBox();
            this.btnPassar = new System.Windows.Forms.Button();
            this.lsbTabuleiro = new System.Windows.Forms.ListBox();
            this.lsbRegras = new System.Windows.Forms.ListBox();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbJogador1
            // 
            this.lsbJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbJogador1.FormattingEnabled = true;
            this.lsbJogador1.ItemHeight = 25;
            this.lsbJogador1.Location = new System.Drawing.Point(37, 549);
            this.lsbJogador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbJogador1.Name = "lsbJogador1";
            this.lsbJogador1.Size = new System.Drawing.Size(159, 179);
            this.lsbJogador1.TabIndex = 0;
            this.lsbJogador1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsbJogador1_DrawItem);
            // 
            // lsbJogador2
            // 
            this.lsbJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbJogador2.FormattingEnabled = true;
            this.lsbJogador2.ItemHeight = 25;
            this.lsbJogador2.Location = new System.Drawing.Point(1029, 501);
            this.lsbJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbJogador2.Name = "lsbJogador2";
            this.lsbJogador2.Size = new System.Drawing.Size(159, 179);
            this.lsbJogador2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbDomino
            // 
            this.lsbDomino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDomino.FormattingEnabled = true;
            this.lsbDomino.HorizontalScrollbar = true;
            this.lsbDomino.ItemHeight = 25;
            this.lsbDomino.Location = new System.Drawing.Point(113, 49);
            this.lsbDomino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbDomino.MultiColumn = true;
            this.lsbDomino.Name = "lsbDomino";
            this.lsbDomino.Size = new System.Drawing.Size(875, 29);
            this.lsbDomino.TabIndex = 3;
            // 
            // btnPassar
            // 
            this.btnPassar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassar.Location = new System.Drawing.Point(220, 553);
            this.btnPassar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPassar.Name = "btnPassar";
            this.btnPassar.Size = new System.Drawing.Size(129, 39);
            this.btnPassar.TabIndex = 4;
            this.btnPassar.Text = "Passar";
            this.btnPassar.UseVisualStyleBackColor = true;
            this.btnPassar.Click += new System.EventHandler(this.btnPassar_Click);
            // 
            // lsbTabuleiro
            // 
            this.lsbTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTabuleiro.FormattingEnabled = true;
            this.lsbTabuleiro.ItemHeight = 25;
            this.lsbTabuleiro.Location = new System.Drawing.Point(377, 101);
            this.lsbTabuleiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbTabuleiro.Name = "lsbTabuleiro";
            this.lsbTabuleiro.Size = new System.Drawing.Size(509, 604);
            this.lsbTabuleiro.TabIndex = 5;
            // 
            // lsbRegras
            // 
            this.lsbRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbRegras.FormattingEnabled = true;
            this.lsbRegras.ItemHeight = 25;
            this.lsbRegras.Location = new System.Drawing.Point(1068, 69);
            this.lsbRegras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbRegras.Name = "lsbRegras";
            this.lsbRegras.Size = new System.Drawing.Size(159, 179);
            this.lsbRegras.TabIndex = 6;
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquerda.Location = new System.Drawing.Point(220, 598);
            this.btnEsquerda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(129, 39);
            this.btnEsquerda.TabIndex = 8;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireita.Location = new System.Drawing.Point(220, 644);
            this.btnDireita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(129, 39);
            this.btnDireita.TabIndex = 9;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(220, 689);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(129, 39);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // frmJogoDomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 793);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lsbRegras);
            this.Controls.Add(this.lsbTabuleiro);
            this.Controls.Add(this.btnPassar);
            this.Controls.Add(this.lsbDomino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbJogador2);
            this.Controls.Add(this.lsbJogador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmJogoDomino";
            this.Text = "frmJogoDomino";
            this.Load += new System.EventHandler(this.frmJogoDomino_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbJogador1;
        private System.Windows.Forms.ListBox lsbJogador2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbDomino;
        private System.Windows.Forms.Button btnPassar;
        private System.Windows.Forms.ListBox lsbTabuleiro;
        private System.Windows.Forms.ListBox lsbRegras;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnComprar;
    }
}