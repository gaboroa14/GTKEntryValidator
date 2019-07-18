//
//  WindowValidada.cs
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
	public class WindowValidada : Gtk.Window
	{
		public WindowValidada () : base(Gtk.WindowType.Toplevel)
		{
		}

		public void ValidarNro (Entry ent)
		{ //Valida que sólo sean números
			string cadena = ent.Text;
			int x;
			for (x = 0; x < cadena.Length; x++) { //Recorre el string del texto del Entry
				if (cadena [x] >= '0' && cadena [x] <= '9') {
				} //Si es un número, no hace nada
		else
					ent.Text = cadena.Substring (0, cadena.Length - 1); //Si es una letra, la elimina
			}
		}

		public void ValidarSoloNroDecimal (Entry ent)
		{
			string cadena = ent.Text;
			int x;
			int cont = 0;
			for (x = 0; x < cadena.Length; x++) { //Recorre el string
				if (cadena [x] >= '0' && cadena [x] <= '9' || cadena [x] == '.' || cadena [x] == ',') { //Valida que sea número, coma o punto
					if (cadena [x] == ',' || cadena [x] == '.') { //Validación para el punto decimal
						if (cont >= 1) { //Verifica si hay punto decimal ya
							ent.Text = cadena.Substring (0, cadena.Length - 1); //Si lo hay, elimina el punto que se intentó introducir
						} else if (cadena [x] == ',') { //Si no hay punto decimal, verifica que se introduzca una coma
							cont++; //Establece que hay comas en el entry
						} else if (cadena [x] == '.') { //Si no hay punto decimal y se introduce un punto
							ent.Text = cadena.Substring (0, cadena.Length - 1) + ','; //Se reemplaza el punto por una coma
							cont++;
						}
					}
				} else //Si no es número ni coma
		ent.Text = cadena.Substring (0, cadena.Length - 1); //Elimina ese caracter
			}
		}

		public void ValidarLetras (Entry ent)
		{
			string cadena = ent.Text;
			int x;
			for (x = 0; x < cadena.Length; x++) {
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena [x] == ' ') {
				} //Verifica que el caracter actual sea una letra mayúscula, minúscula o un espacio
		else
					ent.Text = cadena.Substring (0, cadena.Length - 1); //Si no lo es, lo elimina
			}
		}

		public void ValidarAlfanumerico (Entry ent)
		{
			string cadena = ent.Text;
			int x;
			for (x = 0; x < cadena.Length; x++) {
				if (cadena [x] >= 'A' && cadena [x] <= 'Z' || cadena [x] >= 'a' && cadena [x] <= 'z' || cadena [x] == ' ' || cadena [x] >= '0' && cadena [x] <= '9') {
				} //Similar al anterior, pero también incluye números naturales
		else
					ent.Text = cadena.Substring (0, cadena.Length - 1);
			}
		}
	}
}

