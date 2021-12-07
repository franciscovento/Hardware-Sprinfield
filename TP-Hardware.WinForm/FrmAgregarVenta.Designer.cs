
namespace TP_Hardware.WinForm
{
    partial class FrmAgregarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarVenta));
            this._bntVolver = new System.Windows.Forms.Button();
            this._btnAgregarCliente = new System.Windows.Forms.Button();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbidProd = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.cmbIdProducto = new System.Windows.Forms.ComboBox();
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._bntVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this._bntVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bntVolver.ForeColor = System.Drawing.Color.White;
            this._bntVolver.Image = ((System.Drawing.Image)(resources.GetObject("_bntVolver.Image")));
            this._bntVolver.Location = new System.Drawing.Point(41, 53);
            this._bntVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._bntVolver.Name = "_bntVolver";
            this._bntVolver.Size = new System.Drawing.Size(60, 44);
            this._bntVolver.TabIndex = 6;
            this._bntVolver.UseVisualStyleBackColor = false;
            this._bntVolver.Click += new System.EventHandler(this._bntVolver_Click);
            // 
            // _btnAgregarCliente
            // 
            this._btnAgregarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgregarCliente.Location = new System.Drawing.Point(255, 496);
            this._btnAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAgregarCliente.Name = "_btnAgregarCliente";
            this._btnAgregarCliente.Size = new System.Drawing.Size(164, 44);
            this._btnAgregarCliente.TabIndex = 5;
            this._btnAgregarCliente.Text = "AGREGAR";
            this._btnAgregarCliente.UseVisualStyleBackColor = false;
            this._btnAgregarCliente.Click += new System.EventHandler(this._btnAgregarCliente_Click);
            // 
            // txEstado
            // 
            this.txEstado.Location = new System.Drawing.Point(187, 416);
            this.txEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txEstado.Multiline = true;
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(315, 33);
            this.txEstado.TabIndex = 4;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(185, 396);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(52, 17);
            this.lbEstado.TabIndex = 20;
            this.lbEstado.Text = "Estado";
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(187, 346);
            this.txCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCantidad.Multiline = true;
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(315, 33);
            this.txCantidad.TabIndex = 3;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(184, 323);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 17);
            this.lbCantidad.TabIndex = 18;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbidProd
            // 
            this.lbidProd.AutoSize = true;
            this.lbidProd.Location = new System.Drawing.Point(184, 258);
            this.lbidProd.Name = "lbidProd";
            this.lbidProd.Size = new System.Drawing.Size(80, 17);
            this.lbidProd.TabIndex = 16;
            this.lbidProd.Text = "Id Producto";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Location = new System.Drawing.Point(184, 187);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(66, 17);
            this.lbIdCliente.TabIndex = 14;
            this.lbIdCliente.Text = "Id Cliente";
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(188, 208);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(315, 24);
            this.cmbIdCliente.TabIndex = 1;
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProducto.FormattingEnabled = true;
            this.cmbIdProducto.Location = new System.Drawing.Point(188, 279);
            this.cmbIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(315, 24);
            this.cmbIdProducto.TabIndex = 2;
            this.cmbIdProducto.SelectedIndexChanged += new System.EventHandler(this.cmbIdProducto_SelectedIndexChanged);
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(259, 90);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(148, 28);
            this._lblTituloTienda.TabIndex = 21;
            this._lblTituloTienda.Text = "Agregar Venta";
            // 
            // FrmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this.cmbIdProducto);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarCliente);
            this.Controls.Add(this.txEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbidProd);
            this.Controls.Add(this.lbIdCliente);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarVenta";
            this.Text = "AgregarVenta";
            this.Load += new System.EventHandler(this.FrmAgregarVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bntVolver;
        private System.Windows.Forms.Button _btnAgregarCliente;
        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbidProd;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.ComboBox cmbIdProducto;
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}