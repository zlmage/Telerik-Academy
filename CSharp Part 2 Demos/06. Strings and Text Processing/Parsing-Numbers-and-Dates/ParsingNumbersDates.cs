﻿using System;
using System.Globalization;
using System.Threading;

class ParsingNumbersDates
{
	static void Main()
	{
		string numStr = "3.14";
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		float f = float.Parse(numStr);
		Console.WriteLine(f); // 3.14

		numStr = "3,14";
		f = float.Parse(numStr);
		Console.WriteLine(f); // 314 -> due to invariant culture

		f = float.Parse(numStr, new CultureInfo("bg-BG"));
		Console.WriteLine(f); // 3.14

		string dateStr = "05.01.2015";
		DateTime date = DateTime.ParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date);    // 01/05/2015 00:00:00
	}
}
