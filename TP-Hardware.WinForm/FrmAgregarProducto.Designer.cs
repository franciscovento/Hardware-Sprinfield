
namespace TP_Hardware.WinForm
{
    partial class FrmAgregarProducto
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
            this._bntVolver = new System.Windows.Forms.Button();
            this._btnAgregarProducto = new System.Windows.Forms.Button();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._txtIdProveedor = new System.Windows.Forms.TextBox();
            this._lblIdProveedor = new System.Windows.Forms.Label();
            this._txtStock = new System.Windows.Forms.TextBox();
            this._lblStock = new System.Windows.Forms.Label();
            this._txtNombreProducto = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._txtIdCategoria = new System.Windows.Forms.TextBox();
            this._lblIdCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.Location = new System.Drawing.Point(73, 332);
            this._bntVolver.Name = "_bntVolver";
            this._bntVolver.Size = new System.Drawing.Size(78, 44);
            this._bntVolver.TabIndex = 27;
            this._bntVolver.Text = "Volver";
            this._bntVolver.UseVisualStyleBackColor = true;
            this._bntVolver.Click += new System.EventHandler(this._bntVolver_Click);
            // 
            // _btnAgregarProducto
            // 
            this._btnAgregarProducto.Location = new System.Drawing.Point(178, 332);
            this._btnAgregarProducto.Name = "_btnAgregarProducto";
            this._btnAgregarProducto.Size = new System.Drawing.Size(78, 44);
            this._btnAgregarProducto.TabIndex = 26;
            this._btnAgregarProducto.Text = "Agregar";
            this._btnAgregarProducto.UseVisualStyleBackColor = true;
            this._btnAgregarProducto.Click += new System.EventHandler(this._btnAgregarProducto_Click);
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(73, 276);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(183, 22);
            this._txtPrecio.TabIndex = 23;
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Location = new System.Drawing.Point(70, 256);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(48, 17);
            this._lblPrecio.TabIndex = 22;
            this._lblPrecio.Text = "Precio";
            // 
            // _txtIdProveedor
            // 
            this._txtIdProveedor.Location = new System.Drawing.Point(73, 219);
            this._txtIdProveedor.Name = "_txtIdProveedor";
            this._txtIdProveedor.Size = new System.Drawing.Size(183, 22);
            this._txtIdProveedor.TabIndex = 21;
            // 
            // _lblIdProveedor
            // 
            this._lblIdProveedor.AutoSize = true;
            this._lblIdProveedor.Location = new System.Drawing.Point(70, 199);
            this._lblIdProveedor.Name = "_lblIdProveedor";
            this._lblIdProveedor.Size = new System.Drawing.Size(89, 17);
            this._lblIdProveedor.TabIndex = 20;
            this._lblIdProveedor.Text = "Id Proveedor";
            // 
            // _txtStock
            // 
            this._txtStock.Location = new System.Drawing.Point(73, 161);
            this._txtStock.Name = "_txtStock";
            this._txtStock.Size = new System.Drawing.Size(183, 22);
            this._txtStock.TabIndex = 19;
            // 
            // _lblStock
            // 
            this._lblStock.AutoSize = true;
            this._lblStock.Location = new System.Drawing.Point(70, 141);
            this._lblStock.Name = "_lblStock";
            this._lblStock.Size = new System.Drawing.Size(43, 17);
            this._lblStock.TabIndex = 18;
            this._lblStock.Text = "Stock";
            // 
            // _txtNombreProducto
            // 
            this._txtNombreProducto.Location = new System.Drawing.Point(73, 105);
            this._txtNombreProducto.Name = "_txtNombreProducto";
            this._txtNombreProducto.Size = new System.Drawing.Size(183, 22);
            this._txtNombreProducto.TabIndex = 17;
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(70, 85);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(119, 17);
            this._lblNombre.TabIndex = 16;
            this._lblNombre.Text = "Nombre Producto";
            // 
            // _txtIdCategoria
            // 
            this._txtIdCategoria.Location = new System.Drawing.Point(73, 45);
            this._txtIdCategoria.Name = "_txtIdCategoria";
            this._txtIdCategoria.Size = new System.Drawing.Size(183, 22);
            this._txtIdCategoria.TabIndex = 15;
            // 
            // _lblIdCategoria
            // 
            this._lblIdCategoria.AutoSize = true;
            this._lblIdCategoria.Location = new System.Drawing.Point(70, 25);
            this._lblIdCategoria.Name = "_lblIdCategoria";
            this._lblIdCategoria.Size = new System.Drawing.Size(84, 17);
            this._lblIdCategoria.TabIndex = 14;
            this._lblIdCategoria.Text = "Id Categoria";
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarProducto);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._txtIdProveedor);
            this.Controls.Add(this._lblIdProveedor);
            this.Controls.Add(this._txtStock);
            this.Controls.Add(this._lblStock);
            this.Controls.Add(this._txtNombreProducto);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._txtIdCategoria);
            this.Controls.Add(this._lblIdCategoria);
            this.Name = "FrmAgregarProducto";
            this.Text = "FrmAgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bntVolver;
        private System.Windows.Forms.Button _btnAgregarProducto;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.TextBox _txtIdProveedor;
        private System.Windows.Forms.Label _lblIdProveedor;
        private System.Windows.Forms.TextBox _txtStock;
        private System.Windows.Forms.Label _lblStock;
        private System.Windows.Forms.TextBox _txtNombreProducto;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.TextBox _txtIdCategoria;
        private System.Windows.Forms.Label _lblIdCategoria;
    }
}