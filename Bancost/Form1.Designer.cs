
namespace Bancost
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCredito = new System.Windows.Forms.Label();
            this.labelCantidadCuota = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtCantidadCuotas = new System.Windows.Forms.TextBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelCuota = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(60, 88);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(115, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Ingresar Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(389, 57);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(116, 15);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Ingresar Apellido";
            // 
            // labelCredito
            // 
            this.labelCredito.AutoSize = true;
            this.labelCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredito.Location = new System.Drawing.Point(60, 163);
            this.labelCredito.Name = "labelCredito";
            this.labelCredito.Size = new System.Drawing.Size(117, 15);
            this.labelCredito.TabIndex = 2;
            this.labelCredito.Text = "Monto de Credito";
            // 
            // labelCantidadCuota
            // 
            this.labelCantidadCuota.AutoSize = true;
            this.labelCantidadCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadCuota.Location = new System.Drawing.Point(386, 163);
            this.labelCantidadCuota.Name = "labelCantidadCuota";
            this.labelCantidadCuota.Size = new System.Drawing.Size(132, 15);
            this.labelCantidadCuota.TabIndex = 3;
            this.labelCantidadCuota.Text = "Cantidad de Cuotas";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnombre.Location = new System.Drawing.Point(200, 88);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(392, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.Location = new System.Drawing.Point(200, 163);
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.Size = new System.Drawing.Size(100, 20);
            this.txtMontoCredito.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(210, 363);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 4;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(401, 204);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadCuotas.TabIndex = 4;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(176, 21);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(176, 21);
            this.LabelTitulo.TabIndex = 5;
            this.LabelTitulo.Text = "Banco SantoTomas";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(200, 224);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(60, 224);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(83, 15);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Monto Total";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIniciar.Location = new System.Drawing.Point(417, 256);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 8;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCuota
            // 
            this.labelCuota.AutoSize = true;
            this.labelCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota.Location = new System.Drawing.Point(62, 291);
            this.labelCuota.Name = "labelCuota";
            this.labelCuota.Size = new System.Drawing.Size(81, 15);
            this.labelCuota.TabIndex = 9;
            this.labelCuota.Text = "Valor Cuota";
            // 
            // txtCuota
            // 
            this.txtCuota.Enabled = false;
            this.txtCuota.Location = new System.Drawing.Point(200, 296);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 20);
            this.txtCuota.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(555, 344);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.labelCuota);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtMontoCredito);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.labelCantidadCuota);
            this.Controls.Add(this.labelCredito);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelCredito;
        private System.Windows.Forms.Label labelCantidadCuota;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelCuota;
        private System.Windows.Forms.TextBox txtCuota;
    }
}

