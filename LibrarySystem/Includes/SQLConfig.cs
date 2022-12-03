using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace LibrarySystem.Includes
{
    class SQLConfig
    {

        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=dblibrary;sslMode=none");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt; 
        int result;
        usableFunction funct = new usableFunction();
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if(result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); 
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Load_DTG(string sql,DataGridView dtg)
        {
            try
            {
                //con.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;

               
                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }

        public void Load_ResultList(string sql, DataGridView dtg)
        {
            try
            {
                //con.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;


                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }
        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open(); 
                } 

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void combo(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.Items.Clear();
                cbo.Text = "Select";
                foreach(DataRow r in dt.Rows)
                {
                    cbo.Items.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void singleResult(string sql)

        {
            try
            {
                con.Open();
                //if (con.State == ConnectionState.Open)
                //{
                //    con.Close();
                //}
                //else
                //{
                //    con.Open(); 
                //}
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);  


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public void loadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        public void autocomplete(string sql,TextBox txt)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        public void autonumber(string AUTOKEY, TextBox txt)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open(); 
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = "SELECT CONCAT(`Autonumber`,`EndValue`) FROM `tblautonumber` WHERE Remarks='" + AUTOKEY + "'";
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.Text = DateTime.Now.ToString("yyyy") + dt.Rows[0].Field<string>(0);
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }
        public void update_Autonumber(string id)
        { 
            Execute_Query("UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        }
       
    //    public void checkOverduePurposed(string sql, string choiceofporpuse)
    //    {

    //        string day = DateTime.Now.ToString("dddd");
    //        int hoursinterval, convertedtimeH, convertedtimeM, CurrMinute, CurrHour;
    //        DateTime retrievtime, time;


    ////        'declarations
    ////Dim day As String = Format(Today, "dddd") 'string format of days
    ////Dim hoursinterval As Integer
    ////Dim retrievtime As Date 'date borrowed 
    ////Dim convertedtimeH As Integer    'hour borrowed 
    ////Dim convertedtimeM As Integer   'minute borrowed 


    //        //Dim time As Date 'current date
    //        //Dim CurrHour As Integer ' current hour
    //        //Dim CurrMinute As Integer 'current minute

    //        try
    //        {
    //            con.Open();
    //            cmd = new MySqlCommand();
    //            da = new MySqlDataAdapter();
    //            dt = new DataTable(); 

    //            cmd.Connection = con;
    //            cmd.CommandText = sql;
    //            da.SelectCommand = cmd;
    //            da.Fill(dt);

    //            foreach(DataRow r in dt.Rows)
    //            {
    //                int id = r.Field<int>(1);

    //                switch (day)
    //                {
    //                    case "Monday" :
    //                        switch (choiceofporpuse)
    //                        {
    //                            case "Research":
    //                                break;
    //                                timeOfresearch(id);
    //                            case "Photocopy":
    //                                timeOfPhotocopy(id, r.Field<DateTime>(0));
    //                                break;
    //                            case "Overnight":
    //                                timeOfOvernight(id, r.Field<DateTime>(0));
    //                                break;
    //                            case "Borrowed for 3days":
    //                                timeOfthreeDays(id, r.Field<DateTime>(0));
    //                                break;
    //                        } 
    //                        break;

    //                }
    //            }
    //        }
    //        catch(Exception ex)
    //        {

    //        }
    //        finally
    //        {
    //            con.Close();
    //            da.Dispose():
    //        }
           
    //    }

    //    public void timeOfresearch(int id)
    //    {
    //        if (DateTime.Now.ToString("tt") == "AM")
    //        {
    //           int checktime = DateTime.
    //        }
    //    //    If Format(Now, "tt") = "AM" Then
    //    //   Dim checktime As Integer = DatePart("h", Now) & Format(Now, "mm")
    //    //    If checktime <= 830 Or checktime >= 1130 Then
    //    //        ' MsgBox(Format(Date.Now().Date, "yyyy-MM-dd") & " 11:30:00")
    //    //        sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
    //    //        & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
    //    //        updates(sql)
    //    //    End If

    //    //ElseIf Format(Now, "tt") = "PM" Then
    //    //    Dim checktime As Integer = DatePart("h", Now) & DatePart("n", Now)
    //    //    If checktime <= 1330 Or checktime >= 1730 Then
    //    //        sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
    //    //         & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
    //    //        updates(sql)
    //    //    End If

    //    //End If
    //    }


    }
}
