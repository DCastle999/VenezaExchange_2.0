namespace VenexaExchangeForm
{
    partial class Broker
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
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVenda1 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbNomeAtivo = new System.Windows.Forms.TextBox();
            this.lbNomeAtivo = new System.Windows.Forms.Label();
            this.gbTipos = new System.Windows.Forms.GroupBox();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.rbCommodity = new System.Windows.Forms.RadioButton();
            this.rbAcao = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btVender = new System.Windows.Forms.Button();
            this.lbOpcao = new System.Windows.Forms.Label();
            this.lbVenda2 = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.gbTipos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.nome,
            this.qntd,
            this.valor});
            this.dgvCompra.Location = new System.Drawing.Point(25, 62);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowTemplate.Height = 25;
            this.dgvCompra.Size = new System.Drawing.Size(443, 140);
            this.dgvCompra.TabIndex = 0;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // qntd
            // 
            this.qntd.HeaderText = "Quantidade disponível";
            this.qntd.Name = "qntd";
            this.qntd.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor unitário";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvVenda.Location = new System.Drawing.Point(1040, 62);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowTemplate.Height = 25;
            this.dgvVenda.Size = new System.Drawing.Size(443, 140);
            this.dgvVenda.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade disponível";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordens de Compra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1129, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ordens de Venda";
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFechar.Location = new System.Drawing.Point(615, 575);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(283, 89);
            this.btFechar.TabIndex = 6;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veneza Exchange";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbVenda1
            // 
            this.lbVenda1.AutoSize = true;
            this.lbVenda1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVenda1.Location = new System.Drawing.Point(1198, 218);
            this.lbVenda1.Name = "lbVenda1";
            this.lbVenda1.Size = new System.Drawing.Size(255, 30);
            this.lbVenda1.TabIndex = 21;
            this.lbVenda1.Text = "Adicionar opção de venda";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdicionar.Location = new System.Drawing.Point(1245, 557);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(241, 72);
            this.btAdicionar.TabIndex = 20;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(1264, 362);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(219, 23);
            this.tbValor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1198, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(1264, 314);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(219, 23);
            this.tbQuantidade.TabIndex = 17;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuantidade.Location = new System.Drawing.Point(1143, 312);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(115, 25);
            this.lbQuantidade.TabIndex = 16;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // tbNomeAtivo
            // 
            this.tbNomeAtivo.Location = new System.Drawing.Point(1264, 261);
            this.tbNomeAtivo.Name = "tbNomeAtivo";
            this.tbNomeAtivo.Size = new System.Drawing.Size(219, 23);
            this.tbNomeAtivo.TabIndex = 15;
            // 
            // lbNomeAtivo
            // 
            this.lbNomeAtivo.AutoSize = true;
            this.lbNomeAtivo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomeAtivo.Location = new System.Drawing.Point(1118, 259);
            this.lbNomeAtivo.Name = "lbNomeAtivo";
            this.lbNomeAtivo.Size = new System.Drawing.Size(140, 25);
            this.lbNomeAtivo.TabIndex = 14;
            this.lbNomeAtivo.Text = "Nome do ativo:";
            // 
            // gbTipos
            // 
            this.gbTipos.Controls.Add(this.rbTitulo);
            this.gbTipos.Controls.Add(this.rbCommodity);
            this.gbTipos.Controls.Add(this.rbAcao);
            this.gbTipos.Location = new System.Drawing.Point(1245, 407);
            this.gbTipos.Name = "gbTipos";
            this.gbTipos.Size = new System.Drawing.Size(241, 126);
            this.gbTipos.TabIndex = 13;
            this.gbTipos.TabStop = false;
            this.gbTipos.Text = "Tipo de Ativo";
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Location = new System.Drawing.Point(46, 84);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(55, 19);
            this.rbTitulo.TabIndex = 2;
            this.rbTitulo.TabStop = true;
            this.rbTitulo.Text = "Título";
            this.rbTitulo.UseVisualStyleBackColor = true;
            // 
            // rbCommodity
            // 
            this.rbCommodity.AutoSize = true;
            this.rbCommodity.Location = new System.Drawing.Point(46, 59);
            this.rbCommodity.Name = "rbCommodity";
            this.rbCommodity.Size = new System.Drawing.Size(89, 19);
            this.rbCommodity.TabIndex = 1;
            this.rbCommodity.TabStop = true;
            this.rbCommodity.Text = "Commodity";
            this.rbCommodity.UseVisualStyleBackColor = true;
            // 
            // rbAcao
            // 
            this.rbAcao.AutoSize = true;
            this.rbAcao.Location = new System.Drawing.Point(46, 34);
            this.rbAcao.Name = "rbAcao";
            this.rbAcao.Size = new System.Drawing.Size(52, 19);
            this.rbAcao.TabIndex = 0;
            this.rbAcao.TabStop = true;
            this.rbAcao.Text = "Ação";
            this.rbAcao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Adicionar opção de compra";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(25, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 72);
            this.button1.TabIndex = 29;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 23);
            this.textBox1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(95, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Valor:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 23);
            this.textBox2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(40, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Quantidade:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 23);
            this.textBox3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nome do ativo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(25, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Ativo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Título";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(46, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Commodity";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(46, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ação";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btVender
            // 
            this.btVender.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVender.Location = new System.Drawing.Point(637, 218);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(241, 72);
            this.btVender.TabIndex = 34;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click_1);
            // 
            // lbOpcao
            // 
            this.lbOpcao.AutoSize = true;
            this.lbOpcao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOpcao.Location = new System.Drawing.Point(584, 172);
            this.lbOpcao.Name = "lbOpcao";
            this.lbOpcao.Size = new System.Drawing.Size(181, 21);
            this.lbOpcao.TabIndex = 33;
            this.lbOpcao.Text = "Digite a opção desejada: ";
            // 
            // lbVenda2
            // 
            this.lbVenda2.AutoSize = true;
            this.lbVenda2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVenda2.Location = new System.Drawing.Point(604, 127);
            this.lbVenda2.Name = "lbVenda2";
            this.lbVenda2.Size = new System.Drawing.Size(253, 30);
            this.lbVenda2.TabIndex = 32;
            this.lbVenda2.Text = "Vender para opção aberta";
            // 
            // btComprar
            // 
            this.btComprar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btComprar.Location = new System.Drawing.Point(637, 432);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(241, 72);
            this.btComprar.TabIndex = 38;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(584, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Digite a opção desejada: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(604, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 30);
            this.label10.TabIndex = 35;
            this.label10.Text = "Compra de opção aberta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(760, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 23);
            this.comboBox1.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(759, 389);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 23);
            this.comboBox2.TabIndex = 40;
            // 
            // Broker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 676);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.lbOpcao);
            this.Controls.Add(this.lbVenda2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbVenda1);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.tbNomeAtivo);
            this.Controls.Add(this.lbNomeAtivo);
            this.Controls.Add(this.gbTipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.dgvCompra);
            this.Name = "Broker";
            this.Text = "Broker";
            this.Load += new System.EventHandler(this.Broker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.gbTipos.ResumeLayout(false);
            this.gbTipos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCompra;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn qntd;
        private DataGridViewTextBoxColumn valor;
        private DataGridView dgvVenda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label2;
        private Label label3;
        private Button btFechar;
        private Label label1;
        private Label lbVenda1;
        private Button btAdicionar;
        private TextBox tbValor;
        private Label label4;
        private TextBox tbQuantidade;
        private Label lbQuantidade;
        private TextBox tbNomeAtivo;
        private Label lbNomeAtivo;
        private GroupBox gbTipos;
        private RadioButton rbTitulo;
        private RadioButton rbCommodity;
        private RadioButton rbAcao;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button btVender;
        private Label lbOpcao;
        private Label lbVenda2;
        private Button btComprar;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}