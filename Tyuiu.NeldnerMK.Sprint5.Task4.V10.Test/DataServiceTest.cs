using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Tyuiu.NeldnerMK.Sprint5.Task4.V10.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.NeldnerMK.Sprint5.Task4.V10.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void Checked()
        {
            string path = @"C:\Users\anast\source\repos\Tyuiu.NeldnerMK.Sprint5\DataSprint5\InPutDataFileTask4V10.txt";
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}