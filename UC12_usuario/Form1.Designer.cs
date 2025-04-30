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
            this.labelCONF = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxCONFSENHA = new System.Windows.Forms.TextBox();
            this.comboBoxPERMISSAO = new System.Windows.Forms.ComboBox();
            this.dataGridUSUARIOS = new System.Windows.Forms.DataGridView();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonALTERAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCADASTRO
            // 
            this.buttonCADASTRO.Location = new System.Drawing.Point(566, 65);
            this.buttonCADASTRO.Name = "buttonCADASTRO";
            this.buttonCADASTRO.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRO.TabIndex = 0;
            this.buttonCADASTRO.Text = "Cadastrar";
            this.buttonCADASTRO.UseVisualStyleBackColor = true;
            this.buttonCADASTRO.Click += new System.EventHandler(this.buttonCADASTRO_Click);
            // 
            // label1
            // 
            this.label1.Image = global::UC12_usuario.Properties.Resources.img_USUARIO;
            this.label1.Location = new System.Drawing.Point(136, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.Image = global::UC12_usuario.Properties.Resources.o_email;
            this.label2.Location = new System.Drawing.Point(136, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 37);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Image = global::UC12_usuario.Properties.Resources.senha;
            this.label3.Location = new System.Drawing.Point(136, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 3;
            // 
            // labelCONF
            // 
            this.labelCONF.Image = global::UC12_usuario.Properties.Resources.verificar__1_;
            this.labelCONF.Location = new System.Drawing.Point(134, 154);
            this.labelCONF.Name = "labelCONF";
            this.labelCONF.Size = new System.Drawing.Size(31, 30);
            this.labelCONF.TabIndex = 4;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(180, 65);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(223, 20);
            this.textBoxNOME.TabIndex = 5;
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(180, 91);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(223, 20);
            this.textBoxEMAIL.TabIndex = 6;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(180, 125);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(223, 20);
            this.textBoxSENHA.TabIndex = 7;
            // 
            // textBoxCONFSENHA
            // 
            this.textBoxCONFSENHA.Location = new System.Drawing.Point(180, 158);
            this.textBoxCONFSENHA.Name = "textBoxCONFSENHA";
            this.textBoxCONFSENHA.PasswordChar = '*';
            this.textBoxCONFSENHA.Size = new System.Drawing.Size(223, 20);
            this.textBoxCONFSENHA.TabIndex = 8;
            // 
            // comboBoxPERMISSAO
            // 
            this.comboBoxPERMISSAO.FormattingEnabled = true;
            this.comboBoxPERMISSAO.Items.AddRange(new object[] {
            "Funcionário",
            "Administrador",
            "Cliente"});
            this.comboBoxPERMISSAO.Location = new System.Drawing.Point(227, 209);
            this.comboBoxPERMISSAO.Name = "comboBoxPERMISSAO";
            this.comboBoxPERMISSAO.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPERMISSAO.TabIndex = 12;
            // 
            // dataGridUSUARIOS
            // 
            this.dataGridUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUSUARIOS.Location = new System.Drawing.Point(47, 256);
            this.dataGridUSUARIOS.Name = "dataGridUSUARIOS";
            this.dataGridUSUARIOS.Size = new System.Drawing.Size(644, 262);
            this.dataGridUSUARIOS.TabIndex = 13;
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.Red;
            this.buttonDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDEL.Location = new System.Drawing.Point(566, 123);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(75, 23);
            this.buttonDEL.TabIndex = 14;
            this.buttonDEL.Text = "Apagar";
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonALTERAR
            // 
            this.buttonALTERAR.Location = new System.Drawing.Point(566, 94);
            this.buttonALTERAR.Name = "buttonALTERAR";
            this.buttonALTERAR.Size = new System.Drawing.Size(75, 23);
            this.buttonALTERAR.TabIndex = 15;
            this.buttonALTERAR.Text = "Alterar";
            this.buttonALTERAR.UseVisualStyleBackColor = true;
            this.buttonALTERAR.Click += new System.EventHandler(this.buttonALTERAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 543);
            this.Controls.Add(this.buttonALTERAR);
            this.Controls.Add(this.buttonDEL);
            this.Controls.Add(this.dataGridUSUARIOS);
            this.Controls.Add(this.comboBoxPERMISSAO);
            this.Controls.Add(this.textBoxCONFSENHA);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.labelCONF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCADASTRO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCADASTRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCONF;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxCONFSENHA;
        private System.Windows.Forms.ComboBox comboBoxPERMISSAO;
        private System.Windows.Forms.DataGridView dataGridUSUARIOS;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.Button buttonALTERAR;
    }
}

