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

        String strConn = "server=localhost;uid=root;pwd=;database=butcher_shop_db";

        public Butcher()
        {
            dbConn = new MySqlConnection(strConn);
        }

        // TEST DATABASE CONNECTION
        public void dbConnection()
        {
            try
            {
                dbConn.Open();
                MessageBox.Show("Database Connected Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        // DISPLAY RECORDS IN DATAGRIDVIEW
        public void displayRecord(String strQuery, DataGridView DG)
        {
            try
            {
                dbConn.Open();

                da = new MySqlDataAdapter(strQuery, dbConn);
                dt = new DataTable();
                da.Fill(dt);

                DG.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        // INSERT / UPDATE / DELETE
        public void sqlManager(String Query)
        {
            try
            {
                dbConn.Open();

                dbComm = new MySqlCommand(Query, dbConn);
                dbComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        // RETURN SINGLE VALUE (For dashboard counts)
        public object returnValue(String Query)
        {
            object value;

            try
            {
                dbConn.Open();

                dbComm = new MySqlCommand(Query, dbConn);
                value = dbComm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                value = null;
            }
            finally
            {
                dbConn.Close();
            }

            return value;
        }
    }
}