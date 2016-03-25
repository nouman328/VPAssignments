using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of siblings");
            string q = Console.ReadLine();
            int i = Convert.ToInt32(q);
            int j = i;
            string[] arr = new string[j];
            int[] yearr = new int[j];
            int[] monthh = new int[j];
            int[] dayy = new int[j];
            int[] yearrr = new int[j];
            int[] monthhh = new int[j];
            int[] dayyy = new int[j];
            for (j=0; j<i; j++)
            {
                int l = 1+j;
                Console.WriteLine("please enter date of birth of sibling " + l ) ;
                string w = Console.ReadLine();
                arr[j] = w;
               
            }

            for (j = 0; j < i; j++)
            {
                int l = 1 + j;
                DateTime dob = Convert.ToDateTime(arr[j]);
                DateTime PresentYear = DateTime.Now;
                TimeSpan ts = PresentYear - dob;
                DateTime Age = DateTime.MinValue.AddDays(ts.Days);
                yearr[j] = Age.Year - 1;
                monthh[j] = Age.Month - 1;
                dayy[j] = Age.Day - 1;
                Console.WriteLine(string.Format("Age of sibling " + l + " is {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1));
               
            }
            for (j = 0; j < i-1; j++)
            {
    
                int l = 1 + j;
               
                yearrr[j] = yearr[j] - yearr[l];
               
                if (monthh[j] - monthh[l] == -monthhh[j])
                {
                    monthhh[j] = (monthh[j] - monthh[l] + 12);
                }
                else
                {
                    monthhh[j] = monthh[j] - monthh[l];
                }
                dayyy[j] = dayy[j] - dayy[l];
                int h = l + 1;
                Console.WriteLine(string.Format("Difference between sibling " + l + " and " + h + " is {0} Years {1} Month {2} Days", yearrr[j] , monthhh[j], dayyy[j]));
            }
            Console.ReadLine();
        }
            
        }
    }
