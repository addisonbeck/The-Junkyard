using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace InterviewQuestion
{
    public partial class InterviewQuestion : Form
    {
        public InterviewQuestion()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            int x = Int32.Parse(txtX.Text);
            int y = Int32.Parse(txtY.Text);
            int z = (x * y);

            txtResults.Text = Solve(z).ToString();
            BitList(z);

        }

        private int Solve(int z) {
            int count = 0;

            while (z != 0)
            {
                count++;
                z &= (z - 1);
            }

            return count;
        }

        private void BitList(int input) {
            var bits = new BitArray(new int[] { input });
            int i = 0;

            foreach (bool bit in bits)
            {
                if (bit == true) {
                    lstOutput.Items.Add(i);
                }
                i++;
            }
        }
    }
}


