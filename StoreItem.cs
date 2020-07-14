using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_Simulator
{
    class StoreItem
    {

        public StoreItem()
        {

        }

        public StoreItem(int sku, string category, string description, string specs, float price, int quantity)
        {
            SKU = sku;
            Category = category;
            Description = description;
            Specifications = specs;
            Price = price;
            Quantity = quantity;
        }

        public int SKU { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        private string myconnstrng = "Server=\"localhost\";Port=5432;Database=StoreItems;User Id=postgres;Password=progStuff;";
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;

        public DataTable Select_All()
        {
            conn = new NpgsqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing our SQL query
                sql = @"SELECT * FROM StoreItems";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                //int i = cmd.ExecuteNonQuery();
                //Console.WriteLine("=> " + i);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Update_quantity(int sku, int newQuantity)
        {
            bool isSuccess = false;

            int numRows = 0;
            conn = new NpgsqlConnection(myconnstrng);

            try
            {
                sql = "Update StoreItems SET Quantity=@newQuantity WHERE SKU=@sku";

                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                cmd.Parameters.AddWithValue("@SKU", sku);

                conn.Open();
                numRows = cmd.ExecuteNonQuery();

                

                if (numRows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }


        public DataTable SelectOneBySKU(int sku)
        {
            conn = new NpgsqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                sql = @"SELECT * FROM StoreItems where SKU = @sku";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sku", sku);
                dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            if(dt.Rows.Count <= 0)
            {
                return null;
            }

            return dt;
        }

    }
}
