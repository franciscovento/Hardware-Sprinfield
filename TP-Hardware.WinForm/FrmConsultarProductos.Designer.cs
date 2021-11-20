
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarProductos
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
            this._btnBuscarProducto = new System.Windows.Forms.Button();
            this._txtBuscarProducto = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this._lstProductos = new System.Windows.Forms.ListBox();
            this._btnAgregarProd = new System.Windows.Forms.Button();
            this._btnRefrescar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(297, 33);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(201, 28);
            this._lblTituloTienda.TabIndex = 11;
            this._lblTituloTienda.Text = "Todos los productos";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(672, 388);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(85, 29);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarProducto
            // 
            this._btnBuscarProducto.Location = new System.Drawing.Point(97, 193);
            this._btnBuscarProducto.Name = "_btnBuscarProducto";
            this._btnBuscarProducto.Size = new System.Drawing.Size(134, 36);
            this._btnBuscarProducto.TabIndex = 9;
            this._btnBuscarProducto.Text = "Buscar Producto";
            this._btnBuscarProducto.UseVisualStyleBackColor = true;
            this._btnBuscarProducto.Click += new System.EventHandler(this._btnBuscarProducto_Click);
            // 
            // _txtBuscarProducto
            // 
            this._txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtBuscarProducto.Location = new System.Drawing.Point(47, 165);
            this._txtBuscarProducto.Name = "_txtBuscarProducto";
            this._txtBuscarProducto.Size = new System.Drawing.Size(184, 22);
            this._txtBuscarProducto.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(44, 145);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(132, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Código de producto";
            // 
            // _lstProductos
            // 
            this._lstProductos.FormattingEnabled = true;
            this._lstProductos.ItemHeight = 16;
            this._lstProductos.Location = new System.Drawing.Point(302, 145);
            this._lstProductos.Name = "_lstProductos";
            this._lstProductos.Size = new System.Drawing.Size(455, 228);
            this._lstProductos.TabIndex = 6;
            // 
            // _btnAgregarProd
            // 
            this._btnAgregarProd.Location = new System.Drawing.Point(587, 103);
            this._btnAgregarProd.Name = "_btnAgregarProd";
            this._btnAgregarProd.Size = new System.Drawing.Size(170, 27);
            this._btnAgregarProd.TabIndex = 12;
            this._btnAgregarProd.Text = "Agregar Producto";
            this._btnAgregarProd.UseVisualStyleBackColor = true;
            this._btnAgregarProd.Click += new System.EventHandler(this._btnAgregarProd_Click);
            // 
            // _btnRefrescar
            // 
            this._btnRefrescar.Location = new System.Drawing.Point(302, 388);
            this._btnRefrescar.Name = "_btnRefrescar";
            this._btnRefrescar.Size = new System.Drawing.Size(111, 29);
            this._btnRefrescar.TabIndex = 13;
            this._btnRefrescar.Text = "Refrescar";
            this._btnRefrescar.UseVisualStyleBackColor = true;
            this._btnRefrescar.Click += new System.EventHandler(this._btnRefrescar_Click);
            // 
            // FrmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnRefrescar);
            this.Controls.Add(this._btnAgregarProd);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarProducto);
            this.Controls.Add(this._txtBuscarProducto);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this._lstProductos);
            this.Name = "FrmConsultarProductos";
            this.Text = "FrmConsultarProductos";
            this.Load += new System.EventHandler(this.FrmConsultarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarProducto;
        private System.Windows.Forms.TextBox _txtBuscarProducto;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox _lstProductos;
        private System.Windows.Forms.Button _btnAgregarProd;
        private System.Windows.Forms.Button _btnRefrescar;
    }
}