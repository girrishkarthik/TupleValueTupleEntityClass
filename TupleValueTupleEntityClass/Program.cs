using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TupleValueTupleEntityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] averageValueTupleTime = new long[10];
            long[] averageEntityTime = new long[10];
            Stopwatch timer = new Stopwatch();

            (int ID, string employeeName, double salary, int areaCode, string designation, string reportingTo) valueTuple = (1, "Steve", 1, 1, "engineer", "Adam");
            EmployeeEntity emp = new EmployeeEntity();

            for (int i = 0; i < 10; i++)
            {
                timer.Start();
                //Testing ValueTuple and checking the time it takes to perform one million modifications
                for (int j = 1; j <= 1000000; j++)
                {
                    valueTuple.ID = j;
                    valueTuple.employeeName = "Steve";
                    valueTuple.salary = j;
                    valueTuple.areaCode = j;
                    valueTuple.designation = "engineer";
                    valueTuple.reportingTo = "Adam";
                }
                timer.Stop();
                averageValueTupleTime[i] = timer.ElapsedMilliseconds;

                timer.Restart();
                //Testing Entity object and checking the time it takes to perform one million modifications
                for (int k = 1; k <= 1000000; k++)
                {
                    emp.ID = k;
                    emp.EmployeeName = "Steve";
                    emp.Salary = k;
                    emp.AreaCode = k;
                    emp.Designation = "engineer";
                    emp.ReportingTo = "Adam";
                }
                timer.Stop();
                averageEntityTime[i] = timer.ElapsedMilliseconds;
                timer.Reset();
            }
            Console.WriteLine($"Number of times ValueTuple was tested is {averageValueTupleTime.Count()}");
            Console.WriteLine($"Number of times Entity object was tested is {averageEntityTime.Count()}");
            Console.WriteLine($"This is the time taken for each test of ValueTuple in Milliseconds: {string.Join(" ms, ", averageValueTupleTime)} ms");
            Console.WriteLine($"This is the time taken for each test of Entity object in Milliseconds: {string.Join(" ms, ", averageEntityTime)} ms");
            Console.WriteLine($"Average time taken for Value Tuple test is {averageValueTupleTime.Average()} Milliseconds");
            Console.WriteLine($"Average time taken for Entity class object test is {averageEntityTime.Average()} Milliseconds");
            Console.ReadLine();
        }
    }
    public class EmployeeEntity
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public int AreaCode { get; set; }
        public string Designation { get; set; }
        public string ReportingTo { get; set; }
    }
}
