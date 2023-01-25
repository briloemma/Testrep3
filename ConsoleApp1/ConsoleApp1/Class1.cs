using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

		public Class1()
		{
			myVar = 1;
		}

	}
}
