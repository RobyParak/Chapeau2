using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace Service
{
    public class DishService
    {
        DishDao dishDao;
        public DishService()
        {
            dishDao = new DishDao();
        }
        public List<Dish> GetAllDishes()
        {
            return dishDao.GetAllDishes();
        }

        public Dish GetDishById(int id)
        {
            return dishDao.GetDishById(id);
        }

        public List<Dish> GetLunchDishes()
        {
            return dishDao.GetLunchDishes();
        }

        public List<Dish> GetDinnerDishes()
        {
            return dishDao.GetDinnerDishes();
        }

    } 
}
