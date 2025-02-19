namespace AppRegistroMultas
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
            this.btConsulta = new System.Windows.Forms.Button();
            this.btCadastroMulta = new System.Windows.Forms.Button();
            this.btCadastroVeiculo = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btAtualizarMulta = new System.Windows.Forms.Button();
            this.btDeletarMulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(62, 350);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(628, 52);
            this.btConsulta.TabIndex = 32;
            this.btConsulta.Text = "CONSULTA DE MULTAS";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btCadastroMulta
            // 
            this.btCadastroMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroMulta.Location = new System.Drawing.Point(62, 230);
            this.btCadastroMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastroMulta.Name = "btCadastroMulta";
            this.btCadastroMulta.Size = new System.Drawing.Size(628, 52);
            this.btCadastroMulta.TabIndex = 31;
            this.btCadastroMulta.Text = "CADASTRO DE MULTAS";
            this.btCadastroMulta.UseVisualStyleBackColor = true;
            this.btCadastroMulta.Click += new System.EventHandler(this.btCadastroMulta_Click);
            // 
            // btCadastroVeiculo
            // 
            this.btCadastroVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroVeiculo.Location = new System.Drawing.Point(62, 92);
            this.btCadastroVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastroVeiculo.Name = "btCadastroVeiculo";
            this.btCadastroVeiculo.Size = new System.Drawing.Size(628, 52);
            this.btCadastroVeiculo.TabIndex = 30;
            this.btCadastroVeiculo.Text = "CADASTRAR VEÍCULOS";
            this.btCadastroVeiculo.UseVisualStyleBackColor = true;
            this.btCadastroVeiculo.Click += new System.EventHandler(this.btCadastroVeiculo_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(62, 152);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(628, 52);
            this.btAtualizar.TabIndex = 33;
            this.btAtualizar.Text = "ATUALIZAR VEÍCULOS";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btAtualizarMulta
            // 
            this.btAtualizarMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarMulta.Location = new System.Drawing.Point(62, 290);
            this.btAtualizarMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizarMulta.Name = "btAtualizarMulta";
            this.btAtualizarMulta.Size = new System.Drawing.Size(628, 52);
            this.btAtualizarMulta.TabIndex = 34;
            this.btAtualizarMulta.Text = "ATUALIZAR MULTAS";
            this.btAtualizarMulta.UseVisualStyleBackColor = true;
            this.btAtualizarMulta.Click += new System.EventHandler(this.btAtualizarMulta_Click);
            // 
            // btDeletarMulta
            // 
            this.btDeletarMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarMulta.Location = new System.Drawing.Point(62, 410);
            this.btDeletarMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btDeletarMulta.Name = "btDeletarMulta";
            this.btDeletarMulta.Size = new System.Drawing.Size(628, 52);
            this.btDeletarMulta.TabIndex = 35;
            this.btDeletarMulta.Text = "DELETAR MULTAS";
            this.btDeletarMulta.UseVisualStyleBackColor = true;
            this.btDeletarMulta.Click += new System.EventHandler(this.btDeletarMulta_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 40);
            this.label1.TabIndex = 74;
            this.label1.Text = "APP MULTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(62, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 10);
            this.panel1.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(101, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 27);
            this.label2.TabIndex = 76;
            this.label2.Text = "Anna Isabela - 2°A Informática";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(743, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeletarMulta);
            this.Controls.Add(this.btAtualizarMulta);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btCadastroMulta);
            this.Controls.Add(this.btCadastroVeiculo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btCadastroMulta;
        private System.Windows.Forms.Button btCadastroVeiculo;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btAtualizarMulta;
        private System.Windows.Forms.Button btDeletarMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

