namespace torrico_lab02
{
    partial class frmLab02
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.dgDetalles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONAR EL AÑO DEL PEDIDO";
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(277, 20);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(121, 21);
            this.cbAnio.TabIndex = 1;
            this.cbAnio.SelectedIndexChanged += new System.EventHandler(this.cbAnio_SelectedIndexChanged);
            this.cbAnio.SelectionChangeCommitted += new System.EventHandler(this.cbYear_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISTA DE PEDIDOS";
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(62, 101);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.Size = new System.Drawing.Size(726, 150);
            this.dgPedidos.TabIndex = 3;
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellContentClick);
            this.dgPedidos.DoubleClick += new System.EventHandler(this.dgPedidos_DoubleClick);
            // 
            // dgDetalles
            // 
            this.dgDetalles.AllowUserToAddRows = false;
            this.dgDetalles.AllowUserToDeleteRows = false;
            this.dgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalles.Location = new System.Drawing.Point(62, 309);
            this.dgDetalles.Name = "dgDetalles";
            this.dgDetalles.ReadOnly = true;
            this.dgDetalles.Size = new System.Drawing.Size(726, 150);
            this.dgDetalles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LISTA DE DETALLES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nro de pedidos";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(737, 272);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(35, 13);
            this.lblPedido.TabIndex = 7;
            this.lblPedido.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto del pedido";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(740, 477);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(35, 13);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "label7";
            // 
            // frmLab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDetalles);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.label1);
            this.Name = "frmLab02";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.DataGridView dgDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMonto;
    }
}

