using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace CourseWork
{
	static class Program
	{
		public static readonly string RegExHelp="http://msdn.microsoft.com/en-us/library/bs2twtah(VS.71).aspx";
		public static i.Data.iDataCollection DC=new i.Data.iDataCollection();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//отображаем числа, даты и т.п. как в США,(Ex: 1.5 вместо 1,5)
			//0x0409 == "en-US"
			Application.CurrentCulture=new System.Globalization.CultureInfo(0x0409);
			Application.Run(new Main());
		}
	}
}