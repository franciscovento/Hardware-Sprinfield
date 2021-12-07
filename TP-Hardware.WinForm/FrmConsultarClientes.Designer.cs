
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarClientes));
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this._txtBuscarCliente = new System.Windows.Forms.TextBox();
            this._btnBuscarCliente = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lstClientes
            // 
            this._lstClientes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._lstClientes.ForeColor = System.Drawing.SystemColors.Window;
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.ItemHeight = 16;
            this._lstClientes.Location = new System.Drawing.Point(41, 268);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(592, 276);
            this._lstClientes.TabIndex = 0;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(38, 154);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(68, 17);
            this._lblCodigoProd.TabIndex = 1;
            this._lblCodigoProd.Text = "Id cliente:";
            // 
            // _txtBuscarCliente
            // 
            this._txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBuscarCliente.Location = new System.Drawing.Point(41, 183);
            this._txtBuscarCliente.Multiline = true;
            this._txtBuscarCliente.Name = "_txtBuscarCliente";
            this._txtBuscarCliente.Size = new System.Drawing.Size(191, 42);
            this._txtBuscarCliente.TabIndex = 2;
            // 
            // _btnBuscarCliente
            // 
            this._btnBuscarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBuscarCliente.Location = new System.Drawing.Point(494, 183);
            this._btnBuscarCliente.Name = "_btnBuscarCliente";
            this._btnBuscarCliente.Size = new System.Drawing.Size(139, 42);
            this._btnBuscarCliente.TabIndex = 3;
            this._btnBuscarCliente.Text = "BUSCAR";
            this._btnBuscarCliente.UseVisualStyleBackColor = false;
            this._btnBuscarCliente.Click += new System.EventHandler(this._btnBuscarCliente_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnVolver.ForeColor = System.Drawing.Color.White;
            this._btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("_btnVolver.Image")));
            this._btnVolver.Location = new System.Drawing.Point(41, 48);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(61, 41);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(494, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(259, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de clientes";
            // 
            // FrmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarCliente);
            this.Controls.Add(this._txtBuscarCliente);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this._lstClientes);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmConsultarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.TextBox _txtBuscarCliente;
        private System.Windows.Forms.Button _btnBuscarCliente;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}