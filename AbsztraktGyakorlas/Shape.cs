﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal abstract class Shape
	{
		bool isHoley;
		string color;

		public string Color { get => color; set => color = value; }

		protected Shape(string color, bool isHoley = false)
		{
			this.color = color;
		}

		//protected Shape(string color)
		//{
		//	this.color = color;
		//	this.isHoley = false;
		//}

		public void MakeHoley()
		{
			isHoley = true;
		}

		public abstract double Perimeter();
		public abstract double Area();

		public override string? ToString()
		{
			return $"{color} - {isHoley}: K: {Perimeter()} T: {Area()}";
		}
	}
}
