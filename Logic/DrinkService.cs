using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class DrinkService
    {
        DrinkDao drinksDao;
        public DrinkService()
        {
            drinksDao = new DrinkDao();
        }

        public List<Drink> GetAllDrinks()
        {
            return drinksDao.GetAllDrinks();
        }

        public Drink GetDrinkById(int id)
        {
            return drinksDao.GetDrinkById(id);
        }

        public List<Drink> GetSoftDrinks()
        {
            return drinksDao.GetSoftDrinks();
        }

        public List<Drink> GetBeers()
        {
            return drinksDao.GetBeers();
        }

        public List<Drink> GetWines()
        {
            return drinksDao.GetWines();
        }

        public List<Drink> GetSpirits()
        {
            return drinksDao.GetSpirits();
        }

        public List<Drink> GetWarmDrinks()
        {
            return drinksDao.GetWarmDrinks();
        }

    }
}
