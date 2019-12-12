namespace prEstructurasCondicionales2
{
    partial class frclima
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttemperatura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclima = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txttemperatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Temperatura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtclima);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(19, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura:";
            // 
            // txttemperatura
            // 
            this.txttemperatura.Location = new System.Drawing.Point(20, 59);
            this.txttemperatura.Name = "txttemperatura";
            this.txttemperatura.Size = new System.Drawing.Size(116, 20);
            this.txttemperatura.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(257, 31);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(78, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(257, 72);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(78, 23);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(257, 112);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(78, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Clima:";
            // 
            // txtclima
            // 
            this.txtclima.Location = new System.Drawing.Point(18, 47);
            this.txtclima.Name = "txtclima";
            this.txtclima.Size = new System.Drawing.Size(116, 20);
            this.txtclima.TabIndex = 1;
            // 
            // frclima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frclima";
            this.Text = ".:. Estado del Clima .:.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtclima;
        private System.Windows.Forms.Label label2;
    }
}