//
//  MainWindow.cs
//
//  Author:
//       Gabriel Roa <gaboroab14@gmail.com>
//
//  Copyright (c) 2018 Gabriel Roa
//
//  This library is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 2.1 of the
//  License, or (at your option) any later version.
//
//  This library is distributed in the hope that it will be useful, but
//  WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
using System;
using Gtk;

namespace DemostracionValidarEntry
{
	public partial class MainWindow: WindowValidada
	{
		public MainWindow () 
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnEntry1Changed (object sender, EventArgs e)
		{
			ValidarNro(entry1);
		}

		protected void OnEntry2Changed (object sender, EventArgs e)
		{
			ValidarSoloNroDecimal (entry2);
		}

		protected void OnEntry3Changed (object sender, EventArgs e)
		{
			ValidarLetras (entry3);
		}

		protected void OnEntry4Changed (object sender, EventArgs e)
		{
			ValidarAlfanumerico (entry4);
		}
	}
}
