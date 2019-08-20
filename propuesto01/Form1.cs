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

namespace propuesto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoDB"].ConnectionString);

        public void ListaEmpleados()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Empleados", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "ListaEmpleado");
                        cbEmpleado.DataSource = df.Tables["ListaEmpleado"];
                        cbEmpleado.DisplayMember = "Empleado";
                        cbEmpleado.ValueMember = "Empleado";
                    }
                }
            }
        }

        private void cbEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Empleado",cbEmpleado.SelectedValue);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        dgPedidos.DataSource = df.Tables["Pedidos"];
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaEmpleados();
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
