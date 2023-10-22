using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint3.Task3.V10.Lib;

namespace Tyuiu.ShtolVA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();

            string value = "gdfppf vfppt p";
            char chr = 'p';

            string wait = "gdff vft ";
            string res = ds.DeleteCharInString(value,chr);


            Assert.AreEqual(wait, res);
            
        }
    }
}
