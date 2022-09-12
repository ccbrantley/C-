/*
2.7 (Notepad GUI) Create the GUI for the notepad as shown in Fig. 2.36
	a) Manipulating the Form's properties.
	b) Adding a MenuStrip control to the Form.
	c) Adding a RichTextBox to the form.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioGUI
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
