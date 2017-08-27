using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using System.Data;
using MySql;
using MySql.Data.Types;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace WindowsFormsApplication5
{
    public class DBManager
    {
        public MySqlConnection myConnection;



        public DBManager()
        {
            string conn_str = ConfigurationManager.ConnectionStrings["myconnt"].ConnectionString;

            myConnection = new MySqlConnection(conn_str);
            
        }
        public void openconnector()
        {
            try
            {
                myConnection.Open();
                MessageBox.Show("The DB connection is opened successfully");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("The DB connection is failed");
                MessageBox.Show(e.ToString());
            }
        }

        public int ExecuteNonQuery(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                MySqlCommand mycommand = new MySqlCommand(storedProcedureName, myConnection);
                mycommand.CommandType = CommandType.StoredProcedure;
                foreach (KeyValuePair<string, object> Param in Parameters)
                {
                    mycommand.Parameters.Add(new MySqlParameter(Param.Key, Param.Value));
                }
                return mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public DataTable ExecuteReader(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                MySqlCommand mycommand = new MySqlCommand(storedProcedureName, myConnection);
                mycommand.CommandType = CommandType.StoredProcedure;
                if (Parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in Parameters)
                    {
                        mycommand.Parameters.Add(new MySqlParameter(Param.Key, Param.Value));

                    }
                }
                MySqlDataReader reader = mycommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
        }


        public DataTable ExecuteReader(string query)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                MySqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string storedProcedureName, Dictionary<string, object> Parameters)
        {
            try
            {
                MySqlCommand mycommand = new MySqlCommand(storedProcedureName, myConnection);
                mycommand.CommandType = CommandType.StoredProcedure;
                foreach (KeyValuePair<string, object> Param in Parameters)
                {
                    mycommand.Parameters.Add(new MySqlParameter(Param.Key, Param.Value));
                }
                return mycommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public object ExecuteScalar(string query)  //t7sb cell
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
       
        




        

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }

}