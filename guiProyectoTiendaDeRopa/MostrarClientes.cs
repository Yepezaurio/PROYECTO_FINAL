using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace guiProyectoTiendaDeRopa
{
    public partial class MostrarClientes : Form
    {
        MySqlCommand command;
        MySqlDataAdapter da;
        private BindingSource bindingSource = null;
        private MySqlCommandBuilder mysqlbuilder = null;
        DataTable dataTable = new DataTable();
        public MostrarClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from productos";

            using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, ConexionBD.Conectarbd()))
            {
                DataSet dset = new DataSet();
                adaptador.Fill(dset);
                dataGridView1.DataSource = dset.Tables[0];
            }
        }
        private void DataBind()
        {
            dataGridView1.DataSource = null;
            dataTable.Clear();
            string query = "SELECT * From productos";

            ConexionBD.Conectarbd();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = query;
            try
            {
                da = new MySqlDataAdapter(query, ConexionBD.Conectarbd());
                mysqlbuilder = new MySqlCommandBuilder(da);
                da.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                dataGridView1.DataSource = bindingSource;
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            da.Update(dataTable);
            MessageBox.Show("Actualizado");
            DataBind();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
               
            }
        }
    }
}
