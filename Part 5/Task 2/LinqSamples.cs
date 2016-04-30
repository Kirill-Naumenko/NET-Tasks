// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SampleSupport;
using Task.Data;
using System.Text.RegularExpressions;

// Version Mad01

namespace SampleQueries
{
	[Title("LINQ Module")]
	[Prefix("Linq")]
	public class LinqSamples : SampleHarness
	{

		private DataSource dataSource = new DataSource();

		[Category("Restriction Operators")]
		[Title("Where - Task 1")]
		[Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
		public void Linq1()
		{
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			var lowNums =
				from num in numbers
				where num < 5
				select num;

			Console.WriteLine("Numbers < 5:");
			foreach (var x in lowNums)
			{
				Console.WriteLine(x);
			}
		}

		[Category("Restriction Operators")]
		[Title("Where - Task 2")]
		[Description("This sample return return all presented in market products")]

		public void Linq2()
		{
			var products =
				from p in dataSource.Products
				where p.UnitsInStock > 0
				select p;

			foreach (var p in products)
			{
				ObjectDumper.Write(p);
			}
		}



        [Category("Restriction Operators")]
        [Title("LINQ - task 1")]
        [Description("1.Выдайте список всех клиентов, чей суммарный оборот (сумма всех заказов) превосходит некоторую величину X. Продемонстрируйте выполнение запроса с различными X (подумайте, можно ли обойтись без копирования запроса несколько раз)")]
        public void Linq001()
        {

            int deadline = 1000000;
            decimal totalOrder = 0;


            var task1 = from cust in dataSource.Customers
                        where cust.Orders.Sum(o => o.Total) > deadline
                        select cust;
                        
                        

            foreach (var output in task1)
            {
                ObjectDumper.Write(output);
            }

           


        }

        [Category("Restriction Operators")]
        [Title("LINQ - task 2")]
        [Description("2.Для каждого клиента составьте список поставщиков, находящихся в той же стране и том же городе. Сделайте задания с использованием группировки и без.")]
        public void Linq002()
        {

   


            var task2 = from cust in dataSource.Customers
                        from sup in dataSource.Suppliers
                        where cust.City.Equals(sup.City)
                        select cust;
                        

            foreach (var output in task2)
            {
                ObjectDumper.Write("Customer "+ output.CompanyName + "\r\nCity "+ output.City+"\r\n");
            }

        }


        [Category("Restriction Operators")]
        [Title("LINQ - task 3")]
        [Description("3.Найдите всех клиентов, у которых были заказы, превосходящие по сумме величину X")]
        public void Linq003()
        {


           

            int total = 10000;

            var task3 = from cust in dataSource.Customers
                        from ord in cust.Orders
                        where ord.Total > total
                        group cust.CompanyName by ord.Total ;


            foreach (var output in task3)
            {
                ObjectDumper.Write(output);
            }

        }


        [Category("Restriction Operators")]
        [Title("LINQ - task 4")]
        [Description("4.Выдайте список клиентов с указанием, начиная с какого месяца какого года они стали клиентами (принять за таковые месяц и год самого первого заказа)")]
        public void Linq004()
        {


            var task4 = from cust in dataSource.Customers
                        from ord in cust.Orders
                        group ord.OrderDate by cust.CompanyName;

            foreach (var output in task4)
            {
                ObjectDumper.Write("Customer: "+output.Key + " First Date : "+output.First()+"\r\n");
            }
            
           

        }








        [Category("Restriction Operators")]
        [Title("LINQ - task 6")]
        [Description("6.Укажите всех клиентов, у которых указан нецифровой код или не заполнен регион или в телефоне не указан код оператора (для простоты считаем, что это равнозначно «нет круглых скобочек в начале»).")]
        public void Linq006()
        {
            Regex rgx = new Regex("[0-9]");
            int result;
            var task6 = from cus in dataSource.Customers
                        where !cus.Phone.Contains("(") || !Int32.TryParse(cus.PostalCode , out result) || String.IsNullOrEmpty(cus.Region)
                        select cus;


            foreach (var output in task6)
            {
                ObjectDumper.Write("Phone "+output.Phone+"\r\n"+ "Code " + output.PostalCode+"\r\n"+"Region " + output.Region+"\r\n");
            }


        }


        [Category("Restriction Operators")]
        [Title("LINQ - task 8")]
        [Description("8.Сгруппируйте товары по группам «дешевые», «средняя цена», «дорогие». Границы каждой группы задайте сами")]
        public void Linq008()
        {
            int cheapPrice = 20;
            int averagePrice = 100;
           

            var cheapProduct = from prod in dataSource.Products
                               where prod.UnitPrice < cheapPrice
                               select prod;

            var averageProduct = from prod in dataSource.Products
                                 where prod.UnitPrice > cheapPrice && prod.UnitPrice < averagePrice
                                 select prod;

            var expensiveProduct = from prod in dataSource.Products
                                 where prod.UnitPrice > averagePrice
                                 select prod;

            foreach (var output in cheapProduct)
            {
                ObjectDumper.Write("Cheap product :"+ output.UnitPrice+" Name : "+output.ProductName);
            }
            foreach (var output in averageProduct)
            {
                ObjectDumper.Write("Average product :" + output.UnitPrice + " Name : " + output.ProductName);
            }
            foreach (var output in expensiveProduct)
            {
                ObjectDumper.Write("Expensive product :" + output.UnitPrice + " Name : " + output.ProductName);
            }
        }

    }
}
