namespace DominoAdap.Forms
{
    partial class frmDomino
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
            this.lsbRegras = new System.Windows.Forms.ListBox();
            this.lsbJogadorA = new System.Windows.Forms.ListBox();
            this.lsbTabuleiro = new System.Windows.Forms.ListBox();
            this.lsbJogadorB = new System.Windows.Forms.ListBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInciar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbRegras
            // 
            this.lsbRegras.FormattingEnabled = true;
            this.lsbRegras.Location = new System.Drawing.Point(836, 31);
            this.lsbRegras.Name = "lsbRegras";
            this.lsbRegras.Size = new System.Drawing.Size(120, 95);
            this.lsbRegras.TabIndex = 0;
            // 
            // lsbJogadorA
            // 
            this.lsbJogadorA.FormattingEnabled = true;
            this.lsbJogadorA.Location = new System.Drawing.Point(12, 286);
            this.lsbJogadorA.Name = "lsbJogadorA";
            this.lsbJogadorA.Size = new System.Drawing.Size(186, 199);
            this.lsbJogadorA.TabIndex = 1;
            // 
            // lsbTabuleiro
            // 
            this.lsbTabuleiro.FormattingEnabled = true;
            this.lsbTabuleiro.Location = new System.Drawing.Point(352, 43);
            this.lsbTabuleiro.Name = "lsbTabuleiro";
            this.lsbTabuleiro.Size = new System.Drawing.Size(186, 199);
            this.lsbTabuleiro.TabIndex = 2;
            // 
            // lsbJogadorB
            // 
            this.lsbJogadorB.FormattingEnabled = true;
            this.lsbJogadorB.Location = new System.Drawing.Point(770, 286);
            this.lsbJogadorB.Name = "lsbJogadorB";
            this.lsbJogadorB.Size = new System.Drawing.Size(186, 199);
            this.lsbJogadorB.TabIndex = 3;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(332, 362);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(75, 23);
            this.btnRealizar.TabIndex = 4;
            this.btnRealizar.Text = "Jogar";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // cmbAcao
            // 
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(205, 364);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(121, 21);
            this.cmbAcao.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInciar});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmInciar
            // 
            this.tsmInciar.Name = "tsmInciar";
            this.tsmInciar.Size = new System.Drawing.Size(109, 22);
            this.tsmInciar.Text = "Iniciar ";
            this.tsmInciar.Click += new System.EventHandler(this.tsmInciar_Click);
            // 
            // frmDomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 488);
            this.Controls.Add(this.cmbAcao);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.lsbJogadorB);
            this.Controls.Add(this.lsbTabuleiro);
            this.Controls.Add(this.lsbJogadorA);
            this.Controls.Add(this.lsbRegras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDomino";
            this.Text = "frmDomino";
            this.Load += new System.EventHandler(this.frmDomino_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbRegras;
        private System.Windows.Forms.ListBox lsbJogadorA;
        private System.Windows.Forms.ListBox lsbTabuleiro;
        private System.Windows.Forms.ListBox lsbJogadorB;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmInciar;
    }
}