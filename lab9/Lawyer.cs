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
    public partial class Lawyer : Form
    {
        public Lawyer()
        {
            InitializeComponent();
        }

        private void юридическиеЛицаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.юридическиеЛицаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.delivery_OchirmaDataSet);

        }

        private void Lawyer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.delivery_OchirmaDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.ЮридическиеЛица". При необходимости она может быть перемещена или удалена.
            this.юридическиеЛицаTableAdapter.Fill(this.delivery_OchirmaDataSet.ЮридическиеЛица);

        }
    }
}
