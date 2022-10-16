using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SEN_Project.PresentationLayer;

namespace SEN_Project.DataLayer
{
    public class DatabaseController
    {
        public const string ConnectionString = @"Data Source=DESKTOP-M2MPA17\SQLEXPRESS;Initial Catalog=Healthcare_Database;Integrated Security=True";
        SqlConnection Con;

        public static DatabaseController current;
        public DatabaseController   ()
        {
            current = this;
            Con = new SqlConnection(ConnectionString);
        }

        public    DataTable GetSource   (string DBName)
        {
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM " + DBName, Con);
            //SqlDataReader Reader = cmd.ExecuteReader();
            //Con.Close();
            //return Reader;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + DBName, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public  bool    ExecuteCommand  (string Command)
        {
            try
            {
                SqlCommand comm = new SqlCommand(Command, Con);
                Con.Open();
                comm.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception e)
            {
                PresentationController.current.ShowError(e.Message);
                return false;
            }
        }

        public  DataTable   GetTable    (string Command)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(Command, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                PresentationController.current.ShowError(e.Message);
                return null;
            }
        }
    }
}
