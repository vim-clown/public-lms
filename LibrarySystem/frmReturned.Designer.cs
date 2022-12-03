namespace LibrarySystem
{
    partial class frmReturned
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturned));
            this.check_due = new System.Windows.Forms.Timer(this.components);
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchPborrower = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.dtg_RlistReturn = new System.Windows.Forms.DataGridView();
            this.grp_Rgroup = new System.Windows.Forms.GroupBox();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.cboRborrowerId = new System.Windows.Forms.TextBox();
            this.txtRbookTitle = new System.Windows.Forms.TextBox();
            this.txtRauthor = new System.Windows.Forms.TextBox();
            this.txtRdescription = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_accessionNo = new System.Windows.Forms.Label();
            this.lbl_transid = new System.Windows.Forms.Label();
            this.lbl_borrowerId = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_Rduedate = new System.Windows.Forms.Label();
            this.lbl_rpayments = new System.Windows.Forms.Label();
            this.lbl_Rchange = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txt_RtenAmount = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.txtRCopyBorrowed = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtRRqty = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_Rsave = new System.Windows.Forms.Button();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtrbooksSearch = new System.Windows.Forms.TextBox();
            this.dtgListreturned = new System.Windows.Forms.DataGridView();
            this.TabControl3.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).BeginInit();
            this.grp_Rgroup.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage5);
            this.TabControl3.Controls.Add(this.TabPage6);
            this.TabControl3.Location = new System.Drawing.Point(12, 12);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(814, 481);
            this.TabControl3.TabIndex = 6;
            // 
            // TabPage5
            // 
            this.TabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPage5.BackgroundImage")));
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Controls.Add(this.grp_Rgroup);
            this.TabPage5.Controls.Add(this.btnClose);
            this.TabPage5.Controls.Add(this.btnNew);
            this.TabPage5.Controls.Add(this.btn_Rsave);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(806, 455);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "Unreturn Books";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtSearchPborrower);
            this.GroupBox3.Controls.Add(this.Label27);
            this.GroupBox3.Controls.Add(this.dtg_RlistReturn);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(6, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(386, 443);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "View Details of Unreturn Books";
            // 
            // txtSearchPborrower
            // 
            this.txtSearchPborrower.Location = new System.Drawing.Point(117, 24);
            this.txtSearchPborrower.Name = "txtSearchPborrower";
            this.txtSearchPborrower.Size = new System.Drawing.Size(263, 25);
            this.txtSearchPborrower.TabIndex = 25;
            this.txtSearchPborrower.TextChanged += new System.EventHandler(this.txtSearchPborrower_TextChanged);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(27, 27);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(84, 17);
            this.Label27.TabIndex = 24;
            this.Label27.Text = "Borrower Id :";
            // 
            // dtg_RlistReturn
            // 
            this.dtg_RlistReturn.AllowUserToAddRows = false;
            this.dtg_RlistReturn.AllowUserToDeleteRows = false;
            this.dtg_RlistReturn.AllowUserToResizeColumns = false;
            this.dtg_RlistReturn.AllowUserToResizeRows = false;
            this.dtg_RlistReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_RlistReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RlistReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_RlistReturn.Location = new System.Drawing.Point(6, 55);
            this.dtg_RlistReturn.MultiSelect = false;
            this.dtg_RlistReturn.Name = "dtg_RlistReturn";
            this.dtg_RlistReturn.RowHeadersVisible = false;
            this.dtg_RlistReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_RlistReturn.Size = new System.Drawing.Size(374, 382);
            this.dtg_RlistReturn.TabIndex = 0;
            this.dtg_RlistReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_RlistReturn_CellClick);
            // 
            // grp_Rgroup
            // 
            this.grp_Rgroup.Controls.Add(this.txtRname);
            this.grp_Rgroup.Controls.Add(this.cboRborrowerId);
            this.grp_Rgroup.Controls.Add(this.txtRbookTitle);
            this.grp_Rgroup.Controls.Add(this.txtRauthor);
            this.grp_Rgroup.Controls.Add(this.txtRdescription);
            this.grp_Rgroup.Controls.Add(this.GroupBox2);
            this.grp_Rgroup.Controls.Add(this.Label18);
            this.grp_Rgroup.Controls.Add(this.Label9);
            this.grp_Rgroup.Controls.Add(this.Label3);
            this.grp_Rgroup.Controls.Add(this.Label8);
            this.grp_Rgroup.Controls.Add(this.GroupBox5);
            this.grp_Rgroup.Controls.Add(this.Label25);
            this.grp_Rgroup.Controls.Add(this.txtRCopyBorrowed);
            this.grp_Rgroup.Controls.Add(this.Label14);
            this.grp_Rgroup.Controls.Add(this.Label11);
            this.grp_Rgroup.Controls.Add(this.txtRRqty);
            this.grp_Rgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Rgroup.Location = new System.Drawing.Point(398, 17);
            this.grp_Rgroup.Name = "grp_Rgroup";
            this.grp_Rgroup.Size = new System.Drawing.Size(388, 344);
            this.grp_Rgroup.TabIndex = 2;
            this.grp_Rgroup.TabStop = false;
            this.grp_Rgroup.Text = "Return";
            // 
            // txtRname
            // 
            this.txtRname.Enabled = false;
            this.txtRname.Location = new System.Drawing.Point(26, 64);
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(331, 25);
            this.txtRname.TabIndex = 27;
            // 
            // cboRborrowerId
            // 
            this.cboRborrowerId.Enabled = false;
            this.cboRborrowerId.Location = new System.Drawing.Point(35, 64);
            this.cboRborrowerId.Name = "cboRborrowerId";
            this.cboRborrowerId.Size = new System.Drawing.Size(65, 25);
            this.cboRborrowerId.TabIndex = 30;
            // 
            // txtRbookTitle
            // 
            this.txtRbookTitle.Enabled = false;
            this.txtRbookTitle.Location = new System.Drawing.Point(26, 112);
            this.txtRbookTitle.Name = "txtRbookTitle";
            this.txtRbookTitle.Size = new System.Drawing.Size(331, 25);
            this.txtRbookTitle.TabIndex = 29;
            // 
            // txtRauthor
            // 
            this.txtRauthor.Enabled = false;
            this.txtRauthor.Location = new System.Drawing.Point(26, 160);
            this.txtRauthor.Name = "txtRauthor";
            this.txtRauthor.Size = new System.Drawing.Size(331, 25);
            this.txtRauthor.TabIndex = 27;
            // 
            // txtRdescription
            // 
            this.txtRdescription.Enabled = false;
            this.txtRdescription.Location = new System.Drawing.Point(25, 208);
            this.txtRdescription.Multiline = true;
            this.txtRdescription.Name = "txtRdescription";
            this.txtRdescription.Size = new System.Drawing.Size(331, 123);
            this.txtRdescription.TabIndex = 27;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbl_accessionNo);
            this.GroupBox2.Controls.Add(this.lbl_transid);
            this.GroupBox2.Controls.Add(this.lbl_borrowerId);
            this.GroupBox2.Location = new System.Drawing.Point(515, 116);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(25, 10);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ID\'s Secret";
            // 
            // lbl_accessionNo
            // 
            this.lbl_accessionNo.AutoSize = true;
            this.lbl_accessionNo.Location = new System.Drawing.Point(56, 42);
            this.lbl_accessionNo.Name = "lbl_accessionNo";
            this.lbl_accessionNo.Size = new System.Drawing.Size(88, 17);
            this.lbl_accessionNo.TabIndex = 5;
            this.lbl_accessionNo.Text = "Accession #  :";
            // 
            // lbl_transid
            // 
            this.lbl_transid.AutoSize = true;
            this.lbl_transid.Location = new System.Drawing.Point(59, 59);
            this.lbl_transid.Name = "lbl_transid";
            this.lbl_transid.Size = new System.Drawing.Size(48, 17);
            this.lbl_transid.TabIndex = 24;
            this.lbl_transid.Text = "transid";
            // 
            // lbl_borrowerId
            // 
            this.lbl_borrowerId.AutoSize = true;
            this.lbl_borrowerId.Location = new System.Drawing.Point(56, 25);
            this.lbl_borrowerId.Name = "lbl_borrowerId";
            this.lbl_borrowerId.Size = new System.Drawing.Size(78, 17);
            this.lbl_borrowerId.TabIndex = 21;
            this.lbl_borrowerId.Text = "borrower id";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(22, 44);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(108, 17);
            this.Label18.TabIndex = 19;
            this.Label18.Text = "Borrower Name :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(23, 188);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 17);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Description :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 140);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Author :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(23, 92);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 17);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Book Title :";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lbl_Rduedate);
            this.GroupBox5.Controls.Add(this.lbl_rpayments);
            this.GroupBox5.Controls.Add(this.lbl_Rchange);
            this.GroupBox5.Controls.Add(this.Label24);
            this.GroupBox5.Controls.Add(this.Label23);
            this.GroupBox5.Controls.Add(this.txt_RtenAmount);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label21);
            this.GroupBox5.Location = new System.Drawing.Point(506, 144);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(45, 25);
            this.GroupBox5.TabIndex = 4;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "do not touch.Time and Days for the future used. ";
            // 
            // lbl_Rduedate
            // 
            this.lbl_Rduedate.AutoSize = true;
            this.lbl_Rduedate.Location = new System.Drawing.Point(71, 26);
            this.lbl_Rduedate.Name = "lbl_Rduedate";
            this.lbl_Rduedate.Size = new System.Drawing.Size(53, 17);
            this.lbl_Rduedate.TabIndex = 7;
            this.lbl_Rduedate.Text = "Label25";
            // 
            // lbl_rpayments
            // 
            this.lbl_rpayments.AutoSize = true;
            this.lbl_rpayments.Location = new System.Drawing.Point(71, 52);
            this.lbl_rpayments.Name = "lbl_rpayments";
            this.lbl_rpayments.Size = new System.Drawing.Size(53, 17);
            this.lbl_rpayments.TabIndex = 4;
            this.lbl_rpayments.Text = "Label25";
            // 
            // lbl_Rchange
            // 
            this.lbl_Rchange.AutoSize = true;
            this.lbl_Rchange.Location = new System.Drawing.Point(75, 122);
            this.lbl_Rchange.Name = "lbl_Rchange";
            this.lbl_Rchange.Size = new System.Drawing.Size(53, 17);
            this.lbl_Rchange.TabIndex = 6;
            this.lbl_Rchange.Text = "Label26";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(15, 122);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(59, 17);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "Change :";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(6, 87);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(119, 17);
            this.Label23.TabIndex = 3;
            this.Label23.Text = "Tendered Amount :";
            // 
            // txt_RtenAmount
            // 
            this.txt_RtenAmount.Location = new System.Drawing.Point(132, 84);
            this.txt_RtenAmount.Name = "txt_RtenAmount";
            this.txt_RtenAmount.Size = new System.Drawing.Size(177, 25);
            this.txt_RtenAmount.TabIndex = 2;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(6, 52);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(70, 17);
            this.Label22.TabIndex = 1;
            this.Label22.Text = "Payments :";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 26);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(70, 17);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "Over Due :";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(27, 67);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(84, 17);
            this.Label25.TabIndex = 22;
            this.Label25.Text = "Borrower Id :";
            this.Label25.Visible = false;
            // 
            // txtRCopyBorrowed
            // 
            this.txtRCopyBorrowed.Enabled = false;
            this.txtRCopyBorrowed.Location = new System.Drawing.Point(26, 254);
            this.txtRCopyBorrowed.Name = "txtRCopyBorrowed";
            this.txtRCopyBorrowed.Size = new System.Drawing.Size(147, 25);
            this.txtRCopyBorrowed.TabIndex = 27;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(189, 211);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(77, 17);
            this.Label14.TabIndex = 11;
            this.Label14.Text = "Return Qty :";
            this.Label14.Visible = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(22, 237);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(157, 17);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "No. of Copies Borrowed :";
            // 
            // txtRRqty
            // 
            this.txtRRqty.Location = new System.Drawing.Point(192, 231);
            this.txtRRqty.Name = "txtRRqty";
            this.txtRRqty.Size = new System.Drawing.Size(113, 25);
            this.txtRRqty.TabIndex = 8;
            this.txtRRqty.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(651, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(522, 376);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_Rsave
            // 
            this.btn_Rsave.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Rsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rsave.Location = new System.Drawing.Point(398, 376);
            this.btn_Rsave.Name = "btn_Rsave";
            this.btn_Rsave.Size = new System.Drawing.Size(118, 37);
            this.btn_Rsave.TabIndex = 0;
            this.btn_Rsave.Text = "Return";
            this.btn_Rsave.UseVisualStyleBackColor = false;
            this.btn_Rsave.Click += new System.EventHandler(this.btn_Rsave_Click);
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.Label4);
            this.TabPage6.Controls.Add(this.txtrbooksSearch);
            this.TabPage6.Controls.Add(this.dtgListreturned);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(806, 455);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "Returned Books";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(413, 424);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 25);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Search :";
            // 
            // txtrbooksSearch
            // 
            this.txtrbooksSearch.BackColor = System.Drawing.Color.White;
            this.txtrbooksSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrbooksSearch.Location = new System.Drawing.Point(505, 419);
            this.txtrbooksSearch.Name = "txtrbooksSearch";
            this.txtrbooksSearch.Size = new System.Drawing.Size(295, 30);
            this.txtrbooksSearch.TabIndex = 1;
            this.txtrbooksSearch.TextChanged += new System.EventHandler(this.txtrbooksSearch_TextChanged);
            // 
            // dtgListreturned
            // 
            this.dtgListreturned.AllowUserToAddRows = false;
            this.dtgListreturned.AllowUserToDeleteRows = false;
            this.dtgListreturned.AllowUserToResizeColumns = false;
            this.dtgListreturned.AllowUserToResizeRows = false;
            this.dtgListreturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListreturned.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListreturned.Location = new System.Drawing.Point(6, 6);
            this.dtgListreturned.Name = "dtgListreturned";
            this.dtgListreturned.RowHeadersVisible = false;
            this.dtgListreturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListreturned.Size = new System.Drawing.Size(794, 407);
            this.dtgListreturned.TabIndex = 0;
            // 
            // frmReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 505);
            this.Controls.Add(this.TabControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returned";
            this.Load += new System.EventHandler(this.frmReturned_Load);
            this.TabControl3.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RlistReturn)).EndInit();
            this.grp_Rgroup.ResumeLayout(false);
            this.grp_Rgroup.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer check_due;
        internal System.Windows.Forms.TabControl TabControl3;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtSearchPborrower;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DataGridView dtg_RlistReturn;
        internal System.Windows.Forms.GroupBox grp_Rgroup;
        internal System.Windows.Forms.TextBox txtRname;
        internal System.Windows.Forms.TextBox cboRborrowerId;
        internal System.Windows.Forms.TextBox txtRbookTitle;
        internal System.Windows.Forms.TextBox txtRauthor;
        internal System.Windows.Forms.TextBox txtRdescription;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbl_accessionNo;
        internal System.Windows.Forms.Label lbl_transid;
        internal System.Windows.Forms.Label lbl_borrowerId;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label lbl_Rduedate;
        internal System.Windows.Forms.Label lbl_rpayments;
        internal System.Windows.Forms.Label lbl_Rchange;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txt_RtenAmount;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox txtRCopyBorrowed;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtRRqty;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btn_Rsave;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtrbooksSearch;
        internal System.Windows.Forms.DataGridView dtgListreturned;
    }
}