namespace VenexaExchangeForm
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btProx = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtconfirmarsenha = new System.Windows.Forms.TextBox();
            this.lbAssociacao = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lbLocalidade = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btProx
            // 
            this.btProx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProx.Image = ((System.Drawing.Image)(resources.GetObject("btProx.Image")));
            this.btProx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProx.Location = new System.Drawing.Point(40, 224);
            this.btProx.Name = "btProx";
            this.btProx.Size = new System.Drawing.Size(156, 61);
            this.btProx.TabIndex = 9;
            this.btProx.Text = "Cadastrar";
            this.btProx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProx.UseVisualStyleBackColor = true;
            this.btProx.Click += new System.EventHandler(this.btProx_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(473, 224);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(156, 61);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancelar";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastre-se na Veneza Exchange";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txtconfirmarsenha);
            this.panel1.Controls.Add(this.lbAssociacao);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.lbLocalidade);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Location = new System.Drawing.Point(40, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 122);
            this.panel1.TabIndex = 12;
            // 
            // txtconfirmarsenha
            // 
            this.txtconfirmarsenha.Location = new System.Drawing.Point(304, 78);
            this.txtconfirmarsenha.Name = "txtconfirmarsenha";
            this.txtconfirmarsenha.PasswordChar = '*';
            this.txtconfirmarsenha.Size = new System.Drawing.Size(140, 23);
            this.txtconfirmarsenha.TabIndex = 14;
            // 
            // lbAssociacao
            // 
            this.lbAssociacao.AutoSize = true;
            this.lbAssociacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAssociacao.Location = new System.Drawing.Point(160, 80);
            this.lbAssociacao.Name = "lbAssociacao";
            this.lbAssociacao.Size = new System.Drawing.Size(139, 21);
            this.lbAssociacao.TabIndex = 13;
            this.lbAssociacao.Text = "Confirme a senha :";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(304, 50);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(140, 23);
            this.txtsenha.TabIndex = 12;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // lbLocalidade
            // 
            this.lbLocalidade.AutoSize = true;
            this.lbLocalidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocalidade.Location = new System.Drawing.Point(160, 51);
            this.lbLocalidade.Name = "lbLocalidade";
            this.lbLocalidade.Size = new System.Drawing.Size(60, 21);
            this.lbLocalidade.TabIndex = 11;
            this.lbLocalidade.Text = "Senha :";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(304, 20);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(140, 23);
            this.txtnome.TabIndex = 10;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(160, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(75, 21);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = " Usuario :";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btProx);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btProx;
        private Button btCancel;
        private Label label1;
        private Panel panel1;
        private TextBox txtconfirmarsenha;
        private Label lbAssociacao;
        private TextBox txtsenha;
        private Label lbLocalidade;
        private TextBox txtnome;
        private Label lbNome;
    }
}