
namespace Aplicacion
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnvendido = new System.Windows.Forms.Button();
            this.lblcaja = new System.Windows.Forms.Label();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblprenda = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblefectivo = new System.Windows.Forms.Label();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagg = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.cmbprenda = new System.Windows.Forms.ComboBox();
            this.lblpagar = new System.Windows.Forms.Label();
            this.lbldevo = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpre = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvendido
            // 
            this.btnvendido.Location = new System.Drawing.Point(317, 393);
            this.btnvendido.Name = "btnvendido";
            this.btnvendido.Size = new System.Drawing.Size(157, 52);
            this.btnvendido.TabIndex = 16;
            this.btnvendido.Text = "VENDIDO";
            this.btnvendido.UseVisualStyleBackColor = true;
            this.btnvendido.Click += new System.EventHandler(this.button3_Click);

            this.lblcaja.AutoSize = true;
            this.lblcaja.BackColor = System.Drawing.SystemColors.Control;
            this.lblcaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaja.Location = new System.Drawing.Point(365, 20);
            this.lblcaja.Name = "lblcaja";
            this.lblcaja.Size = new System.Drawing.Size(88, 31);
            this.lblcaja.TabIndex = 17;
            this.lblcaja.Text = "CAJA";
            this.lblcaja.Click += new System.EventHandler(this.lbl14_Click);
            // 
           
            // 
            this.dgvlista.AllowUserToAddRows = false;
            this.dgvlista.AllowUserToDeleteRows = false;
            this.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvlista.Location = new System.Drawing.Point(12, 185);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.RowHeadersVisible = false;
            this.dgvlista.Size = new System.Drawing.Size(423, 181);
            this.dgvlista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRENDA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblprenda
            // 
            this.lblprenda.AutoSize = true;
            this.lblprenda.Location = new System.Drawing.Point(52, 77);
            this.lblprenda.Name = "lblprenda";
            this.lblprenda.Size = new System.Drawing.Size(55, 13);
            this.lblprenda.TabIndex = 1;
            this.lblprenda.Text = "PRENDA:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(459, 113);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 13);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(459, 74);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(459, 153);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(50, 13);
            this.lblprecio.TabIndex = 4;
            this.lblprecio.Text = "PRECIO:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(52, 128);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(65, 13);
            this.lblcantidad.TabIndex = 5;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(18, 30);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(95, 13);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "TOTAL A PAGAR:";
            // 
            // lblefectivo
            // 
            this.lblefectivo.AutoSize = true;
            this.lblefectivo.Location = new System.Drawing.Point(51, 75);
            this.lblefectivo.Name = "lblefectivo";
            this.lblefectivo.Size = new System.Drawing.Size(62, 13);
            this.lblefectivo.TabIndex = 11;
            this.lblefectivo.Text = "EFECTIVO:";
            // 
            // lbldevolucion
            // 
            this.lbldevolucion.AutoSize = true;
            this.lbldevolucion.Location = new System.Drawing.Point(33, 115);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(80, 13);
            this.lbldevolucion.TabIndex = 12;
            this.lbldevolucion.Text = "DEVOLUCION:";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(498, 393);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(157, 51);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagg
            // 
            this.btnagg.Location = new System.Drawing.Point(141, 393);
            this.btnagg.Name = "btnagg";
            this.btnagg.Size = new System.Drawing.Size(157, 53);
            this.btnagg.TabIndex = 15;
            this.btnagg.Text = "AGREGAR";
            this.btnagg.UseVisualStyleBackColor = true;
            this.btnagg.Click += new System.EventHandler(this.btnagg_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(147, 125);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(109, 20);
            this.txtcantidad.TabIndex = 16;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(123, 72);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(100, 20);
            this.txtefectivo.TabIndex = 17;
            this.txtefectivo.TextChanged += new System.EventHandler(this.txtefectivo_TextChanged);
            // 
            // cmbprenda
            // 
            this.cmbprenda.FormattingEnabled = true;
            this.cmbprenda.Items.AddRange(new object[] {
            "Pantalon",
            "Gorro",
            "Calcetas"});
            this.cmbprenda.Location = new System.Drawing.Point(147, 74);
            this.cmbprenda.Name = "cmbprenda";
            this.cmbprenda.Size = new System.Drawing.Size(151, 21);
            this.cmbprenda.TabIndex = 18;
            this.cmbprenda.SelectedIndexChanged += new System.EventHandler(this.cmbprenda_SelectedIndexChanged);
            // 
            // lblpagar
            // 
            this.lblpagar.AutoSize = true;
            this.lblpagar.Location = new System.Drawing.Point(120, 30);
            this.lblpagar.Name = "lblpagar";
            this.lblpagar.Size = new System.Drawing.Size(11, 13);
            this.lblpagar.TabIndex = 19;
            this.lblpagar.Text = "*";
            this.lblpagar.Click += new System.EventHandler(this.lblpagar_Click);
            // 
            // lbldevo
            // 
            this.lbldevo.AutoSize = true;
            this.lbldevo.Location = new System.Drawing.Point(120, 115);
            this.lbldevo.Name = "lbldevo";
            this.lbldevo.Size = new System.Drawing.Size(11, 13);
            this.lbldevo.TabIndex = 20;
            this.lbldevo.Text = "*";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(542, 74);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(11, 13);
            this.lblnom.TabIndex = 21;
            this.lblnom.Text = "*";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(542, 113);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(11, 13);
            this.lblcod.TabIndex = 22;
            this.lblcod.Text = "*";
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.Location = new System.Drawing.Point(542, 153);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(11, 13);
            this.lblpre.TabIndex = 23;
            this.lblpre.Text = "*";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbltotal);
            this.gb1.Controls.Add(this.lblefectivo);
            this.gb1.Controls.Add(this.lbldevolucion);
            this.gb1.Controls.Add(this.txtefectivo);
            this.gb1.Controls.Add(this.lbldevo);
            this.gb1.Controls.Add(this.lblpagar);
            this.gb1.Location = new System.Drawing.Point(462, 197);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(236, 151);
            this.gb1.TabIndex = 24;
            this.gb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 482);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lblpre);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.cmbprenda);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnvendido);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagg);
            this.Controls.Add(this.lblcaja);
            this.Controls.Add(this.lblprenda);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcantidad);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de ropa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvendido;
        private System.Windows.Forms.Label lblcaja;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblprenda;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblefectivo;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagg;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.ComboBox cmbprenda;
        private System.Windows.Forms.Label lblpagar;
        private System.Windows.Forms.Label lbldevo;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpre;
        private System.Windows.Forms.GroupBox gb1;
    }
}

