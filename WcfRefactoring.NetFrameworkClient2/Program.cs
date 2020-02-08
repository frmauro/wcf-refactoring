using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfRefactoring.NetFrameworkClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = Factory.Create<ICalc>();

            //ICalc[] apis = new ICalc[]
            //{
            //        new ChannelFactory<ICalc>("http").CreateChannel(),
            //        new ChannelFactory<ICalc>("tcp").CreateChannel()
            //};

            //foreach (var calcApi in apis)
            //{
            Console.WriteLine(calc.Sum(2, 5));
            //}
        }
    }
}
