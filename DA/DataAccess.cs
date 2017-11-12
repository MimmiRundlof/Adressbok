using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Adressbok.DA
{
    internal class DataAccess
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataset = null;

        public DataAccess()
        {

            var connectionString = Properties.Settings.Default.AddressbookCon;
            connection = new SqlConnection(connectionString);
            
        }

        public DataSet GetDataFromDB(string query)
        {
            dataset = new DataSet();
            DataTable datatable = new DataTable();
           
            command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = query;

            try
            {
                connection.Open();

                SqlDataAdapter da = null;
                using (da = new SqlDataAdapter(command))
                {
                    da.Fill(datatable);
                }

                dataset.Tables.Add(datatable);


                return dataset;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        public DataSet SaveData(string query)
        {
            dataset = new DataSet();
            
            
            command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

        }

        public DataSet SearchData(string query)
        {
            dataset = new DataSet();
            DataTable datatable = new DataTable();

     
            command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = query;

            try
            {
                connection.Open();

                SqlDataAdapter da = null;
                using (da = new SqlDataAdapter(command))
                {
                    da.Fill(datatable);
                }

                dataset.Tables.Add(datatable);


                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }


        }

        public DataSet EditData(string query)
        {
            dataset = new DataSet();

                 
            command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        public DataSet DeleteData(string query)
        {
            dataset = new DataSet();

            
            command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }


        }

    }


    }

