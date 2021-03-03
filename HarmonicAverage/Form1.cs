using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicAverage
{
    public partial class HarmonicAverage : Form
    {
        public HarmonicAverage()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(tbA.Text);
            int B = Convert.ToInt32(tbB.Text);

            int HA = (2 * A * B) / A + B;
            lbAnswer.Text = Convert.ToString(HA);
        }
    }
}
