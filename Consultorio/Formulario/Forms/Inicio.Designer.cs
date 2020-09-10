namespace Consultorio.Forms
{
    partial class frmInicio
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblGestiónClientes = new System.Windows.Forms.Label();
            this.btnGestiónClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(21, 30);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(151, 20);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido, usuario ";
            // 
            // lblGestiónClientes
            // 
            this.lblGestiónClientes.AutoSize = true;
            this.lblGestiónClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestiónClientes.Location = new System.Drawing.Point(27, 188);
            this.lblGestiónClientes.Name = "lblGestiónClientes";
            this.lblGestiónClientes.Size = new System.Drawing.Size(145, 20);
            this.lblGestiónClientes.TabIndex = 2;
            this.lblGestiónClientes.Text = "Gestión de clientes";
            // 
            // btnGestiónClientes
            // 
            this.btnGestiónClientes.Image = global::Formulario.Properties.Resources.iconfinder__68ui_2303173;
            this.btnGestiónClientes.Location = new System.Drawing.Point(65, 121);
            this.btnGestiónClientes.Name = "btnGestiónClientes";
            this.btnGestiónClientes.Size = new System.Drawing.Size(64, 64);
            this.btnGestiónClientes.TabIndex = 1;
            this.btnGestiónClientes.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGestiónClientes);
            this.Controls.Add(this.btnGestiónClientes);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnGestiónClientes;
        private System.Windows.Forms.Label lblGestiónClientes;
    }
}