
namespace HospedagemDaTiaLia
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCadQuarto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovoCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadHospede = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadQuarto,
            this.tsmCadHospede,
            this.tsmCadFunc,
            this.tsmSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCadQuarto
            // 
            this.tsmCadQuarto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovoCadastro});
            this.tsmCadQuarto.Name = "tsmCadQuarto";
            this.tsmCadQuarto.Size = new System.Drawing.Size(122, 20);
            this.tsmCadQuarto.Text = "Cadastro de Quarto";
            // 
            // tsmNovoCadastro
            // 
            this.tsmNovoCadastro.Name = "tsmNovoCadastro";
            this.tsmNovoCadastro.Size = new System.Drawing.Size(153, 22);
            this.tsmNovoCadastro.Text = "Novo Cadastro";
            // 
            // tsmCadHospede
            // 
            this.tsmCadHospede.Name = "tsmCadHospede";
            this.tsmCadHospede.Size = new System.Drawing.Size(132, 20);
            this.tsmCadHospede.Text = "Cadastro de Hospede";
            // 
            // tsmCadFunc
            // 
            this.tsmCadFunc.Name = "tsmCadFunc";
            this.tsmCadFunc.Size = new System.Drawing.Size(148, 20);
            this.tsmCadFunc.Text = "Cadastro de Funcionário";
            // 
            // tsmSair
            // 
            this.tsmSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmSair.BackColor = System.Drawing.Color.Red;
            this.tsmSair.CheckOnClick = true;
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmSair.Size = new System.Drawing.Size(38, 20);
            this.tsmSair.Text = "Sair";
            this.tsmSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospedagem Da Tia Lia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadQuarto;
        private System.Windows.Forms.ToolStripMenuItem tsmCadHospede;
        private System.Windows.Forms.ToolStripMenuItem tsmCadFunc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem tsmNovoCadastro;
    }
}

