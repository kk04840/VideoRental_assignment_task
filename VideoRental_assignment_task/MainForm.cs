using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_assignment_task
{
    public partial class MainForm : Form
    {
        Logic logic = new Logic();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            //visible the group box 
            CustomerGRP.Visible = true;

        }

        private void btnLoadRental_Click(object sender, EventArgs e)
        {
           //visible the group box 
            RentalGRP.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //visible the group box 
            MovieGrp.Visible = true;
        }

        private void CAdd_Click(object sender, EventArgs e)
        {
            try {
                //here we need to verify the details of the customer to store in to the database 
                if (!Cus_Name.Text.ToString().Equals("") && !Cus_Mobile.Text.ToString().Equals("") && !Cus_Address.Text.ToString().Equals("")) {
                    // if the fields are filled then we can enter the record into the field
                    logic.Name = Cus_Name.Text.ToString();
                    logic.Phone = Cus_Mobile.Text.ToString();
                    logic.Address = Cus_Address.Text.ToString();
                    /// here now need to fill the record into the database 
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to save the record ","Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "insert into customerField(Name,Phone,Address)values('"+logic.Name+"','"+logic.Phone+"','"+logic.Address+"')";
                        logic.CmdIns(qry);
                        
                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Saved ");
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        Cus_Name.Text = "";

                    }
                    else
                    {
                       
                    }

                }

            }
            catch (Exception ex) { 
            
            }
        }

        private void CDelete_Click(object sender, EventArgs e)
        {
            try {
                if (!CustomerID.Text.Equals("")) {

                    // here we need to get the id of the customer for delete 
                    logic.ID = Convert.ToInt32(CustomerID.Text);
                    /// here now need to fill the record into the database 
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete the record ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "delete from customerField where ID="+logic.ID+"";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Deleted ");
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        Cus_Name.Text = "";

                    }
                    else
                    {

                    }


                }
            }
            catch (Exception es) { 
            
            }


        }

        private void CUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //here we need to verify the details of the customer to store in to the database 
                if (!CustomerID.Text.Equals("") && !Cus_Name.Text.ToString().Equals("") && !Cus_Mobile.Text.ToString().Equals("") && !Cus_Address.Text.ToString().Equals(""))
                {
                    // if the fields are filled then we can enter the record into the field
                    logic.ID = Convert.ToInt32(CustomerID.Text);
                    logic.Name = Cus_Name.Text.ToString();
                    logic.Phone = Cus_Mobile.Text.ToString();
                    logic.Address = Cus_Address.Text.ToString();
                    /// here now need to fill the record into the database 
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Update the record ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "update customerField set Name='" + logic.Name + "',Phone='" + logic.Phone + "',Address='" + logic.Address + "' where ID="+logic.ID+"";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Updated ");
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        Cus_Name.Text = "";
                        CustomerID.Text = "";

                    }
                    else
                    {

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }


        }

        // button for adding videos in database

        private void Video_Add_Click(object sender, EventArgs e)
        {
            try {
                if (!Vtitle.Text.Equals("") && !VRatting.Text.Equals("") && !VYear.Text.Equals("") && !VCopies.Text.Equals("") && !Vcost.Text.Equals("") && !VPlot.Text.Equals("") && !VGenre.Text.Equals("")) {
                    
                    logic.title = Vtitle.Text;
                    logic.ratting = VRatting.Text;
                    logic.year = Convert.ToInt32(VYear.Text);
                    logic.copies = Convert.ToInt32(VCopies.Text);
                    logic.cost = Convert.ToInt32(Vcost.Text);
                    logic.plot = VPlot.Text;
                    logic.genre = VGenre.Text;

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Save the record ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "insert into VideoField(title,ratting,year,cost,copies,plot,genre)values('"+logic.title+"','"+logic.ratting+"',"+logic.year+","+logic.cost+","+logic.copies+",'"+logic.plot+"','"+logic.genre+"')";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Updated ");
                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";



                    }
                    else
                    {

                    }




                }
                else {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("You Need to fill all fields ");
            }
        }

        // delete video from database

        private void del_Video_Click(object sender, EventArgs e)
        {

            try
            {
                if (MovieID.Text.Equals("") && !Vtitle.Text.Equals("") && !VRatting.Text.Equals("") && !VYear.Text.Equals("") && !VCopies.Text.Equals("") && !Vcost.Text.Equals("") && !VPlot.Text.Equals("") && !VGenre.Text.Equals(""))
                {

                    logic.VidID = Convert.ToInt32(MovieID.Text);
                    logic.title = Vtitle.Text;
                    logic.ratting = VRatting.Text;
                    logic.year = Convert.ToInt32(VYear.Text);
                    logic.copies = Convert.ToInt32(VCopies.Text);
                    logic.cost = Convert.ToInt32(Vcost.Text);
                    logic.plot = VPlot.Text;
                    logic.genre = VGenre.Text;

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete the record ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "delete from VideoField where VidID="+logic.VidID+"";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Deleted ");
                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";



                    }
                    else
                    {

                    }




                }
                else
                {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }

        }

        // this button will update video from database

        private void update_Video_Click(object sender, EventArgs e)
        {

            try
            {
                if (MovieID.Text.Equals("") && !Vtitle.Text.Equals("") && !VRatting.Text.Equals("") && !VYear.Text.Equals("") && !VCopies.Text.Equals("") && !Vcost.Text.Equals("") && !VPlot.Text.Equals("") && !VGenre.Text.Equals(""))
                {

                    logic.VidID = Convert.ToInt32(MovieID.Text);
                    logic.title = Vtitle.Text;
                    logic.ratting = VRatting.Text;
                    logic.year = Convert.ToInt32(VYear.Text);
                    logic.copies = Convert.ToInt32(VCopies.Text);
                    logic.cost = Convert.ToInt32(Vcost.Text);
                    logic.plot = VPlot.Text;
                    logic.genre = VGenre.Text;

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete the record ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "update VideoField set title='"+logic.title+"',ratting='"+logic.ratting+"',year="+logic.year+",cost="+logic.cost+",copies="+logic.copies+",plot='"+logic.plot+"',genre='"+logic.genre+ "' where VidID=" + logic.VidID + "";

                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Record is Deleted ");
                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";



                    }
                    else
                    {

                    }




                }
                else
                {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }


        }

        // this button will issue a movie on rent and logic is set accoding the conditions

        private void Rental_Issue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CustomerID.Text.Equals("") && !MovieID.Text.Equals(""))
                {
                    logic.ID = Convert.ToInt32(CustomerID.Text);
                    logic.VidID= Convert.ToInt32(MovieID.Text);
                    logic.bookVideo = IssueVideoDT.Text;
                    logic.returnVideo = "Book";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Book the Video ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "insert into BookField(CusID,VidID,BookVideo,ReturnVideo)values(" + logic.ID + "," + logic.VidID + ",'" + logic.bookVideo + "','"+logic.returnVideo+"')";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Video is Booked ");
                        
                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";

                        Cus_Name.Text = "";
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        CustomerID.Text = "";



                    }
                    else
                    {

                    }




                }
                else
                {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }


        }

        // this button will delete video from database 

        private void Rental_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (logic.BookID>0)
                {
                    logic.ID = Convert.ToInt32(CustomerID.Text);
                    logic.VidID = Convert.ToInt32(MovieID.Text);
                    logic.bookVideo = IssueVideoDT.Text;
                    logic.returnVideo = "Book";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the Booking  Video ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "delete from BookField where BookID="+logic.BookID+"";
                        logic.CmdIns(qry);

                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Booked Video is Deleted  ");

                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";

                        Cus_Name.Text = "";
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        CustomerID.Text = "";



                    }
                    else
                    {

                    }




                }
                else
                {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }


        }

        // this button will return videos that are issued and logic is set according to that it will show the price 

        private void Rental_Return_Click(object sender, EventArgs e)
        {
            try
            {
                if (logic.BookID>0 && !CustomerID.Text.Equals("") && !MovieID.Text.Equals(""))
                {
                    logic.ID = Convert.ToInt32(CustomerID.Text);
                    logic.VidID = Convert.ToInt32(MovieID.Text);
                    logic.bookVideo = IssueVideoDT.Text;
                    logic.returnVideo =ReturnVideoDT.Text;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Book the Video ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        String qry = "update  BookField set CusID="+logic.ID+",VidID="+logic.VidID+",BookVideo='"+logic.bookVideo+"',ReturnVideo='"+logic.returnVideo+ "' where BookID=" + logic.BookID + "";
                        logic.CmdIns(qry);

                        DateTime nw = DateTime.Now;

                        DateTime old =Convert.ToDateTime(IssueVideoDT.Text);

                        String diff = (nw - old).TotalDays.ToString();

                        Double DaysInterval = Math.Round(Convert.ToDouble(diff));

                        DataTable tbl = new DataTable();
                        tbl = logic.Entries("select * from VideoField where VidID=" + Convert.ToInt32(MovieID.Text) + "");
                        int cost =Convert.ToInt32(tbl.Rows[0]["cost"].ToString());
                        //here we need to enter the code to insert the record .
                        MessageBox.Show("Video is Returned and Bill is $"+(DaysInterval*cost));

                        MovieID.Text = "";
                        Vtitle.Text = "";
                        VRatting.Text = "";
                        VYear.Text = "";
                        VCopies.Text = "";
                        Vcost.Text = "";
                        VPlot.Text = "";
                        VGenre.Text = "";

                        Cus_Name.Text = "";
                        Cus_Address.Text = "";
                        Cus_Mobile.Text = "";
                        CustomerID.Text = "";



                    }
                    else
                    {

                    }




                }
                else
                {
                    MessageBox.Show("You Need to fill all fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Need to fill all fields ");
            }

        }

        // in grid view it will print customer record 


        private void btnCustomerRecord_Click(object sender, EventArgs e)
        {
            logic.optionId = 1;

            DataTable tblCustomer = new DataTable();
            tblCustomer = logic.Entries("select * from customerField");
            Show_Record.DataSource = tblCustomer;
        }

        private void btnVideoRecord_Click(object sender, EventArgs e)
        {
            logic.optionId = 3;
            DataTable tblVideo = new DataTable();
            tblVideo = logic.Entries("select * from VideoField");
            Show_Record.DataSource = tblVideo;
        }

        private void btnRentalRecord_Click(object sender, EventArgs e)
        {
            logic.optionId = 2;

            DataTable tblBook= new DataTable();
            tblBook = logic.Entries("select * from BookField");
            Show_Record.DataSource = tblBook;
        }

        private void Show_Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (logic.optionId) {
                case 1:
                    //for the customer record 

                    CustomerID.Text = Show_Record.CurrentRow.Cells[0].Value.ToString();
                    Cus_Name.Text = Show_Record.CurrentRow.Cells[1].Value.ToString();
                    Cus_Mobile.Text = Show_Record.CurrentRow.Cells[2].Value.ToString();
                    Cus_Address.Text = Show_Record.CurrentRow.Cells[3].Value.ToString();
                    break;

                case 2:
                    logic.BookID = Convert.ToInt32(Show_Record.CurrentRow.Cells[0].Value.ToString());
                    CustomerID.Text = Show_Record.CurrentRow.Cells[1].Value.ToString();
                    MovieID.Text = Show_Record.CurrentRow.Cells[2].Value.ToString();
                    IssueVideoDT.Text = Show_Record.CurrentRow.Cells[3].Value.ToString();

                    break;

                case 3:
                   MovieID.Text = Show_Record.CurrentRow.Cells[0].Value.ToString();
                    Vtitle.Text = Show_Record.CurrentRow.Cells[1].Value.ToString();
                    VRatting.Text = Show_Record.CurrentRow.Cells[2].Value.ToString();
                    VYear.Text = Show_Record.CurrentRow.Cells[3].Value.ToString();
                    Vcost.Text = Show_Record.CurrentRow.Cells[4].Value.ToString();
                    VCopies.Text = Show_Record.CurrentRow.Cells[5].Value.ToString();
                    VPlot.Text = Show_Record.CurrentRow.Cells[6].Value.ToString();
                    VGenre.Text = Show_Record.CurrentRow.Cells[7].Value.ToString();

                    break;

            }

            logic.optionId = 0;
        }

        private void VYear_TextChanged(object sender, EventArgs e)
        {
            try {
                
                //get the date 
                int yr = Convert.ToInt32(VYear.Text.ToString());
                DateTime dt =DateTime.Now;

                int curnt = dt.Year;
                if ((curnt - yr) > 5)
                {
                    Vcost.Text = "2";
                }
                else {
                    Vcost.Text = "5";
                }
            }
            catch (Exception ex) { 
            
            }
        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();

            tblvideo = logic.Entries("select * from customerField");


            while (x < tblvideo.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental = logic.Entries("select * from BookField where CusID=" + Convert.ToInt32(tblvideo.Rows[x]["ID"]) + "");


                if (Rental.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["Name"].ToString();
                    cunt = Rental.Rows.Count;

                }
                x++;
            }


            MessageBox.Show("Best Movie Name   is ==" + Title);




        }

        // best movie logic given below

        private void btnBestMovie_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();

            tblvideo =logic.Entries("select * from VideoField");


            while (x < tblvideo.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental = logic.Entries("select * from BookField where VidID=" + Convert.ToInt32(tblvideo.Rows[x]["VidID"]) + "");


                if (Rental.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["title"].ToString();
                    cunt = Rental.Rows.Count;

                }
                x++;
            }


            MessageBox.Show("Best Movie Name   is ==" + Title);


        }
    }
}
