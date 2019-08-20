using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace torrico_lab02
{
    public partial class frmLab02 : Form
    {
        public frmLab02()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoDB"].ConnectionString);

        public void ListaAnios()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_ListaAnios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "ListaAnios");
                        cbAnio.DataSource = df.Tables["ListaAnios"];
                        cbAnio.DisplayMember = "Anios";
                        cbAnio.ValueMember = "Anios";
                    }
                }
            }
        }

        private void cbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos_Anios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@anio", cbAnio.SelectedValue);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        dgPedidos.DataSource = df.Tables["Pedidos"];
                        lblPedido.Text = df.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        }

        private void dgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(dgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Detalles");
                        dgDetalles.DataSource = df.Tables["Detalles"];
                        lblMonto.Text = df.Tables["Detalles"].Compute("Sum(Monto)", "").ToString();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAnios();
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
