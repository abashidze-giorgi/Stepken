using Domain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepken.Page
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_UserName.Text))
            {
                var cu = new CreateNewUser();
                bool created = cu.CreateUser(txt_UserName.Text);
                if(created)
                {
                    var nf = new Form1();
                    nf.Show();
                    this.Hide();
                    nf.FormClosing += ShowThis;
                }
            }
            else
            {
                MessageBox.Show("Enter name");
            }
        }

        private void ShowThis(object? sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
