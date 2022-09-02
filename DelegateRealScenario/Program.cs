using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_RealLife_Scenario
{
    public delegate int CompareFn(object left, object right);
    internal class Utilities
    {
        public static void Sort(object[] data, CompareFn func)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (func(data[i], data[j]) > 0)
                    {
                        object temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
    internal class MainClass
    {
        class UserProfile
        {
            public string Name;
            public int Age;
            public double Salary;
            public double Experience;

            public UserProfile(string name, int age, double sal, double ex)
            {
                this.Name = name;
                this.Age = age;
                this.Salary = sal;
                this.Experience = ex;
            }
            public static int CompareByName(object objA, object objB)
            {
                if (objA is UserProfile && objB is UserProfile)
                {
                    UserProfile lu = (UserProfile)objA;
                    UserProfile ru = (UserProfile)objB;

                    return lu.Name.CompareTo(ru.Name);
                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            object[] data = new object[]
            {
                new UserProfile("01Name",23,7.5,11.5),
                new UserProfile("22Name",33,1.7,4.5),
                new UserProfile("04Name",26,2.5,12),
                new UserProfile("03Name",42,3.5,14),
                new UserProfile("12Name",21,2.1,10),
                new UserProfile("10Name",35,3.9,8)
            };

            CompareFn fnn = UserProfile.CompareByName;
            Console.WriteLine("Before Sorting....");
            printData(data);
            Utilities.Sort(data, fnn);
            Console.WriteLine("After Sorting(by name).....");
            printData(data);
        }
        public static void printData(object[] obj)
        {
            foreach (UserProfile up in obj)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", up.Name, up.Age, up.Salary, up.Experience);


            }
        }
    }
}