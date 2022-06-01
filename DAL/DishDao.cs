using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DishDao : BaseDao
    {
        public List<Dish> GetAllDishes()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Dish_Type FROM dbo.Dish as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Dish GetDishById(int dishId)
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Dish_Type FROM dbo.Dish as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID WHERE I.Item_Id = @DishId ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@DishId", dishId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Dish> GetLunchDishes()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Dish_Type FROM dbo.Dish as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID JOIN dbo.Menu_Dish as M ON M.Dish_ID = I.Item_ID WHERE M.Menu_ID = @MenuId ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@MenuId", 1) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Dish> GetDinnerDishes()
        {
            string query = "SELECT I.Item_ID, I.Item_Name, I.Price, I.Stock, I.VAT, Dish_Type FROM dbo.Dish as D JOIN dbo.Item as I ON I.Item_ID = D.Item_ID JOIN dbo.Menu_Dish as M ON M.Dish_ID = I.Item_ID WHERE M.Menu_ID = @MenuId ;";
            SqlParameter[] sqlParameters = { new SqlParameter("@MenuId", 2) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Dish> ReadTables(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Dish dish = new Dish()
                {
                    ItemId = (int)dr["Item_ID"],
                    ItemName = (string)dr["Item_Name"],
                    Price = (double)dr["Price"],
                    Stock = (int)dr["Stock"],
                    VAT = (double)dr["VAT"],
                    DishType = (int)dr["Dish_Type"]
                };
                dishes.Add(dish);
            }
            return dishes;
        }

    }
}
