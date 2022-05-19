using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreOfWine
{
    public class Wine
    {
        public string name;
        public ColorWine color;
        public StrongWine strong;
        public int year;

        //Поиск в списке по цвету вина
        public static List <Wine> FindColor(ColorWine color)
        {
            List<Wine> myWine = DescribeWine();
            Console.WriteLine("\nThis is list of wine with filtr color:");
            
            var selectedColor = from p in myWine
                                  where p.color == color
                                  select p;
            foreach (Wine item in selectedColor)
            {
                Console.WriteLine("Color=" + item.color + " ,Strong=" + item.strong + " ,Year=" + item.year);
            }
            return myWine;
        }

        //Поиск в списке по году вина
        public static List<Wine> FindYear(int year)
        {
            List<Wine> myWine = DescribeWine();
            Console.WriteLine("This is list of wine with filtr by year:");
            var selectedYear = from p in myWine
                               where p.year == year
                               select p;
            foreach (Wine item in selectedYear)
            {
                Console.WriteLine("Color=" + item.color + " ,Strong=" + item.strong + " ,Year=" + item.year);
            }
            return myWine;
        }

        //Поиск в списке по цвету, году и крепости вина
    public static List<Wine> FindYearColorStrong(ColorWine color, int year, StrongWine strong)
        {
            List<Wine> myWine = DescribeWine();
            Console.WriteLine("This is list of wine with filtres by color,year and strong of wine");
            var selectedColorYearStrong = from p in myWine
                                          where p.color == color && p.year == year && p.strong == strong
                                          select p;
            foreach(Wine item in selectedColorYearStrong)
            {
                Console.WriteLine("Color=" + item.color + " ,Strong=" + item.strong + " ,Year=" + item.year);
            }
            return myWine;
        }

       public static List<Wine> DescribeWine()
       {
            List<Wine> myWine = new List<Wine>();
            myWine.Add(new Wine() { year = 2018, color = ColorWine.red, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.red, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.red, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.rose, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.rose, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.rose, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.white, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.white, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2018, color = ColorWine.white, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.red, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.red, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.red, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.rose, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.rose, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.rose, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.white, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.white, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2019, color = ColorWine.white, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.red, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.red, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.red, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.rose, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.rose, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.rose, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.white, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.white, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2020, color = ColorWine.white, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.red, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.red, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.red, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.rose, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.rose, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.rose, strong = StrongWine.hard });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.white, strong = StrongWine.ligth });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.white, strong = StrongWine.medium });
            myWine.Add(new Wine() { year = 2021, color = ColorWine.white, strong = StrongWine.hard });

            return myWine;
        }
    }
}
public enum ColorWine
{
    red = 1,
    white = 2,
    rose = 3
}

public enum StrongWine
{
    ligth,
    medium,
    hard
}