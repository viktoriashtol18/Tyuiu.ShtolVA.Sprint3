using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.ShtolVA.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 22.77;
            valueWaitArray[1] = 17.75;
            valueWaitArray[2] = 12.71;
            valueWaitArray[3] = 7.61;
            valueWaitArray[4] = 2.32;
            valueWaitArray[5] = -8.00;
            valueWaitArray[6] = -6.13;
            valueWaitArray[7] = -11.57;
            valueWaitArray[8] = -16.69;
            valueWaitArray[9] = -21.74;
            valueWaitArray[10] = -26.76;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
            
        }
    }
}
