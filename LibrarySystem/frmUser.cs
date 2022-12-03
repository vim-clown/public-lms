using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Includes;
using LibrarySystem.Properties;
using System.IO;

namespace LibrarySystem
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql; 

        private void frmUser_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "id";
            funct.clearTxt(this);

            cbo_type.Text = "Administrator";
            sql = "Select UserId as 'ID' ,Fullname as 'Name',User_name as 'UserName',UserRole as 'Type' From tbluser WHERE Status='Active'";
            config.Load_DTG(sql, dtg_listUser);
            dtg_listUser.Columns[0].Visible = false;
            if(lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
             
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            if( txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "" ){
                funct.emptymessage();
            }

            sql = "insert into tbluser (`Fullname`, `User_name`, `Pass`, `UserRole`,`Status`) " 
             + "values('" + txt_name.Text + "','" + txt_username.Text 
             + "','" + txt_pass.Text + "','" + cbo_type.Text 
             + "','Active')";
            config.Execute_CUD(sql, "error to execute query.", "New User has been saved in the database.");

            btn_New_Click(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sql = "update tbluser set Fullname = '" + txt_name.Text + "',User_name= '" + txt_username.Text
                + "',Pass= '" + txt_pass.Text + "',UserRole= '" + cbo_type.Text
                + "' where UserId = " + lbl_id.Text;

            config.Execute_CUD(sql, "error to execute query.", "Users has been updated in the database.");

            btn_New_Click(sender, e);

        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();

            btn_saveuser.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "delete from tbluser where UserId = '" + lbl_id.Text + "'";
                config.Execute_CUD(sql, "error to execute the query.", "User has been deleted in the database.");
            }

            btn_New_Click(sender, e);
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
