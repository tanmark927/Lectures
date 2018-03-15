﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Layouts {
	/// <summary>
	/// Interaction logic for GridLayout.xaml
	/// </summary>
	public partial class GridLayout : Window {
		public GridLayout() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			MessageBox.Show("You clicked the button!");
			myButton.Content = "Yay";
		}
	}
}
