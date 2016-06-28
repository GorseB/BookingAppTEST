using System.Data;
using System.Data.SqlClient;

namespace BookingAppTEST
{
    internal class Database
    {
        private readonly SqlConnection SCNT = new SqlConnection();
        private readonly SqlCommand SCMD = new SqlCommand();
        private SqlDataAdapter DA = new SqlDataAdapter();
        public string ConnectionString;

        public Database(string CString)
        {
            ConnectionString = CString;
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
        }

        public DataTable Fill()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            var DT = new DataTable();
            using (DA = new SqlDataAdapter("EXECUTE Get_Table_Names", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public DataTable Get_Data(string TableName)
        {
            var DT = new DataTable();
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            using (var cmd = new SqlCommand("GetByName", SCNT))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", TableName);
                da.Fill(DT);
            }
            return DT;
        }
    }
}