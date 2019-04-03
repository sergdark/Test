using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        ToolStripLabel infoLabel;
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel typeLabel;

        public MainForm()
        {
            InitializeComponent();
            StatusLabel();
        }

        private void StatusLabel()
        {
            infoLabel = new ToolStripLabel
            {
                Text = "Текущая дата и время"
            };

            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            t
                

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
