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
    public partial class frmBorrower : Form
    {
        public frmBorrower()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int inc, maxrow;

        private void navigate_records(int inc)
        {
            sql = "SELECT BorrowerId FROM tblborrower";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                txt_bid.Text = config.dt.Rows[inc].Field<string>(0);
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            funct.clearTxt(this);  
            sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`  as 'Course/Year' FROM `tblborrower`  WHERE Stats='Active'";
            config.Load_ResultList(sql, dtg_ABorrowLists); 
            btn_delete.Enabled = false;

            sql = "SELECT * FROM `tblborrower`  WHERE Stats='Active'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                maxrow = config.dt.Rows.Count - 1;
            }

            inc = 0;
        }

        private void frmBorrower_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void txt_bid_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" + txt_bid.Text + "'";
            config.singleResult(sql);

            if(config.dt.Rows.Count > 0)
            {
                txt_fname.Text = config.dt.Rows[0].Field<string>("Firstname");
                txt_lname.Text = config.dt.Rows[0].Field<string>("Lastname");
                txt_mname.Text = config.dt.Rows[0].Field<string>("MiddleName");
                rch_address.Text = config.dt.Rows[0].Field<string>("Address");
                txtContact.Text = config.dt.Rows[0].Field<string>("ContactNo");
                txtCourse.Text = config.dt.Rows[0].Field<string>("CourseYear");

                if (config.dt.Rows[0].Field<string>("Sex") == "Female")
                {
                    rdio_female.Checked = true;
                }
                else
                {
                    rdio_male.Checked = true;
                }
                btn_delete.Enabled = true;
                 
            }
            else
            {
                btn_delete.Enabled = false;
                clearme();
            }
             
        }
        private void clearme()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mname.Clear();
            rch_address.Clear();
            txtContact.Clear();
            txtCourse.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
             
            if( txt_bid.Text == "" 
            || txt_fname.Text == "" || txt_lname.Text == "" 
            || txt_mname.Text == "" || txtCourse.Text == "" ){
              funct.emptymessage();
            }

            string gender;
            if (rdio_female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }  

            sql = "SELECT * FROM `tblborrower` WHERE `BorrowerId`=" + txt_bid.Text;
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                sql = "update  tblborrower set  `Firstname`='" + txt_fname.Text
                      + "', `Lastname`='" + txt_lname.Text + "', `MiddleName`='" + txt_mname.Text
                      + "', `Address`='" + rch_address.Text + "', `Sex`='" + gender
                      + "', `ContactNo` ='" + txtContact.Text + "', `CourseYear`='" + txtCourse.Text.ToUpper()
                      + "', `BorrowerType`='Student' where `BorrowerId`='" + txt_bid.Text + "'";
                config.Execute_CUD(sql, "error to execute the query", "Borrower has been updated in the database.");

            }
            else
            {
                sql = "insert into tblborrower (`BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, "
                       + "`Sex`, `ContactNo`, `CourseYear`,  `BorrowerPhoto`,`BorrowerType`,Stats)"
                       + "values ('" + txt_bid.Text + "','" + txt_fname.Text + "','" + txt_lname.Text
                       + "','" + txt_mname.Text + "','" + rch_address.Text
                       + "','" + gender + "','" + txtContact.Text + "','" + txtCourse.Text
                       + "','" + "','Student','Active')";
                config.Execute_CUD(sql, "error to execute the query", "New borrower has been added in the database.");

            }
    

            btn_New_Click(sender, e);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //With OpenFileDialog1

            //    'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
            OpenFileDialog1.CheckFileExists = true;


            //    'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
            OpenFileDialog1.CheckPathExists = true;


            //    'GET AND SET THE DEFAULT EXTENSION
            OpenFileDialog1.DefaultExt = "jpg";


            //    'RETURN THE FILE LINKED TO THE LNK FILE
            OpenFileDialog1.DereferenceLinks = true;

            //    'SET THE FILE NAME TO EMPTY 
            OpenFileDialog1.FileName = "";

            //    'FILTERING THE FILES
            OpenFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*";

            //    'SET THIS FOR ONE FILE SELECTION ONLY.
            OpenFileDialog1.Multiselect = false;



            //    'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
            OpenFileDialog1.RestoreDirectory = true;

            //    'SET THE TITLE OF THE DIALOG BOX.
            OpenFileDialog1.Title = "Select a file to open";

            //    'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
            OpenFileDialog1.ValidateNames = true;

     
  
        }

        private void btn_delete_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure you want to delete this borrower?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { 
                sql = "UPDATE `tblborrower` SET  `Stats` =  'NotActive' WHERE `BorrowerId` ='" + dtg_ABorrowLists.CurrentRow.Cells[0].Value + "'";
                config.Execute_Query(sql);

                MessageBox.Show("Borrower has been deleted in the database.", "Success", MessageBoxButtons.OK);
                btn_New_Click(sender, e);
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            inc = maxrow;
            navigate_records(inc);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if(inc == 0)
            {
                MessageBox.Show("First Records.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(inc <= maxrow)
            {
                inc = inc - 1;
                navigate_records(inc);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (inc == maxrow)
            { 
                MessageBox.Show("Last Records.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  if (inc >= 0)
            {
                inc = inc + 1;
                navigate_records(inc);
            }
        }

        private void dtg_ABorrowLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_bid.Text = dtg_ABorrowLists.CurrentRow.Cells[0].Value.ToString();
        }

        private void dtg_ABorrowLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            inc = 0;
            navigate_records(inc);
        }
    }
}
