using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDD4All.SVG.Tests
{
	class Program
	{
		static void Main(string[] args)
		{
			BasicConfigurator.Configure();

			//Test1 test1 = new Test1();
			Test2 test2 = new Test2();

			Console.ReadLine();
		}
	}
}
