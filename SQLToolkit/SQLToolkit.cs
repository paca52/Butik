using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLToolkitNS
{
    public class SQLToolkit
    {

        private static String connStr;
        public static void setConnStr(String connStr)
        {
            SQLToolkit.connStr = connStr;
        }

        public static Boolean NonSelectQuery(String sql, ref String err)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand komanda = new SqlCommand(sql, conn);
                komanda.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                err = e.ToString();
                return false;
            }
        }

        public delegate void ReaderFunction(ref SqlDataReader reader);

        public static Boolean SelectQuery(String sql, ReaderFunction callback, ref String err)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand komanda = new SqlCommand(sql, conn);
                SqlDataReader dr = komanda.ExecuteReader();

                while (dr.Read())
                {
                    try
                    {
                        callback(ref dr);
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        err = "Error while parsing columns. " + e.Message;
                        return false;
                    }
                }

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                err = e.ToString();
                return false;
            }
        }

        public static Boolean SelectQuery(String sql, ref DataSet output, ref String err)
        {
            output = null;
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                output = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(output);

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                err = e.ToString();
                return false;
            }
        }

    }
}
