using System;
using System.Windows.Forms;
using Cleaner.Process;
using Cleaner.Properties;

namespace Cleaner.Forms
{
    public partial class FSavedProc : Form
    {
        public FSavedProc()
        {
            InitializeComponent();
            FormUpg.SmoothViewForm(this);
        }

        private void FSavedProc_Load(object sender, EventArgs e)
        {
            FormUpg.RewriteProcessNamesToGrid(dataGridView2,this);
        }

        private void ButSaveProcNamesToFile_Click(object sender, EventArgs e)
        {
            ProcessNames.SaveProcNames(dataGridView2.GetTextCheckedCells());
            FormUpg.RewriteProcessNamesToGrid(dataGridView2,this);
        }


        private void ButBack_Click(object sender, EventArgs e)
        {
            FormUpg.SmoothViewFormClose(this);
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            { dataGridView2.Rows[e.RowIndex].Cells[0].Value = !(bool)dataGridView2.Rows[e.RowIndex].Cells[0].Value; }
        }
    }
}
