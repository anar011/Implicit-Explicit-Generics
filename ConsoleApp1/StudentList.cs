﻿using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentList
    {
        private Student[] arr;

        public StudentList()
        {
            arr = new Student[0];
        }

        public void Add(Student student)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = student;
        }


        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name);
            }

        }


    }
}
