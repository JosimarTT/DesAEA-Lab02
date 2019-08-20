using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace propuesto02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoDB"].ConnectionString);


        public void ListaPedidos()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Total_Pedidos", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        dgPedidos.DataSource = df.Tables["Pedidos"];
                    }
                }
            }
        }

        public void ListaPedidos_CellClick(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(dgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Total_Detalles", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Empleado", Codigo);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df);
                        dgDetalles.DataSource = df;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaPedidos();
        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(dgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Total_Detalles", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idPedido", Codigo);
                    DataTable df = new DataTable();
                     da.Fill(df);
                    dgDetalles.DataSource = df;
                }
            }
        }
    }
}
