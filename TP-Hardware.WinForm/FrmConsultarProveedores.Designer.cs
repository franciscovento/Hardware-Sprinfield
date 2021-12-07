
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProveedores));
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.lstProveedor = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("_btnVolver.Image")));
            this._btnVolver.Location = new System.Drawing.Point(47, 33);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(66, 39);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarCliente
            // 
            this._btnBuscarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBuscarCliente.Location = new System.Drawing.Point(498, 205);
            this._btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnBuscarCliente.Name = "_btnBuscarCliente";
            this._btnBuscarCliente.Size = new System.Drawing.Size(134, 36);
            this._btnBuscarCliente.TabIndex = 9;
            this._btnBuscarCliente.Text = "BUSCAR";
            this._btnBuscarCliente.UseVisualStyleBackColor = false;
            this._btnBuscarCliente.Click += new System.EventHandler(this._btnBuscarCliente_Click_1);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProd.Location = new System.Drawing.Point(47, 205);
            this.txtBuscarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProd.Multiline = true;
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(216, 36);
            this.txtBuscarProd.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(44, 173);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(89, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Id Proveedor";
            // 
            // lstProveedor
            // 
            this.lstProveedor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstProveedor.ForeColor = System.Drawing.Color.White;
            this.lstProveedor.FormattingEnabled = true;
            this.lstProveedor.ItemHeight = 16;
            this.lstProveedor.Location = new System.Drawing.Point(47, 302);
            this.lstProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProveedor.Name = "lstProveedor";
            this.lstProveedor.Size = new System.Drawing.Size(585, 260);
            this.lstProveedor.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(498, 593);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(314, 593);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(134, 36);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.Text = "ACTUALIZAR";
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(239, 44);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(223, 28);
            this._lblTituloTienda.TabIndex = 37;
            this._lblTituloTienda.Text = "Todos los proveedores";
            // 
            // FrmConsultarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarCliente);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this.lstProveedor);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultarProveedores";
            this.Text = "FrmConsultarProveedores";
            this.Load += new System.EventHandler(this.FrmConsultarProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox lstProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}