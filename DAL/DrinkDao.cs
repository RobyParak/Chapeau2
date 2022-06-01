using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drink GetDrinkById(int drinkId)
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE I.Item_Id = @DrinksId";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinksId", drinkId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Drink> GetSoftDrinks()
        {
            int drinkType = 0;
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE Drink_Type = @DrinkType ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkType", drinkType) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> GetBeers()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE Drink_Type = @DrinkType ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkType", 1) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> GetWines()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE Drink_Type = @DrinkType ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkType", 2) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> GetSpirits()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE Drink_Type = @DrinkType ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkType", 3) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> GetWarmDrinks()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Drink_Type FROM dbo.Drink as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE Drink_Type = @DrinkType ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DrinkType", 4) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    ItemId = (int)dr["Item_ID"],
                    ItemName = (string)dr["Item_Name"],
                    Price = (double)dr["Price"],
                    Stock = (int)dr["Stock"],
                    VAT = (double)dr["VAT"],
                    DrinkType = (int)dr["Drink_Type"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
