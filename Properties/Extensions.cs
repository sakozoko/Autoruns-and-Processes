using System.Collections.Generic;
using System.Windows.Forms;
using Cleaner.Process;
namespace Cleaner.Properties
{
    public static class Extensions
    {
        public static void SetChecks(this DataGridView dataGrid)
        {
            for (var i = 0; i < dataGrid.Rows.Count; i++)
            {
                dataGrid.Rows[i].Cells[0].Value = false;
                foreach (var str in ProcessNames.GetSavedProcNames())
                    if (dataGrid.Rows[i].Cells[1].Value.ToString() == str)
                        dataGrid.Rows[i].Cells[0].Value = true;
            }
        }

        public static HashSet<string> GetTextCheckedCells(this DataGridView dataGrid)
        {
            var hash = new HashSet<string>();
            for (var i = 0; i < dataGrid.Rows.Count; i++)
                if (dataGrid.Rows[i].Cells[0].Value is true)
                    hash.Add(dataGrid.Rows[i].Cells[1].Value.ToString());
            return hash;
        }

        //only for datagrid, whose have 2 columns, where first is checkedbox

        public static IEnumerable<string> GetList(this DataGridView dataGrid)
        {
            for (int c = 0; c < dataGrid.Rows.Count; c++)
            {
                yield return dataGrid[1, c].Value.ToString();
            }
            
        }
    }
}