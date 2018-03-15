﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Cecs475.Othello.Application
{

	/// <summary>
	/// Converts from an integer player number to an Ellipse representing that player's token.
	/// </summary>
	public class OthelloSquarePlayerConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int player = (int)value;
			if (player == 0)
			{
				return null;
			}

			Rectangle token = new Rectangle()
			{
				Fill = GetFillBrush(player)
			};
			return token;
		}

		private static SolidColorBrush GetFillBrush(int player)
		{
			if (player == 1)
				return Brushes.Blue;
			return Brushes.Red;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
