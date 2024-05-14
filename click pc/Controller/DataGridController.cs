
using click_pc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox_hunter.Controllers
{
    internal class DataGridController
    {
        public static void Loaddata(DataGrid dataGrid, DataGridView dataGridView)
        {
            dataGridView.BeginInvoke(new Action(() =>
            {
                dataGridView.Rows[dataGrid.index].Cells[1].Value = dataGrid.index;
                if (dataGrid.status != null)
                {
                    dataGridView.Rows[dataGrid.index].Cells[2].Value = dataGrid.status;
                }
               
            }));
        }
    }
}
