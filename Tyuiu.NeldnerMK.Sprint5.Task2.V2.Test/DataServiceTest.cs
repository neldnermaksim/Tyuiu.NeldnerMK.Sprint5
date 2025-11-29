using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint5.Task2.V2.Lib;
using System.IO;
namespace Tyuiu.NeldnerMK.Sprint5.Task2.V2.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -7, 7, 5 }, { 4, 2, -7 }, { 2, 6, -4 } };
            string path = ds.SaveToFileTextData(matrix);
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}

