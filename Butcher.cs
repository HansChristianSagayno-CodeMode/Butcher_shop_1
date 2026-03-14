using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Butcher_shop
{
    internal class Butcher
    {
        private MySqlConnection dbConn;
        private MySqlCommand dbComm;
        private MySqlDataAdapter da;
        private DataTable dt;

        String strConn = "server=localhost;uid=root;pwd=;database=db_exam";

        public Butcher()
        {
            dbConn = new MySqlConnection(strConn);
        }

        public void dbConnection()
        {
            dbConn.Open();
            MessageBox.Show("Database Connected");
            dbConn.Close();
        }

        public void displayRecord(String strQuery, DataGridView DG)
        {
            dbConn.Open();
            da = new MySqlDataAdapter(strQuery, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            DG.DataSource = dt;
            dbConn.Close();
        }

        public void sqlManager(String Query)
        {
            dbConn.Open();
            dbComm = new MySqlCommand(Query, dbConn);
            dbComm.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}