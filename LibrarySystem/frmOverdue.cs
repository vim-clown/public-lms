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
    public partial class frmOverdue : Form
    {
        public frmOverdue()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btnPenNew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox7);
            funct.clearTxt(GroupBox10);


            sql = "SELECT br.`BorrowerId`, `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " + 
              " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + 
              " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=1 ";
            config.Load_ResultList(sql, dtgPenalties);
            dtgPenalties.Columns[5].Visible = false;
            dtgPenalties.Columns[6].Visible = false;

        }

        private void frmOverdue_Load(object sender, EventArgs e)
        {
            btnPenNew_Click(sender, e);
        }

        private void txtSearchPborrower_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT br.`BorrowerId`, `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " +
             " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " +
             " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=1 AND   br.`BorrowerId` Like '%" + txtSearchPborrower.Text + "%'";
            config.Load_ResultList(sql, dtgPenalties);
            dtgPenalties.Columns[5].Visible = false;
            dtgPenalties.Columns[6].Visible = false;
        }

        private void dtgPenalties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT  TIMEDIFF( NOW( ) ,  `DueDate` ),`AccessionNo` " 
                 + "FROM  `tblborrow` WHERE `BorrowId` = '" + dtgPenalties.CurrentRow.Cells[5].Value.ToString() + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                TimeSpan ts = config.dt.Rows[0].Field<TimeSpan>(0);
                int tsdays, hourperday, tshours, totalhours;
                //MessageBox.Show(ts.Hours.ToString());

                tsdays = ts.Days;

                hourperday = tsdays * 24;
                tshours = ts.Hours;
                totalhours = hourperday + tshours;



                txtOverdueTime.Text = ts.ToString();
                txttothours.Text = totalhours.ToString();

            } 

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalpayments;

                totalpayments = int.Parse(txttothours.Text) * int.Parse(txtamount.Text);

            }
            catch (Exception)
            {

            }
        
            //totalhours = condays + tValueHour
            //totalhours = totalhours / Val(frmPayments.txthours.Text)
            //frmPayments.txtTotPay.Text = totalhours * Val(frmPayments.txtamount.Text)
        }
         
        private void txthours_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                double total_hours, total_payments;

                total_hours = int.Parse(txttothours.Text) / int.Parse(txthours.Text);
                total_payments = total_hours * double.Parse(txtamount.Text);

                txtTotPay.Text = total_payments.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void txthours_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                double total_hours, total_payments;

                total_hours = int.Parse(txttothours.Text) / int.Parse(txthours.Text);
                total_payments = total_hours * double.Parse(txtamount.Text);

                txtTotPay.Text = total_payments.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void txttenderedAmount_TextChanged(object sender, EventArgs e)
        {
            double change;
            change = double.Parse(txttenderedAmount.Text) - double.Parse(txtTotPay.Text);
            txtChange.Text = change.ToString();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (txtamount.Text == "" || txthours.Text == "" || txttenderedAmount.Text == "" || txtOverdueTime.Text == "")
            {
                MessageBox.Show("You must fill all the fields inorder to save.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(int.Parse(txtChange.Text) < 0)
            {
                MessageBox.Show("The tendered amount is less than the total payments. Its not valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            sql = "INSERT INTO `tblpayment` (`BorrowId`, `Payment`, `Change`, `DatePayed`, `BorrowerId`, `Remarks`) "
                + " VALUES (" + dtgPenalties.CurrentRow.Cells[6].Value + ",'" + txtTotPay.Text + "','" + txtChange.Text +
                "',Now(),'" + dtgPenalties.CurrentRow.Cells[0].Value + "','Settled')";
            config.Execute_Query(sql);

            sql = "INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" +
                  " VALUES (" + dtgPenalties.CurrentRow.Cells[6].Value + ",1,NOW(),'Returned')";
            config.Execute_Query(sql);


            sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" + dtgPenalties.CurrentRow.Cells[6].Value + "'";
            config.Execute_Query(sql);

            sql = "UPDATE `tblborrow` SET  `Status` =  'Returned', Due = 0 WHERE `BorrowId` = " + dtgPenalties.CurrentRow.Cells[5].Value;
            config.Execute_Query(sql);

            MessageBox.Show("Book has been returned and settled in the library");
            btnPenNew_Click(sender, e); 
        }

        private void btnPenClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgPenalties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
