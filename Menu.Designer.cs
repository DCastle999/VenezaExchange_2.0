namespace VenexaExchangeForm
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btCompra = new System.Windows.Forms.Button();
            this.btVender = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCompra
            // 
            this.btCompra.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCompra.Location = new System.Drawing.Point(31, 31);
            this.btCompra.Name = "btCompra";
            this.btCompra.Size = new System.Drawing.Size(227, 175);
            this.btCompra.TabIndex = 0;
            this.btCompra.Text = "Negocie a compra de ativos";
            this.btCompra.UseVisualStyleBackColor = true;
            this.btCompra.Click += new System.EventHandler(this.btCompra_Click);
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVender.Location = new System.Drawing.Point(31, 34);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(227, 175);
            this.btVender.TabIndex = 1;
            this.btVender.Text = "Negocie a venda de ativos";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(730, 448);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(58, 51);
            this.btSair.TabIndex = 25;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(217, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 96);
            this.label7.TabIndex = 33;
            this.label7.Text = "Bem-Vindo(a) à\r\nVeneza Exchange";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btCompra);
            this.panel1.Location = new System.Drawing.Point(65, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 234);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btVender);
            this.panel2.Location = new System.Drawing.Point(443, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 234);
            this.panel2.TabIndex = 35;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCompra;
        private Button btVender;
        private Button btSair;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
    }
}