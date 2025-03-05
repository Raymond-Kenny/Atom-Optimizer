using System;
using System.Windows.Forms;

namespace Atom_Optimizer
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new Form2());
		}
	}
}
