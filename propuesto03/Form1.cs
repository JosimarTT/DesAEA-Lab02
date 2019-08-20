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

namespace propuesto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarAnioPedido();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoDB"].ConnectionString);

        public void ListarAnioPedido()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_ListaAnios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable df = new DataTable();
                    da.Fill(df);
                    cbAnio.DataSource = df;
                    cbAnio.DisplayMember = "Anios";
                    cbAnio.ValueMember = "Anios";

                }
            }
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(cbAnio.SelectedValue);
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Mes", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@anio", Codigo);
                    DataTable df = new DataTable();
                    da.Fill(df);
                    cbMes.DataSource = df;
                    cbMes.DisplayMember = "Meses";
                    cbMes.ValueMember = "Meses";
                }
            }
        }
    }
}
