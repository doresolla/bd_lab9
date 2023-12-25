using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Fiz : Form
    {
        public Fiz()
        {
            InitializeComponent();
        }

        private void физическиеЛицаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.физическиеЛицаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.delivery_OchirmaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.delivery_OchirmaDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.ФизическиеЛица". При необходимости она может быть перемещена или удалена.
            this.физическиеЛицаTableAdapter.Fill(this.delivery_OchirmaDataSet.ФизическиеЛица);

        }
    }
}
