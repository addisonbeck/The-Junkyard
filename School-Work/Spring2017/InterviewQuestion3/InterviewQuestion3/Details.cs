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
    public partial class Details : Form
    {
        public string user;

        public enum users
        {
            Admin = 15,
            Bozo = 14,
            Joe = 12,
            Jane = 8,
            Nerd = 6,
        }

        public enum sections
        {
            Documents = 15,
            Emails = 15,
            Configuration = 14,
            History = 12
        }

        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            lstSections.SelectedIndex = 0;
            lblSelectedUser.Text = lblSelectedUser.Text + user;

            SetButtons();
        }

        public void SetButtons()
        {
            switch (user)
            {
                case "Joe":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnArchive.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case "Jane":
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                default: return;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
