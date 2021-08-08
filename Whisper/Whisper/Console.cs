/*
 *	Project: Whisper
 *	Author(s): Lorenzo Billi
 *	
 *	
 *	The MIT License
 *	
 *	Copyright (c) 2021 Lorenzo Billi
 *	
 *	Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 *	documentation files (the "Software"), to deal in the Software without restriction, including without limitation
 *	the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and
 *	to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 *	
 *	The above copyright notice and this permission notice shall be included in all copies or substantial portions
 *	of the Software.
 *	
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
 *	THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND	NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
 *	CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
 *	IN THE SOFTWARE.
 *	
 */

using System.Collections.Generic;

namespace Whisper
{
	public class Console
	{
		private static List<IRumor> rumors;

		private static void AddRumor()
		{
			System.Console.WriteLine(">: ");
			var content = System.Console.ReadLine();
			rumors.Add(new Rumor(content));
		}

		private static void PrintRumors()
		{
			foreach (var rumor in rumors)
			{
				System.Console.WriteLine("Rumor ID: " + rumor.Id);
				System.Console.WriteLine(rumor.Content);
			}
		}

		public static void Main()
		{
			System.Console.Write("\n");
			System.Console.WriteLine("\t\t__        ___     _                     ");
			System.Console.WriteLine("\t\t\\ \\      / / |__ (_)___ _ __   ___ _ __ ");
			System.Console.WriteLine("\t\t \\ \\ /\\ / /| '_ \\| / __| '_ \\ / _ \\ '__|");
			System.Console.WriteLine("\t\t  \\ V  V / | | | | \\__ \\ |_) |  __/ |   ");
			System.Console.WriteLine("\t\t   \\_/\\_/  |_| |_|_|___/ .__/ \\___|_|   ");
			System.Console.WriteLine("\t\t                       |_|              ");
			System.Console.Write("\n\t*** Copyright (c) Lorenzo Billi - All rights reserved ***\n\n");

			var quit = false;
			Rumor.LastId = 0;
			rumors = new List<IRumor>();

			while (!quit)
			{
				System.Console.WriteLine("1) Add new rumor");
				System.Console.WriteLine("2) Show all rumors");
				System.Console.WriteLine("3) Exit");
				System.Console.Write(">: ");

				var option = System.Console.ReadLine();
				
				switch (option)
				{
					case "1":
						AddRumor();
						break;
					case "2":
						PrintRumors();
						break;
					case "3":
						quit = true;
						break;
					default:
						System.Console.WriteLine("Invalid option selected.");
						break;
				}
			}
		}
	}
}
