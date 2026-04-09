using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    private readonly SqlConnection conn;
    private readonly String connectionString = "Data Source=Rayhan\\RAYHANFATIHR;Initial Catalog=DBAkademikADO;Integrated Security=True";

    public partial class Form1 : Form
    {
        public FromMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
