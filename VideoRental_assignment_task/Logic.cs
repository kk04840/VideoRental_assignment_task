using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_assignment_task
{
   public class Logic
    {
        //here the field attributes to save the details of the member to register
        public int ID { get; set; }
        public int optionId { get; set; }

        public String Name { get; set; }

        public String Phone { get; set; }
        public String Address { get; set; }

        public int VidID { get; set; }
        public String title { get; set; }
        public String ratting { get; set; }
        public int year { get; set; }
        public int copies { get; set; }
        public int cost { get; set; }

        public String plot { get; set; }
        public String genre { get; set; }


        public int BookID { get; set; }
        public String bookVideo { get; set; }
        public String returnVideo { get; set; }


        public SqlConnection dataConn;

        //write the connection sstring to assthe data form one for to the database 
        public String dataloc = "Data Source=DESKTOP-L2UGPMF\\SQLEXPRESS;Initial Catalog=videoRentalTask;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        public SqlCommand dataCmd;

        //data reader is used to read thedata from the database table 
        public SqlDataReader dataReader;


        public void CmdIns(String query)
        {
            dataConn = new SqlConnection(dataloc);
            dataConn.Open();
            dataCmd = new SqlCommand(query, dataConn);
            dataCmd.ExecuteNonQuery();
            dataConn.Close();
        }


        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable Entries(String qry)
        {
            DataTable tbl = new DataTable();

            dataConn = new SqlConnection(dataloc);

            dataConn.Open();

            dataCmd = new SqlCommand(qry, dataConn);

            dataReader =dataCmd.ExecuteReader();

            tbl.Load(dataReader);

            dataConn.Close();

            return tbl;
        }







    }
}
