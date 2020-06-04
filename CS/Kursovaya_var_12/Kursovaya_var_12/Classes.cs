using System;
using System.Collections.Generic;
using System.Text;

namespace Kursovaya_var_12
{
    class Country
    {
        public string name;
        private string info;

        public Country(string a,string c)
        {
            name = a;
            info = c;
        }

        public void ShowInfoCountry()
        {
            Console.WriteLine("Інформація про " + name);
            Console.WriteLine(info);
        }
    }

    class City
    {
        public string name;
        public string city;
        private string info;

        public City(string a, string b, string c)
        {
            name = a;
            city = b;
            info = c;
        }
        public void ShowInfoCity()
        {
            Console.WriteLine("Інформація про " + city);
            Console.WriteLine(info);
        }
    }

    class Agency
    {
        public string AgencyName;
        public string info;

        public Agency(string a, string b)
        {
            AgencyName = a;
            info = b;
        }

        public void ShowInfoAgency()
        {
            Console.WriteLine("Інформація про " + AgencyName);
            Console.WriteLine(info);
        }
    }

    class Type
    {
        public string name;
        private string info;
        public Type(string a, string b)
        {
            name = a;
            info = b;
        }

        public void ShowInfoType()
        {
            Console.WriteLine("Інформація про вид туру");
            Console.WriteLine(info);
        }
    }

    //Створити країну для курорту
    class Tours : Agency
    {
        public string counName;
        public string cityName;
        public string type;
        public int MonthSt;
        public int MonthEnd;
        private string info;

        public Tours(string a, string b, City place, string Ty, int st, int end, string infoi)
            : base(a, b)
        {
            counName = place.name;
            cityName = place.city;
            type = Ty;
            MonthSt = st;
            MonthEnd = end;
            info = infoi;
        }

        public void ShowInfoTour()
        {
            Console.WriteLine("Інформація про тур");
            Console.WriteLine(info);
        }
    }
}
