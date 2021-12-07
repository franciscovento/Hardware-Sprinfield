
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            this._bntVolver = new System.Windows.Forms.Button();
            this._btnAgregarProducto = new System.Windows.Forms.Button();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblIdProveedor = new System.Windows.Forms.Label();
            this._txtStock = new System.Windows.Forms.TextBox();
            this._lblStock = new System.Windows.Forms.Label();
            this._txtNombreProducto = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblIdCategoria = new System.Windows.Forms.Label();
            this._cbIdProveedor = new System.Windows.Forms.ComboBox();
            this._cbIdCategoria = new System.Windows.Forms.ComboBox();
            this._lblNroCategoria = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._lblTituloTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _bntVolver
            // 
            this._bntVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this._bntVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._bntVolver.Image = ((System.Drawing.Image)(resources.GetObject("_bntVolver.Image")));
            this._bntVolver.Location = new System.Drawing.Point(27, 23);
            this._bntVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._bntVolver.Name = "_bntVolver";
            this._bntVolver.Size = new System.Drawing.Size(50, 42);
            this._bntVolver.TabIndex = 10;
            this._bntVolver.UseVisualStyleBackColor = false;
            this._bntVolver.Click += new System.EventHandler(this._bntVolver_Click);
            // 
            // _btnAgregarProducto
            // 
            this._btnAgregarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this._btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgregarProducto.Location = new System.Drawing.Point(475, 557);
            this._btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAgregarProducto.Name = "_btnAgregarProducto";
            this._btnAgregarProducto.Size = new System.Drawing.Size(134, 46);
            this._btnAgregarProducto.TabIndex = 7;
            this._btnAgregarProducto.Text = "Agregar";
            this._btnAgregarProducto.UseVisualStyleBackColor = false;
            this._btnAgregarProducto.Click += new System.EventHandler(this._btnAgregarProducto_Click);
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(411, 417);
            this._txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtPrecio.Multiline = true;
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(198, 31);
            this._txtPrecio.TabIndex = 6;
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Location = new System.Drawing.Point(408, 398);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(48, 17);
            this._lblPrecio.TabIndex = 22;
            this._lblPrecio.Text = "Precio";
            // 
            // _lblIdProveedor
            // 
            this._lblIdProveedor.AutoSize = true;
            this._lblIdProveedor.Location = new System.Drawing.Point(59, 315);
            this._lblIdProveedor.Name = "_lblIdProveedor";
            this._lblIdProveedor.Size = new System.Drawing.Size(89, 17);
            this._lblIdProveedor.TabIndex = 20;
            this._lblIdProveedor.Text = "Id Proveedor";
            // 
            // _txtStock
            // 
            this._txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtStock.Location = new System.Drawing.Point(411, 343);
            this._txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtStock.Multiline = true;
            this._txtStock.Name = "_txtStock";
            this._txtStock.Size = new System.Drawing.Size(198, 31);
            this._txtStock.TabIndex = 4;
            // 
            // _lblStock
            // 
            this._lblStock.AutoSize = true;
            this._lblStock.Location = new System.Drawing.Point(408, 324);
            this._lblStock.Name = "_lblStock";
            this._lblStock.Size = new System.Drawing.Size(43, 17);
            this._lblStock.TabIndex = 18;
            this._lblStock.Text = "Stock";
            // 
            // _txtNombreProducto
            // 
            this._txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNombreProducto.Location = new System.Drawing.Point(411, 273);
            this._txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtNombreProducto.Multiline = true;
            this._txtNombreProducto.Name = "_txtNombreProducto";
            this._txtNombreProducto.Size = new System.Drawing.Size(198, 31);
            this._txtNombreProducto.TabIndex = 3;
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(408, 252);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(141, 17);
            this._lblNombre.TabIndex = 16;
            this._lblNombre.Text = "Nombre del producto";
            // 
            // _lblIdCategoria
            // 
            this._lblIdCategoria.AutoSize = true;
            this._lblIdCategoria.Location = new System.Drawing.Point(58, 252);
            this._lblIdCategoria.Name = "_lblIdCategoria";
            this._lblIdCategoria.Size = new System.Drawing.Size(84, 17);
            this._lblIdCategoria.TabIndex = 14;
            this._lblIdCategoria.Text = "Id Categoria";
            // 
            // _cbIdProveedor
            // 
            this._cbIdProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbIdProveedor.FormattingEnabled = true;
            this._cbIdProveedor.ItemHeight = 16;
            this._cbIdProveedor.Location = new System.Drawing.Point(61, 343);
            this._cbIdProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbIdProveedor.Name = "_cbIdProveedor";
            this._cbIdProveedor.Size = new System.Drawing.Size(198, 24);
            this._cbIdProveedor.TabIndex = 28;
            // 
            // _cbIdCategoria
            // 
            this._cbIdCategoria.DropDownHeight = 200;
            this._cbIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbIdCategoria.FormattingEnabled = true;
            this._cbIdCategoria.IntegralHeight = false;
            this._cbIdCategoria.Location = new System.Drawing.Point(62, 280);
            this._cbIdCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbIdCategoria.Name = "_cbIdCategoria";
            this._cbIdCategoria.Size = new System.Drawing.Size(198, 24);
            this._cbIdCategoria.TabIndex = 2;
            // 
            // _lblNroCategoria
            // 
            this._lblNroCategoria.AutoSize = true;
            this._lblNroCategoria.Location = new System.Drawing.Point(266, 287);
            this._lblNroCategoria.Name = "_lblNroCategoria";
            this._lblNroCategoria.Size = new System.Drawing.Size(0, 17);
            this._lblNroCategoria.TabIndex = 30;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.ItemHeight = 16;
            this.cmbProducto.Location = new System.Drawing.Point(411, 149);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(198, 24);
            this.cmbProducto.TabIndex = 31;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(408, 125);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(144, 17);
            this.lbProducto.TabIndex = 32;
            this.lbProducto.Text = "Productos guardados";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 125);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(84, 17);
            this.lbId.TabIndex = 34;
            this.lbId.Text = "Id Producto:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(61, 149);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 31);
            this.txtID.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(323, 557);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(134, 46);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(71, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "__________________________________________________________________";
            // 
            // _lblTituloTienda
            // 
            this._lblTituloTienda.AutoSize = true;
            this._lblTituloTienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTituloTienda.ForeColor = System.Drawing.Color.GreenYellow;
            this._lblTituloTienda.Location = new System.Drawing.Point(239, 37);
            this._lblTituloTienda.Name = "_lblTituloTienda";
            this._lblTituloTienda.Size = new System.Drawing.Size(188, 28);
            this._lblTituloTienda.TabIndex = 36;
            this._lblTituloTienda.Text = "Datos de producto";
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this._lblTituloTienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this._lblNroCategoria);
            this.Controls.Add(this._cbIdCategoria);
            this.Controls.Add(this._cbIdProveedor);
            this.Controls.Add(this._bntVolver);
            this.Controls.Add(this._btnAgregarProducto);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._lblIdProveedor);
            this.Controls.Add(this._txtStock);
            this.Controls.Add(this._lblStock);
            this.Controls.Add(this._txtNombreProducto);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblIdCategoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgregarProducto";
            this.Text = "FrmAgregarProducto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bntVolver;
        private System.Windows.Forms.Button _btnAgregarProducto;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblIdProveedor;
        private System.Windows.Forms.TextBox _txtStock;
        private System.Windows.Forms.Label _lblStock;
        private System.Windows.Forms.TextBox _txtNombreProducto;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblIdCategoria;
        private System.Windows.Forms.ComboBox _cbIdProveedor;
        private System.Windows.Forms.ComboBox _cbIdCategoria;
        private System.Windows.Forms.Label _lblNroCategoria;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblTituloTienda;
    }
}