using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISLogistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(dataSet1);
        }
    }
}
