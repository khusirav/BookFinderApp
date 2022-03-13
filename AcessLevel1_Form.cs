using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookFinderApp
{
    public partial class AcessLevel1_Form : Form
    {
        public AcessLevel1_Form()
        {
            InitializeComponent();
        }

        private void AcessLevel1_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.ProvidersPhones_view". При необходимости она может быть перемещена или удалена.
            this.providersPhones_viewTableAdapter.Fill(this.bookFinderDataSet.ProvidersPhones_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.ShopsProviders_view". При необходимости она может быть перемещена или удалена.
            this.shopsProviders_viewTableAdapter.Fill(this.bookFinderDataSet.ShopsProviders_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.ShopsManagersPhones_view". При необходимости она может быть перемещена или удалена.
            this.shopsManagersPhones_viewTableAdapter.Fill(this.bookFinderDataSet.ShopsManagersPhones_view);

        }
    }
}
