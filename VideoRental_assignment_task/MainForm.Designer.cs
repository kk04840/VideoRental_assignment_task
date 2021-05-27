
namespace VideoRental_assignment_task
{
    partial class MainForm
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
            this.Video_Add = new System.Windows.Forms.Button();
            this.VGenre = new System.Windows.Forms.TextBox();
            this.VPlot = new System.Windows.Forms.TextBox();
            this.VCopies = new System.Windows.Forms.TextBox();
            this.VYear = new System.Windows.Forms.TextBox();
            this.VRatting = new System.Windows.Forms.TextBox();
            this.Vtitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RentPK = new System.Windows.Forms.Label();
            this.btnBestMovie = new System.Windows.Forms.Button();
            this.btnVideoRecord = new System.Windows.Forms.Button();
            this.btnRentalRecord = new System.Windows.Forms.Button();
            this.btnCustomerRecord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnVideoDT = new System.Windows.Forms.DateTimePicker();
            this.IssueVideoDT = new System.Windows.Forms.DateTimePicker();
            this.Rental_Delete = new System.Windows.Forms.Button();
            this.Rental_Return = new System.Windows.Forms.Button();
            this.Rental_Issue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CustomerGRP = new System.Windows.Forms.GroupBox();
            this.CDelete = new System.Windows.Forms.Button();
            this.CUpdate = new System.Windows.Forms.Button();
            this.CAdd = new System.Windows.Forms.Button();
            this.Cus_Address = new System.Windows.Forms.TextBox();
            this.Cus_Mobile = new System.Windows.Forms.TextBox();
            this.Cus_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.MovieGrp = new System.Windows.Forms.GroupBox();
            this.Vcost = new System.Windows.Forms.TextBox();
            this.del_Video = new System.Windows.Forms.Button();
            this.update_Video = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RentalGRP = new System.Windows.Forms.GroupBox();
            this.btnLoadRental = new System.Windows.Forms.Button();
            this.Show_Record = new System.Windows.Forms.DataGridView();
            this.CustomerGRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.MovieGrp.SuspendLayout();
            this.RentalGRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Record)).BeginInit();
            this.SuspendLayout();
            // 
            // Video_Add
            // 
            this.Video_Add.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_Add.Location = new System.Drawing.Point(8, 302);
            this.Video_Add.Name = "Video_Add";
            this.Video_Add.Size = new System.Drawing.Size(85, 32);
            this.Video_Add.TabIndex = 167;
            this.Video_Add.Text = "Add";
            this.Video_Add.UseVisualStyleBackColor = true;
            this.Video_Add.Click += new System.EventHandler(this.Video_Add_Click);
            // 
            // VGenre
            // 
            this.VGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VGenre.Location = new System.Drawing.Point(126, 246);
            this.VGenre.Name = "VGenre";
            this.VGenre.Size = new System.Drawing.Size(154, 32);
            this.VGenre.TabIndex = 166;
            // 
            // VPlot
            // 
            this.VPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPlot.Location = new System.Drawing.Point(126, 210);
            this.VPlot.Name = "VPlot";
            this.VPlot.Size = new System.Drawing.Size(154, 32);
            this.VPlot.TabIndex = 165;
            // 
            // VCopies
            // 
            this.VCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCopies.Location = new System.Drawing.Point(126, 172);
            this.VCopies.Name = "VCopies";
            this.VCopies.Size = new System.Drawing.Size(154, 32);
            this.VCopies.TabIndex = 164;
            // 
            // VYear
            // 
            this.VYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VYear.Location = new System.Drawing.Point(126, 98);
            this.VYear.Name = "VYear";
            this.VYear.Size = new System.Drawing.Size(154, 32);
            this.VYear.TabIndex = 163;
            this.VYear.TextChanged += new System.EventHandler(this.VYear_TextChanged);
            // 
            // VRatting
            // 
            this.VRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VRatting.Location = new System.Drawing.Point(126, 60);
            this.VRatting.Name = "VRatting";
            this.VRatting.Size = new System.Drawing.Size(154, 32);
            this.VRatting.TabIndex = 162;
            // 
            // Vtitle
            // 
            this.Vtitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vtitle.Location = new System.Drawing.Point(126, 22);
            this.Vtitle.Name = "Vtitle";
            this.Vtitle.Size = new System.Drawing.Size(154, 32);
            this.Vtitle.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 160;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 159;
            this.label6.Text = "Plot";
            // 
            // RentPK
            // 
            this.RentPK.AutoSize = true;
            this.RentPK.BackColor = System.Drawing.Color.Transparent;
            this.RentPK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentPK.ForeColor = System.Drawing.Color.White;
            this.RentPK.Location = new System.Drawing.Point(27, 246);
            this.RentPK.Name = "RentPK";
            this.RentPK.Size = new System.Drawing.Size(0, 24);
            this.RentPK.TabIndex = 140;
            this.RentPK.Visible = false;
            // 
            // btnBestMovie
            // 
            this.btnBestMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBestMovie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestMovie.ForeColor = System.Drawing.Color.White;
            this.btnBestMovie.Location = new System.Drawing.Point(60, 355);
            this.btnBestMovie.Name = "btnBestMovie";
            this.btnBestMovie.Size = new System.Drawing.Size(210, 38);
            this.btnBestMovie.TabIndex = 23;
            this.btnBestMovie.Text = "Best Movie";
            this.btnBestMovie.UseVisualStyleBackColor = false;
            this.btnBestMovie.Click += new System.EventHandler(this.btnBestMovie_Click);
            // 
            // btnVideoRecord
            // 
            this.btnVideoRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVideoRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoRecord.ForeColor = System.Drawing.Color.White;
            this.btnVideoRecord.Location = new System.Drawing.Point(663, 403);
            this.btnVideoRecord.Name = "btnVideoRecord";
            this.btnVideoRecord.Size = new System.Drawing.Size(299, 38);
            this.btnVideoRecord.TabIndex = 21;
            this.btnVideoRecord.Text = "Video Record";
            this.btnVideoRecord.UseVisualStyleBackColor = false;
            this.btnVideoRecord.Click += new System.EventHandler(this.btnVideoRecord_Click);
            // 
            // btnRentalRecord
            // 
            this.btnRentalRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRentalRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalRecord.ForeColor = System.Drawing.Color.White;
            this.btnRentalRecord.Location = new System.Drawing.Point(338, 403);
            this.btnRentalRecord.Name = "btnRentalRecord";
            this.btnRentalRecord.Size = new System.Drawing.Size(299, 38);
            this.btnRentalRecord.TabIndex = 20;
            this.btnRentalRecord.Text = "Rental Record";
            this.btnRentalRecord.UseVisualStyleBackColor = false;
            this.btnRentalRecord.Click += new System.EventHandler(this.btnRentalRecord_Click);
            // 
            // btnCustomerRecord
            // 
            this.btnCustomerRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomerRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecord.Location = new System.Drawing.Point(12, 403);
            this.btnCustomerRecord.Name = "btnCustomerRecord";
            this.btnCustomerRecord.Size = new System.Drawing.Size(299, 38);
            this.btnCustomerRecord.TabIndex = 19;
            this.btnCustomerRecord.Text = "Customer Record";
            this.btnCustomerRecord.UseVisualStyleBackColor = false;
            this.btnCustomerRecord.Click += new System.EventHandler(this.btnCustomerRecord_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 158;
            this.label5.Text = "Copies";
            // 
            // MovieID
            // 
            this.MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieID.Location = new System.Drawing.Point(154, 52);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(154, 32);
            this.MovieID.TabIndex = 139;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(154, 14);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(154, 32);
            this.CustomerID.TabIndex = 138;
            // 
            // ReturnVideoDT
            // 
            this.ReturnVideoDT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideoDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideoDT.Location = new System.Drawing.Point(154, 128);
            this.ReturnVideoDT.Name = "ReturnVideoDT";
            this.ReturnVideoDT.Size = new System.Drawing.Size(154, 32);
            this.ReturnVideoDT.TabIndex = 137;
            // 
            // IssueVideoDT
            // 
            this.IssueVideoDT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideoDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideoDT.Location = new System.Drawing.Point(154, 90);
            this.IssueVideoDT.Name = "IssueVideoDT";
            this.IssueVideoDT.Size = new System.Drawing.Size(154, 32);
            this.IssueVideoDT.TabIndex = 136;
            // 
            // Rental_Delete
            // 
            this.Rental_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_Delete.Location = new System.Drawing.Point(21, 201);
            this.Rental_Delete.Name = "Rental_Delete";
            this.Rental_Delete.Size = new System.Drawing.Size(274, 37);
            this.Rental_Delete.TabIndex = 135;
            this.Rental_Delete.Text = "Delete";
            this.Rental_Delete.UseVisualStyleBackColor = true;
            this.Rental_Delete.Click += new System.EventHandler(this.Rental_Delete_Click);
            // 
            // Rental_Return
            // 
            this.Rental_Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_Return.Location = new System.Drawing.Point(141, 163);
            this.Rental_Return.Name = "Rental_Return";
            this.Rental_Return.Size = new System.Drawing.Size(154, 32);
            this.Rental_Return.TabIndex = 134;
            this.Rental_Return.Text = "Return";
            this.Rental_Return.UseVisualStyleBackColor = true;
            this.Rental_Return.Click += new System.EventHandler(this.Rental_Return_Click);
            // 
            // Rental_Issue
            // 
            this.Rental_Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_Issue.Location = new System.Drawing.Point(19, 163);
            this.Rental_Issue.Name = "Rental_Issue";
            this.Rental_Issue.Size = new System.Drawing.Size(101, 32);
            this.Rental_Issue.TabIndex = 133;
            this.Rental_Issue.Text = "Issue";
            this.Rental_Issue.UseVisualStyleBackColor = true;
            this.Rental_Issue.Click += new System.EventHandler(this.Rental_Issue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 132;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 131;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 130;
            this.label14.Text = "Movie ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 156;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 155;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 154;
            this.label16.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 157;
            this.label4.Text = "Cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 129;
            this.label15.Text = "Customer ID";
            // 
            // CustomerGRP
            // 
            this.CustomerGRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CustomerGRP.Controls.Add(this.CDelete);
            this.CustomerGRP.Controls.Add(this.CUpdate);
            this.CustomerGRP.Controls.Add(this.CAdd);
            this.CustomerGRP.Controls.Add(this.Cus_Address);
            this.CustomerGRP.Controls.Add(this.Cus_Mobile);
            this.CustomerGRP.Controls.Add(this.Cus_Name);
            this.CustomerGRP.Controls.Add(this.label8);
            this.CustomerGRP.Controls.Add(this.label9);
            this.CustomerGRP.Controls.Add(this.label11);
            this.CustomerGRP.Location = new System.Drawing.Point(13, 57);
            this.CustomerGRP.Name = "CustomerGRP";
            this.CustomerGRP.Size = new System.Drawing.Size(282, 236);
            this.CustomerGRP.TabIndex = 13;
            this.CustomerGRP.TabStop = false;
            this.CustomerGRP.Text = "Customer";
            this.CustomerGRP.Visible = false;
            // 
            // CDelete
            // 
            this.CDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDelete.Location = new System.Drawing.Point(12, 185);
            this.CDelete.Name = "CDelete";
            this.CDelete.Size = new System.Drawing.Size(245, 45);
            this.CDelete.TabIndex = 125;
            this.CDelete.Text = "Delete";
            this.CDelete.UseVisualStyleBackColor = true;
            this.CDelete.Click += new System.EventHandler(this.CDelete_Click);
            // 
            // CUpdate
            // 
            this.CUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUpdate.Location = new System.Drawing.Point(132, 147);
            this.CUpdate.Name = "CUpdate";
            this.CUpdate.Size = new System.Drawing.Size(125, 32);
            this.CUpdate.TabIndex = 124;
            this.CUpdate.Text = "Update";
            this.CUpdate.UseVisualStyleBackColor = true;
            this.CUpdate.Click += new System.EventHandler(this.CUpdate_Click);
            // 
            // CAdd
            // 
            this.CAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAdd.Location = new System.Drawing.Point(10, 147);
            this.CAdd.Name = "CAdd";
            this.CAdd.Size = new System.Drawing.Size(104, 32);
            this.CAdd.TabIndex = 121;
            this.CAdd.Text = "Add";
            this.CAdd.UseVisualStyleBackColor = true;
            this.CAdd.Click += new System.EventHandler(this.CAdd_Click);
            // 
            // Cus_Address
            // 
            this.Cus_Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Address.Location = new System.Drawing.Point(132, 103);
            this.Cus_Address.Name = "Cus_Address";
            this.Cus_Address.Size = new System.Drawing.Size(125, 32);
            this.Cus_Address.TabIndex = 123;
            // 
            // Cus_Mobile
            // 
            this.Cus_Mobile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Mobile.Location = new System.Drawing.Point(132, 64);
            this.Cus_Mobile.Name = "Cus_Mobile";
            this.Cus_Mobile.Size = new System.Drawing.Size(125, 32);
            this.Cus_Mobile.TabIndex = 122;
            // 
            // Cus_Name
            // 
            this.Cus_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Name.Location = new System.Drawing.Point(132, 26);
            this.Cus_Name.Name = "Cus_Name";
            this.Cus_Name.Size = new System.Drawing.Size(125, 32);
            this.Cus_Name.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 119;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 118;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 117;
            this.label11.Text = " Name";
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btnLoadCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.Size = new System.Drawing.Size(211, 38);
            this.btnLoadCustomer.TabIndex = 12;
            this.btnLoadCustomer.Text = "Customer Field";
            this.btnLoadCustomer.UseVisualStyleBackColor = false;
            this.btnLoadCustomer.Click += new System.EventHandler(this.btnLoadCustomer_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBestCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(59, 311);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(211, 38);
            this.btnBestCustomer.TabIndex = 22;
            this.btnBestCustomer.Text = "Best Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // MovieGrp
            // 
            this.MovieGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MovieGrp.Controls.Add(this.Vcost);
            this.MovieGrp.Controls.Add(this.del_Video);
            this.MovieGrp.Controls.Add(this.update_Video);
            this.MovieGrp.Controls.Add(this.Video_Add);
            this.MovieGrp.Controls.Add(this.VGenre);
            this.MovieGrp.Controls.Add(this.VPlot);
            this.MovieGrp.Controls.Add(this.VCopies);
            this.MovieGrp.Controls.Add(this.VYear);
            this.MovieGrp.Controls.Add(this.VRatting);
            this.MovieGrp.Controls.Add(this.Vtitle);
            this.MovieGrp.Controls.Add(this.label7);
            this.MovieGrp.Controls.Add(this.label6);
            this.MovieGrp.Controls.Add(this.label5);
            this.MovieGrp.Controls.Add(this.label4);
            this.MovieGrp.Controls.Add(this.label3);
            this.MovieGrp.Controls.Add(this.label2);
            this.MovieGrp.Controls.Add(this.label16);
            this.MovieGrp.Location = new System.Drawing.Point(655, 56);
            this.MovieGrp.Name = "MovieGrp";
            this.MovieGrp.Size = new System.Drawing.Size(307, 348);
            this.MovieGrp.TabIndex = 17;
            this.MovieGrp.TabStop = false;
            this.MovieGrp.Text = "Videos";
            this.MovieGrp.Visible = false;
            // 
            // Vcost
            // 
            this.Vcost.Enabled = false;
            this.Vcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vcost.Location = new System.Drawing.Point(126, 135);
            this.Vcost.Name = "Vcost";
            this.Vcost.Size = new System.Drawing.Size(154, 32);
            this.Vcost.TabIndex = 170;
            // 
            // del_Video
            // 
            this.del_Video.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_Video.Location = new System.Drawing.Point(190, 302);
            this.del_Video.Name = "del_Video";
            this.del_Video.Size = new System.Drawing.Size(85, 32);
            this.del_Video.TabIndex = 169;
            this.del_Video.Text = "Delete";
            this.del_Video.UseVisualStyleBackColor = true;
            this.del_Video.Click += new System.EventHandler(this.del_Video_Click);
            // 
            // update_Video
            // 
            this.update_Video.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Video.Location = new System.Drawing.Point(99, 302);
            this.update_Video.Name = "update_Video";
            this.update_Video.Size = new System.Drawing.Size(85, 32);
            this.update_Video.TabIndex = 168;
            this.update_Video.Text = "Update";
            this.update_Video.UseVisualStyleBackColor = true;
            this.update_Video.Click += new System.EventHandler(this.update_Video_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(724, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Movie Field";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentalGRP
            // 
            this.RentalGRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RentalGRP.Controls.Add(this.RentPK);
            this.RentalGRP.Controls.Add(this.MovieID);
            this.RentalGRP.Controls.Add(this.CustomerID);
            this.RentalGRP.Controls.Add(this.ReturnVideoDT);
            this.RentalGRP.Controls.Add(this.IssueVideoDT);
            this.RentalGRP.Controls.Add(this.Rental_Delete);
            this.RentalGRP.Controls.Add(this.Rental_Return);
            this.RentalGRP.Controls.Add(this.Rental_Issue);
            this.RentalGRP.Controls.Add(this.label12);
            this.RentalGRP.Controls.Add(this.label13);
            this.RentalGRP.Controls.Add(this.label14);
            this.RentalGRP.Controls.Add(this.label15);
            this.RentalGRP.Location = new System.Drawing.Point(310, 57);
            this.RentalGRP.Name = "RentalGRP";
            this.RentalGRP.Size = new System.Drawing.Size(327, 290);
            this.RentalGRP.TabIndex = 15;
            this.RentalGRP.TabStop = false;
            this.RentalGRP.Text = "Rental";
            this.RentalGRP.Visible = false;
            // 
            // btnLoadRental
            // 
            this.btnLoadRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadRental.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRental.ForeColor = System.Drawing.Color.White;
            this.btnLoadRental.Location = new System.Drawing.Point(370, 9);
            this.btnLoadRental.Name = "btnLoadRental";
            this.btnLoadRental.Size = new System.Drawing.Size(211, 38);
            this.btnLoadRental.TabIndex = 14;
            this.btnLoadRental.Text = "Rental Field";
            this.btnLoadRental.UseVisualStyleBackColor = false;
            this.btnLoadRental.Click += new System.EventHandler(this.btnLoadRental_Click);
            // 
            // Show_Record
            // 
            this.Show_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_Record.Location = new System.Drawing.Point(25, 447);
            this.Show_Record.Name = "Show_Record";
            this.Show_Record.Size = new System.Drawing.Size(937, 167);
            this.Show_Record.TabIndex = 18;
            this.Show_Record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_Record_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(974, 626);
            this.Controls.Add(this.btnBestMovie);
            this.Controls.Add(this.btnVideoRecord);
            this.Controls.Add(this.btnRentalRecord);
            this.Controls.Add(this.btnCustomerRecord);
            this.Controls.Add(this.Show_Record);
            this.Controls.Add(this.CustomerGRP);
            this.Controls.Add(this.btnLoadCustomer);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.MovieGrp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RentalGRP);
            this.Controls.Add(this.btnLoadRental);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.CustomerGRP.ResumeLayout(false);
            this.CustomerGRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.MovieGrp.ResumeLayout(false);
            this.MovieGrp.PerformLayout();
            this.RentalGRP.ResumeLayout(false);
            this.RentalGRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Record)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Video_Add;
        private System.Windows.Forms.TextBox VGenre;
        private System.Windows.Forms.TextBox VPlot;
        private System.Windows.Forms.TextBox VCopies;
        private System.Windows.Forms.TextBox VYear;
        private System.Windows.Forms.TextBox VRatting;
        private System.Windows.Forms.TextBox Vtitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RentPK;
        private System.Windows.Forms.Button btnBestMovie;
        private System.Windows.Forms.Button btnVideoRecord;
        private System.Windows.Forms.Button btnRentalRecord;
        private System.Windows.Forms.Button btnCustomerRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnVideoDT;
        private System.Windows.Forms.DateTimePicker IssueVideoDT;
        private System.Windows.Forms.Button Rental_Delete;
        private System.Windows.Forms.Button Rental_Return;
        private System.Windows.Forms.Button Rental_Issue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox CustomerGRP;
        private System.Windows.Forms.Button CDelete;
        private System.Windows.Forms.Button CUpdate;
        private System.Windows.Forms.Button CAdd;
        private System.Windows.Forms.TextBox Cus_Address;
        private System.Windows.Forms.TextBox Cus_Mobile;
        private System.Windows.Forms.TextBox Cus_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.GroupBox MovieGrp;
        private System.Windows.Forms.TextBox Vcost;
        private System.Windows.Forms.Button del_Video;
        private System.Windows.Forms.Button update_Video;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox RentalGRP;
        private System.Windows.Forms.Button btnLoadRental;
        private System.Windows.Forms.DataGridView Show_Record;
    }
}