namespace project_car
{
    partial class frmcami
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcapaci = new System.Windows.Forms.TextBox();
            this.txtbau = new System.Windows.Forms.TextBox();
            this.txtcarga = new System.Windows.Forms.TextBox();
            this.txtcabine = new System.Windows.Forms.TextBox();
            this.txtrodas = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtcha = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btnexibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR CAMINHÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de carga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de cabine";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qtd de rodas";
            // 
            // txtcapaci
            // 
            this.txtcapaci.Location = new System.Drawing.Point(540, 83);
            this.txtcapaci.Name = "txtcapaci";
            this.txtcapaci.Size = new System.Drawing.Size(162, 20);
            this.txtcapaci.TabIndex = 6;
            // 
            // txtbau
            // 
            this.txtbau.Location = new System.Drawing.Point(540, 124);
            this.txtbau.Name = "txtbau";
            this.txtbau.Size = new System.Drawing.Size(162, 20);
            this.txtbau.TabIndex = 7;
            // 
            // txtcarga
            // 
            this.txtcarga.Location = new System.Drawing.Point(540, 165);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.Size = new System.Drawing.Size(162, 20);
            this.txtcarga.TabIndex = 8;
            // 
            // txtcabine
            // 
            this.txtcabine.Location = new System.Drawing.Point(540, 212);
            this.txtcabine.Name = "txtcabine";
            this.txtcabine.Size = new System.Drawing.Size(162, 20);
            this.txtcabine.TabIndex = 9;
            // 
            // txtrodas
            // 
            this.txtrodas.Location = new System.Drawing.Point(540, 254);
            this.txtrodas.Name = "txtrodas";
            this.txtrodas.Size = new System.Drawing.Size(162, 20);
            this.txtrodas.TabIndex = 10;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(58, 408);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(133, 50);
            this.btncadastrar.TabIndex = 11;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(427, 408);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(133, 50);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(611, 409);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(133, 50);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chassi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quilometragem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ano";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Placa";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(177, 83);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(162, 20);
            this.txtmarca.TabIndex = 21;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(177, 124);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(162, 20);
            this.txtmodel.TabIndex = 22;
            // 
            // txtcha
            // 
            this.txtcha.Location = new System.Drawing.Point(177, 165);
            this.txtcha.Name = "txtcha";
            this.txtcha.Size = new System.Drawing.Size(162, 20);
            this.txtcha.TabIndex = 23;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(177, 212);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(162, 20);
            this.txtkm.TabIndex = 24;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(177, 254);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(162, 20);
            this.txtcor.TabIndex = 25;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(177, 300);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(162, 20);
            this.txtano.TabIndex = 26;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(177, 342);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(162, 20);
            this.txtplaca.TabIndex = 27;
            // 
            // btnexibir
            // 
            this.btnexibir.Location = new System.Drawing.Point(240, 409);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(133, 49);
            this.btnexibir.TabIndex = 28;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // frmcami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtcha);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtrodas);
            this.Controls.Add(this.txtcabine);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.txtbau);
            this.Controls.Add(this.txtcapaci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmcami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcapaci;
        private System.Windows.Forms.TextBox txtbau;
        private System.Windows.Forms.TextBox txtcarga;
        private System.Windows.Forms.TextBox txtcabine;
        private System.Windows.Forms.TextBox txtrodas;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtcha;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btnexibir;
    }
}