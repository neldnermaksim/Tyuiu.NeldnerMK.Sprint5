using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint5.Task3.V16.Lib;
using System.IO;
namespace Tyuiu.NeldnerMK.Sprint5.Task3.V16.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();

            
            string path = ds.SaveToFileTextData(3);
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}

