namespace propuesto02
{
    partial class Form1
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(41, 50);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.Size = new System.Drawing.Size(747, 150);
            this.dgPedidos.TabIndex = 1;
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellContentClick);
            this.dgPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DETALLES";
            // 
            // dgDetalles
            // 
            this.dgDetalles.AllowUserToAddRows = false;
            this.dgDetalles.AllowUserToDeleteRows = false;
            this.dgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalles.Location = new System.Drawing.Point(44, 282);
            this.dgDetalles.Name = "dgDetalles";
            this.dgDetalles.ReadOnly = true;
            this.dgDetalles.Size = new System.Drawing.Size(744, 150);
            this.dgDetalles.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.dgDetalles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDetalles;
    }
}

