using System;
using Gtk;

namespace GtkSharpTest
{
	public class GtkSharpTest
	{
		public static void Main()
		{
			Application.Init();

			Window window = new Window("Hello Mono World");
			window.Show();

			Application.Run();
		}
	}
}
