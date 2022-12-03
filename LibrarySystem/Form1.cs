using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        public void enabled_menu()
        {
            ts_login.Text = "Logout";
            ts_books.Enabled = true;
            ts_transaction.Enabled = true;
            ts_borrower.Enabled = true;
            ts_categories.Enabled = true;
            ts_users.Enabled = true;
            ts_login.Image = Properties.Resources.Untitled_11;
        }

        public void disabled_menu()
        {
            ts_login.Text = "Login";
            ts_books.Enabled = false;
            ts_transaction.Enabled = false;
            ts_borrower.Enabled = false;
            ts_categories.Enabled = false;
            ts_users.Enabled = false;
            ts_login.Image = Properties.Resources.Untitled_11;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }

        private void ts_books_Click(object sender, EventArgs e)
        {
            Form frm = new frmBooks();
            frm.ShowDialog();
        }

        private void ts_BorrowItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void ts_returnItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturned();
            frm.ShowDialog();
        }

        private void ts_overdueItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmOverdue();
            frm.ShowDialog();
        }

        private void ts_borrower_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrower();
            frm.ShowDialog();
        }

        private void ts_categories_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategories();
            frm.ShowDialog(); 
        }

        private void ts_users_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.ShowDialog();
        }


        private void ts_login_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin(this);

            if (ts_login.Text == "Login")
            {
                frm.ShowDialog();
            }
            else
            {
                ts_login.Text = "Login";
                disabled_menu();
            }
        }
    }
}
