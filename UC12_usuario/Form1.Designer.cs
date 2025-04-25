namespace UC12_usuario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCADASTRO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxCONFSENHA = new System.Windows.Forms.TextBox();
            this.comboBoxPERMISSAO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCADASTRO
            // 
            this.buttonCADASTRO.Location = new System.Drawing.Point(560, 350);
            this.buttonCADASTRO.Name = "buttonCADASTRO";
            this.buttonCADASTRO.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRO.TabIndex = 0;
            this.buttonCADASTRO.Text = "Cadastrar";
            this.buttonCADASTRO.UseVisualStyleBackColor = true;
            this.buttonCADASTRO.Click += new System.EventHandler(this.buttonCADASTRO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail para login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirme a senha";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(187, 92);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNOME.TabIndex = 5;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(187, 121);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(100, 20);
            this.textBoxEMAIL.TabIndex = 6;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(187, 149);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSENHA.TabIndex = 7;
            // 
            // textBoxCONFSENHA
            // 
            this.textBoxCONFSENHA.Location = new System.Drawing.Point(187, 175);
            this.textBoxCONFSENHA.Name = "textBoxCONFSENHA";
            this.textBoxCONFSENHA.PasswordChar = '*';
            this.textBoxCONFSENHA.Size = new System.Drawing.Size(100, 20);
            this.textBoxCONFSENHA.TabIndex = 8;
            // 
            // comboBoxPERMISSAO
            // 
            this.comboBoxPERMISSAO.FormattingEnabled = true;
            this.comboBoxPERMISSAO.Items.AddRange(new object[] {
            "Funcionário",
            "Administrador",
            "Cliente"});
            this.comboBoxPERMISSAO.Location = new System.Drawing.Point(187, 216);
            this.comboBoxPERMISSAO.Name = "comboBoxPERMISSAO";
            this.comboBoxPERMISSAO.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPERMISSAO.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPERMISSAO);
            this.Controls.Add(this.textBoxCONFSENHA);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCADASTRO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCADASTRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxCONFSENHA;
        private System.Windows.Forms.ComboBox comboBoxPERMISSAO;
    }
}

