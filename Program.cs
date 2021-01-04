using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8
{
	class Program
	{
        
        static void Main(string[] args)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
			{
				Console.WriteLine("Введите имя пользователя:");
				Properties.Settings.Default.UserName = Console.ReadLine();
				Properties.Settings.Default.Save();
			}
			if (string.IsNullOrEmpty(Properties.Settings.Default.UserJob))
			{
				Console.WriteLine("Кем Вы, "+ Properties.Settings.Default.UserName+" работаете: ");
				Properties.Settings.Default.UserJob = Console.ReadLine();
				Properties.Settings.Default.Save();
			}
			if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
			{
				Console.WriteLine( Properties.Settings.Default.UserName + ", сколько Вам лет: ");
				Properties.Settings.Default.Age = Console.ReadLine();
				Properties.Settings.Default.Save();
			}
			string userAge =  Properties.Settings.Default.Age;
			string userName = Properties.Settings.Default.UserName;
			string greeting = Properties.Settings.Default.Greeting;
			string userJob =  Properties.Settings.Default.UserJob;
			Console.WriteLine($"{greeting},{userName}!");
			Console.WriteLine("Вам "+ userAge+" и Вы работаете "+userJob+".");
			Console.ReadLine();
		}
	}
}