using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimerApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = ResultsStorage.GetResults();
            int number = 0;
            foreach (var result in results)
            {
                number++;
                ResultDataGridView.Rows.Add(number, result.resultTime, result.currentTime);
            }
        }

        private void clearResultsButton_Click(object sender, EventArgs e)
        {
            ResultsStorage.ClearUserResults();
            ResultDataGridView.Rows.Clear();
            this.Refresh();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
