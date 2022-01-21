using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Menu.BAL;

namespace Menu.DAL
{
    class DataQueries
    {
        public static SqlConnection GetConnection()
        {
            string str = "Data Source = HAIER-PC; Initial Catalog = MediaPlayer;Integrated Security = true;";
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
            } 
            return connection;
        }
        public static void AddMedia(Favourite fav)
        {
            string str = "INSERT INTO Favourite VALUES(@Filename,@Path);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(str, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Filename",fav.FileName);
            command.Parameters.AddWithValue("@Path", fav.Path);

            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
        }
        public static DataSet ReadFileName()
        {
            string str = "SELECT FileName,Path FROM Favourite;";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(str, connection);

            command.CommandType = CommandType.Text;
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            //adaptor.Fill(ds, "Favourite");
            return ds;
        }
        public static void RemoveMedia(string fileName)
        {
            string str = "DELETE FROM Favourite WHERE FileName = @fileName;";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(str, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fileName", fileName);
            command.ExecuteNonQuery();
        }
    }
}
