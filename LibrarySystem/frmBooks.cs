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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btnNew_Click(object sender, EventArgs e)
        {

            funct.clearTxt(this);
            sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price',DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` ";
            config.Load_ResultList(sql, dtgList);

            sql = "SELECT CategoryId,Category From tblcategory WHERE Category !='ALL'  ORDER BY CATEGORY ASC";
            config.fiil_CBO(sql, cboCategory); 

            btnUpdate.Enabled = false;

            btnSave.Enabled = true;

            btnDelete.Enabled = false;
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string datePublish = dtpDatePublish.Text;
            string remarks = "Donate";

            if (txtAccessionNo.Text == "" ||
                 txtAuthor.Text == "" || txtTitle.Text == ""
                 || txtDesc.Text == "" || txtPublisher.Text == "" )
            {
                MessageBox.Show("All fields are required to be filled up.", "Inavalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }
              

            sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" + txtAccessionNo.Text + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                MessageBox.Show("Accession number is already in used.", "Inavalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 

            //        'adding books
            sql = "Insert Into `tblbooks` " +
                    " (`AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`,Status,DeweyDecimal,OverAllQty,Remark,BookType) " +
                    " VALUES ('" + txtAccessionNo.Text + "','" + txtTitle.Text + "','" + txtDesc.Text + "','" + txtAuthor.Text + "','" + datePublish + "','" + txtPublisher.Text + "','" + cboCategory.SelectedValue + "','0',1, 'Available' ,'" + "',1,'" + remarks + "','" + cboType.Text + "')";

            config.Execute_CUD(sql, "failed to execute the query.", "Books has been saved in the database");


            sql = "SELECT * FROM `tblbooknumber` WHERE `BOOKTITLE` = '" + txtTitle.Text + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" + txtTitle.Text + "'";
                config.Execute_Query(sql);
            }
            else
            {
                sql = "INSERT INTO  `tblbooknumber` (`BOOKTITLE`,`QTY`,`Desc`, `Author`, `PublishDate`, `Publisher`) " +
                      " VALUES ('" + txtTitle.Text + "',1,'" + txtDesc.Text + "','" + txtAuthor.Text + "','" + datePublish + "','" + txtPublisher.Text + "')";
                config.Execute_Query(sql);
            }

            frmBooks_Load(sender, e);
             

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string datePublish = dtpDatePublish.Text;
            string remarks = "Donate";

            if (txtAccessionNo.Text == "" ||
                 txtAuthor.Text == "" || txtTitle.Text == ""
                 || txtDesc.Text == "" || txtPublisher.Text == "")
            {
                MessageBox.Show("All fields are required to be filled up.", "Inavalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


          
            sql = "Update `tblbooks` Set `BookTitle`='" + txtTitle.Text +
                    "', `BookDesc`='" + txtDesc.Text + "', `Author`='" + txtAuthor.Text + "', `PublishDate`='" + datePublish +
                    "', `BookPublisher`='" + txtPublisher.Text + "', `CategoryId`='" + cboCategory.SelectedValue + "', `DeweyDecimal`='" + 
                    "',Remark='" + remarks + "',BookType='" + cboType.Text + "'  WHERE `AccessionNo`='" + txtAccessionNo.Text + "'";
            config.Execute_CUD(sql, "failed to execute the query.", "Books has been updated in the database");
             
            frmBooks_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `tblbooks` WHERE `AccessionNo` = '" + txtAccessionNo.Text + "'"; 
            config.Execute_CUD(sql, "failed to execute the query.", "Books has been deleted in the database"); 

            sql = "DELETE FROM  `tblbooknumber` WHERE `BOOKTITLE`='" + txtTitle.Text + "'";
            config.Execute_Query(sql);

            frmBooks_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtAccessionNo.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtAccessionNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` , `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType ,DeweyDecimal,Remark  FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND  `AccessionNo`= '" + txtAccessionNo.Text + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    txtTitle.Text = config.dt.Rows[0].Field<string>(1);
                    txtDesc.Text = config.dt.Rows[0].Field<string>(2);
                    txtAuthor.Text = config.dt.Rows[0].Field<string>(3);
                    dtpDatePublish.Text = config.dt.Rows[0].Field<DateTime>(4).ToString();
                    txtPublisher.Text = config.dt.Rows[0].Field<string>(5);
                    cboCategory.Text = config.dt.Rows[0].Field<string>(6);
                    cboType.Text = config.dt.Rows[0].Field<string>(7);
                

                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtTitle.Clear();
                    txtDesc.Clear();
                    txtAuthor.Clear();
                    txtPublisher.Clear();
                    cboType.Text = "Unknown";

                    sql = "Select CategoryId,Category FROM tblcategory";
                    config.fiil_CBO(sql, cboCategory);


                    dtpDatePublish.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" + cboCategory.SelectedValue;
            //config.singleResult(sql);
            //txtDeweyDecimal.Text = config.dt.Rows[0].Field<string>(2); 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND (`BookTitle` Like '%" + txtSearch.Text + "%' OR `Author` Like '%" + txtSearch.Text + "%' OR `AccessionNo`  Like '%" + txtSearch.Text + "%')";
            config.Load_ResultList(sql, dtgList);
        }

        private void dtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDeweyDecimal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
