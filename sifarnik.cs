using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kucni_b_4_9
{
    public partial class sifarnik : Form
    {
        private string ime_tabele;
        DataTable tabela;
        SqlDataAdapter adapter;

        public sifarnik()
        {
            InitializeComponent();
        }
        public sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void sifarnik_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection("Data Source = INF_4_PROFESOR\\SQLPBG;Initial Catalog=kucni_budzet;Integrated security=true");
            adapter = new SqlDataAdapter("select * from " + ime_tabele, veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
            }
            this.Close();
        }
    }
}
