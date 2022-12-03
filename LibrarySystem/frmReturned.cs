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

namespace LibrarySystem
{
    public partial class frmReturned : Form
    {
        public frmReturned()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmReturned_Load(object sender, EventArgs e)
        {
            btnNew_Click( sender,  e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " +
                    " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " +
                    " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" + txtSearchPborrower.Text + "%' ORDER BY BorrowId Desc";
            config.Load_ResultList(sql, dtg_RlistReturn);
            dtg_RlistReturn.Columns[5].Visible = false;
            dtg_RlistReturn.Columns[6].Visible = false; 
            funct.clearTxt(grp_Rgroup);

            txtrbooksSearch_TextChanged(sender, e);

        }

        private void txtrbooksSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,`DateReturned` " + 
                    " FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b " + 
                    " WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned'" + 
                    " AND  (bw.`BorrowerId` Like '%" + txtrbooksSearch.Text + "%' OR b.`AccessionNo` Like '%" + txtrbooksSearch.Text + 
                    "%' OR  `Firstname` Like '%" + txtrbooksSearch.Text + "%' OR Lastname Like '%" + txtrbooksSearch.Text +
                    "%' OR BookTitle Like '%" + txtrbooksSearch.Text + "%') ORDER BY ReturnId Desc";
            config.Load_ResultList(sql, dtgListreturned);
        }

        private void txtSearchPborrower_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " + 
                    " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + 
                    " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" + txtSearchPborrower.Text + "%' ORDER BY BorrowId Desc";
            config.Load_ResultList(sql, dtg_RlistReturn);
            dtg_RlistReturn.Columns[5].Visible = false;
            dtg_RlistReturn.Columns[6].Visible = false;
        }

        private void dtg_RlistReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT *  " +
                " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " +
                " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND BorrowId=" + dtg_RlistReturn.CurrentRow.Cells[5].Value;
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                txtRname.Text = config.dt.Rows[0].Field<string>("Firstname") + " " + config.dt.Rows[0].Field<string>("Lastname");
                txtRbookTitle.Text = config.dt.Rows[0].Field<string>("BookTitle");
                txtRdescription.Text = config.dt.Rows[0].Field<string>("BookDesc");
                txtRauthor.Text = config.dt.Rows[0].Field<string>("Author");
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Rsave_Click(object sender, EventArgs e)
        {
            if(txtRname.Text == "")
            {
                MessageBox.Show("There is no borrower in the fields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
       
            sql = "INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" +
                  " VALUES (" + dtg_RlistReturn.CurrentRow.Cells[5].Value + ",1,NOW(),'Returned')";
            config.Execute_Query(sql); 

            sql = "UPDATE `tblborrow` SET  `Status` =  'Returned',`Remarks`='On Time' WHERE `BorrowId` = '" + dtg_RlistReturn.CurrentRow.Cells[5].Value + "'";
            config.Execute_Query(sql);


            sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" + dtg_RlistReturn.CurrentRow.Cells[6].Value + "'";
             config.Execute_Query(sql);


            MessageBox.Show("Book has been returned in the library.");

            btnNew_Click(sender, e);
 
        }
    }
}
