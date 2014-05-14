using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerator_Tests
{
	class MainClass
	{
		
		public static void Main ()
		{
			// Shopping list
			List<string> myList = new List<string>();
			myList.Add("Fruit");
			myList.Add("Vegetables");
			myList.Add("Sweets");
			myList.Add("Drinks");
			
			IEnumerator<string> myEnum = myList.GetEnumerator();
			// The IEnumerator is set to be BEFORE the first value in the list. Therefore, you must
			// moveNext at creation, or after Reset to obtain the first value. If you don't it will
			// be an undefined value and will return an error.
			myEnum.Reset();
			
			// Cast the List class directly into an IEnumerable
			IEnumerable<string> myEnumerable = (IEnumerable<string>)myList;
			
			Console.WriteLine("IEnumerator\n");
			outputValuesEnumerator(myEnum);
			Console.WriteLine("\nIEnumerable\n");
			outputValuesEnumerable(myEnumerable);
			
			foreach (int penum in GetPowersofTwo())
			{
				Console.WriteLine(penum);
			}
			
		}
		
		static void outputValuesEnumerator (IEnumerator<string> enumt)
		{
			while(enumt.MoveNext())
			{
				Console.WriteLine(enumt.Current);
			}
		}
		
		static void outputValuesEnumerable (IEnumerable<string> enumb)
		{
			foreach (string e in enumb)
			{
				Console.WriteLine(e);
			}
		}
		
		static IEnumerable<int> GetPowersofTwo()
		{
		   for (int i = 1; i < 10; i++)
		       yield return (int)System.Math.Pow(2, i);
		   yield break;
		}

	}
}