﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogicSpinner
{
    public abstract class DAL
    {
        private const string CONNECTION_STRING = @"
            Data Source=.\sqlexpress;Initial Catalog=bpstore;
            Integrated Security=true
            ";

        public static DataTable GetDatabaseRecords(string queryString, KeyValuePair<string,string>[] args = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                
                if (args != null)
                {
                    command.Parameters.AddWithValue(args[0].Key, args[0].Value);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        public static string GetScalarValue(string queryString, KeyValuePair<string, string>[] args = null)
        {
            string toReturn = string.Empty;

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                if (args != null)
                {
                    command.Parameters.AddWithValue(args[0].Key, args[0].Value);
                }

                connection.Open();
                toReturn = command.ExecuteScalar().ToString();
            }
            return toReturn;
        }

        public static decimal GetSafeDecimal(object p)
        {
            //http://forums.asp.net/t/1383849.aspx/1
            return p == DBNull.Value ? 0M : Convert.ToDecimal(p);
        }
    }

    public class ProductDAL: DAL
    {
        public static List<Product> Products()
        {
            string queryString = string.Format(@"
            SELECT * FROM PRODUCTS
            ");

            DataTable dt = GetDatabaseRecords(queryString);

            List<Product> p = GetGenericProductList(dt);

            return p;
        }

        private static List<Product> GetGenericProductList(DataTable dt)
        {
            List<Product> productList = new List<Product>();

            foreach (DataRow dr in dt.Rows)
            {
                Product p = new Product()
                {
                    Id = Convert.ToInt32(dr["Id"])
                    ,
                    Name = dr["Name"].ToString()
                    ,
                    Cost = GetSafeDecimal(dr["Cost"])
                };

                productList.Add(p);
            }

            return productList;
        }
    }

    public class RewardDAL : DAL
    {
        public static List<Reward> Rewards()
        {
            string queryString = string.Format(@"
            SELECT * FROM REWARDS
            ");

            DataTable dt = GetDatabaseRecords(queryString);

            List<Reward> r = GetGenericRewardList(dt);

            return r;
        }

        public static List<Reward> Rewards(List<ReceiptItem> products)
        {
            string sProducts = string.Empty;

            foreach (var item in products)
            {
                sProducts += string.Format("ProductCsv like '%{0}%' or ", item.Name);
            }

            sProducts = sProducts.TrimEnd(' ', 'o', 'r');

            string queryString = string.Format(@"
             Select * from Rewards where {0}
            ", sProducts);

            DataTable dt = GetDatabaseRecords(queryString);

            List<Reward> r = GetGenericRewardList(dt);

            return r;
        }

        private static List<Reward> GetGenericRewardList(DataTable dt)
        {
            List<Reward> list = new List<Reward>();

            foreach (DataRow dr in dt.Rows)
            {
                Reward r = new Reward()
                {
                    Id = Convert.ToInt32(dr["Id"])
                    ,
                    ProductCsv = dr["ProductCsv"].ToString()

                };

                list.Add(r);
            }

            return list;
        }
    }

    public class ReceiptDAL : DAL
    {
        public static List<Receipt> ReceiptItems()
        {
            List<Receipt> list = new List<Receipt>();
            //Todo: 

            return list;
        }

        public static Receipt Receipt(int id)
        {
            Receipt p = new Receipt();
            //Todo: 

            return p;
        }

        private static List<Receipt> GetGenericReceiptList()
        {
            List<Receipt> receiptItems = new List<Receipt>();
            //Todo: 

            return receiptItems;
        }

        public static List<ReceiptItem> ReceiptItems(int receiptId)
        {
            List<ReceiptItem> list = new List<ReceiptItem>();

            string queryString = string.Format(@"
            SELECT P.Id, P.Name FROM ReceiptItems I
            JOIN PRODUCTS P ON I.ProductId = P.Id
            WHERE I.ReceiptId = @ReceiptId
            ");
            KeyValuePair<string, string> parm1 = 
                new KeyValuePair<string, string>("@ReceiptId", receiptId.ToString());
            KeyValuePair<string, string>[] sqlParms = { parm1 };
            DataTable dt = GetDatabaseRecords(queryString, sqlParms);

            list = GetGenericReceiptItemList(dt);

            return list;
        }

        //Insert new receipt 
        public static string UpdateReceipt(Receipt receipt)
        {
            string toReturn = string.Empty;

            string queryString = string.Empty;
            //New Receipt
            if (receipt.Id == 0)
            {
                queryString = string.Format(@"
                Insert into Receipts
                (date) Values (@date);
                Select @@IDENTITY;
                ");

                KeyValuePair<string, string> parm1 = 
                new KeyValuePair<string, string>("@date", receipt.Date.ToString());
                KeyValuePair<string, string>[] sqlParms = { parm1 };
                toReturn = GetScalarValue(queryString, sqlParms);
            }

            return toReturn;
        }

        //Save receipt item 

        private static List<ReceiptItem> GetGenericReceiptItemList(DataTable dt)
        {
            List<ReceiptItem> list = new List<ReceiptItem>();

            foreach (DataRow dr in dt.Rows)
            {
                ReceiptItem item = new ReceiptItem();
                item.Id = Convert.ToInt32(dr["Id"]);
                item.Name = dr["Name"].ToString();

                list.Add(item);
            }

            return list;
        }

    }
}