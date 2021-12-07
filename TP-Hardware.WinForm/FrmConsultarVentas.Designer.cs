
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVentas));
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtConsultarVenta = new System.Windows.Forms.TextBox();
            this._lblCodigoProd = new System.Windows.Forms.Label();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("_btnVolver.Image")));
            this._btnVolver.Location = new System.Drawing.Point(41, 36);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(63, 39);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnBuscarVenta
            // 
            this._btnBuscarVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBuscarVenta.Location = new System.Drawing.Point(494, 165);
            this._btnBuscarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnBuscarVenta.Name = "_btnBuscarVenta";
            this._btnBuscarVenta.Size = new System.Drawing.Size(133, 36);
            this._btnBuscarVenta.TabIndex = 9;
            this._btnBuscarVenta.Text = "BUSCAR";
            this._btnBuscarVenta.UseVisualStyleBackColor = false;
            this._btnBuscarVenta.Click += new System.EventHandler(this._btnBuscarVenta_Click);
            // 
            // txtConsultarVenta
            // 
            this.txtConsultarVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarVenta.Location = new System.Drawing.Point(47, 165);
            this.txtConsultarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultarVenta.Multiline = true;
            this.txtConsultarVenta.Name = "txtConsultarVenta";
            this.txtConsultarVenta.Size = new System.Drawing.Size(202, 36);
            this.txtConsultarVenta.TabIndex = 8;
            // 
            // _lblCodigoProd
            // 
            this._lblCodigoProd.AutoSize = true;
            this._lblCodigoProd.Location = new System.Drawing.Point(44, 137);
            this._lblCodigoProd.Name = "_lblCodigoProd";
            this._lblCodigoProd.Size = new System.Drawing.Size(60, 17);
            this._lblCodigoProd.TabIndex = 7;
            this._lblCodigoProd.Text = "Id Venta";
            // 
            // lstVentas
            // 
            this.lstVentas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstVentas.ForeColor = System.Drawing.Color.White;
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 16;
            this.lstVentas.Location = new System.Drawing.Point(47, 259);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(580, 308);
            this.lstVentas.TabIndex = 6;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(338, 585);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(132, 39);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.Text = "ACTUALIZAR";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(507, 585);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 39);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(255, 47);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(166, 28);
            this._lblTituloTienda.TabIndex = 14;
            this._lblTituloTienda.Text = "Todas las ventas";
            // 
            // FrmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnBuscarVenta);
            this.Controls.Add(this.txtConsultarVenta);
            this.Controls.Add(this._lblCodigoProd);
            this.Controls.Add(this.lstVentas);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultarVentas";
            this.Text = "FrmConsultarVentas";
            this.Load += new System.EventHandler(this.FrmConsultarVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnBuscarVenta;
        private System.Windows.Forms.TextBox txtConsultarVenta;
        private System.Windows.Forms.Label _lblCodigoProd;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}