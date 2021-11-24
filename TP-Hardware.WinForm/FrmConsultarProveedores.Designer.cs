
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
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.lstProveedor = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(297, 33);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(223, 28);
            this._lblTituloTienda.TabIndex = 11;
            this._lblTituloTienda.Text = "Todos los proveedores";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(672, 388);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 30);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarCliente
            // 
            this._btnBuscarCliente.Location = new System.Drawing.Point(97, 193);
            this._btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnBuscarCliente.Name = "_btnBuscarCliente";
            this._btnBuscarCliente.Size = new System.Drawing.Size(133, 36);
            this._btnBuscarCliente.TabIndex = 9;
            this._btnBuscarCliente.Text = "Buscar proveedor";
            this._btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProd.Location = new System.Drawing.Point(47, 165);
            this.txtBuscarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(183, 22);
            this.txtBuscarProd.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(44, 145);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(89, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Id Proveedor";
            // 
            // lstProveedor
            // 
            this.lstProveedor.FormattingEnabled = true;
            this.lstProveedor.ItemHeight = 16;
            this.lstProveedor.Location = new System.Drawing.Point(301, 145);
            this.lstProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProveedor.Name = "lstProveedor";
            this.lstProveedor.Size = new System.Drawing.Size(455, 228);
            this.lstProveedor.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(672, 111);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 30);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(303, 388);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(85, 30);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // FrmConsultarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarCliente);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this.lstProveedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultarProveedores";
            this.Text = "FrmConsultarProveedores";
            this.Load += new System.EventHandler(this.FrmConsultarProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox lstProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRecargar;
    }
}