using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
    public class MonthlyPrecipitation
    {
        public int Days { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        private double[] precipitations;
        public MonthlyPrecipitation(int year, int month, int days)
        {
            this.Year = Year;
            this.Month = month;
            this.Days = days;
            precipitations = new double[Days];
        }
        public MonthlyPrecipitation(int year, int month, double[] precipitations) 
            : this(year, month, precipitations.Length)
        {
            Array.Copy(precipitations, this.precipitations, precipitations.Length);
        }
        public void StorePercipitiationsForDay(double precipitation, int day)
        {
            precipitations[day] = precipitation;
        }
        public double GetPrecipitationForDay(int day)
        {
            return precipitations[day];
        }
        public double GetAveragePrecipitation()
        {
            double totalPrecipitation = 0.0;
            foreach(var precipitation in precipitations)
            {
                totalPrecipitation += precipitation;
            }
            double avereagePrecipitation = totalPrecipitation / precipitations.Length;
            return avereagePrecipitation;
        }


    }
}
