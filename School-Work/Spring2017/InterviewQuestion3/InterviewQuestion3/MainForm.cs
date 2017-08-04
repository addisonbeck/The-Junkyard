using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewQuestion3
{

    public enum users
    {
        Admin = 15,
        Bozo = 14,
        Joe = 12,
        Jane = 8,
        Nerd = 6,
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbUsers.SelectedIndex = 0;
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            string user = cmbUsers.Text;
            
            Details d = new Details();
            d.user = user;
            d.ShowDialog();
        }
    }
}
