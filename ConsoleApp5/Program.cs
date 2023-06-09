﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6
{
    class Phone
    {
        public string Model { get; set; }
        public string Number { get; set; }

        public Phone(string model, string number)
        {
            Model = model;
            Number = number;
        }

        public void Call(string number)
        {
            Console.WriteLine($"Вызов по номеру {number}");
            WriteToLog($"Вывзов {number}");
        }

        protected void WriteToLog(string text)
        {
            File.AppendAllText("log.txt", $"{Model}, {DateTime.Now}: {text}\n");
        }

    }


    class Smartphone : Phone
    {

        public Smartphone(string model, string number, double cameraResolution) : base(model, number)
        {
            CameraResolution = cameraResolution;
        }

        public double CameraResolution { get; set; }

        public void Shoot()
        {
            Console.WriteLine("Снимок сделан");
            WriteToLog($"Снимок сделан");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone speedrun = new Smartphone("ААА Я ПОД СПИДАМИ", "1000", 80);
            speedrun.Call("867482488471");
            speedrun.Shoot();
            Console.ReadKey(true);
        }
    }
}
