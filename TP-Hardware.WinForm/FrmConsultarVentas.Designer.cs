
namespace TP_Hardware.WinForm
{
    partial class FrmConsultarVentas
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
            this._btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtConsultarVenta = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.Location = new System.Drawing.Point(223, 27);
            this._lblTituloTienda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(133, 21);
            this._lblTituloTienda.TabIndex = 11;
            this._lblTituloTienda.Text = "Todas las ventas";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(504, 315);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(64, 24);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarVenta
            // 
            this._btnBuscarVenta.Location = new System.Drawing.Point(73, 157);
            this._btnBuscarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnBuscarVenta.Name = "_btnBuscarVenta";
            this._btnBuscarVenta.Size = new System.Drawing.Size(100, 29);
            this._btnBuscarVenta.TabIndex = 9;
            this._btnBuscarVenta.Text = "Buscar Venta";
            this._btnBuscarVenta.UseVisualStyleBackColor = true;
            this._btnBuscarVenta.Click += new System.EventHandler(this._btnBuscarVenta_Click);
            // 
            // txtConsultarVenta
            // 
            this.txtConsultarVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultarVenta.Location = new System.Drawing.Point(35, 134);
            this.txtConsultarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultarVenta.Name = "txtConsultarVenta";
            this.txtConsultarVenta.Size = new System.Drawing.Size(138, 20);
            this.txtConsultarVenta.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(33, 118);
            this._lblCodigoProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(47, 13);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Id Venta";
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(226, 118);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(342, 186);
            this.lstVentas.TabIndex = 6;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(236, 315);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(64, 24);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(504, 90);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 24);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarVenta);
            this.Controls.Add(this.txtConsultarVenta);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this.lstVentas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmConsultarVentas";
            this.Text = "FrmConsultarVentas";
            this.Load += new System.EventHandler(this.FrmConsultarVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTituloTienda;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarVenta;
        private System.Windows.Forms.TextBox txtConsultarVenta;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAgregar;
    }
}