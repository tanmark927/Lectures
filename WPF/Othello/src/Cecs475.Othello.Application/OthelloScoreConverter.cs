using Cecs475.Othello.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Cecs475.Othello.Application
{
    //convert integer score to a string
    public class OthelloScoreConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int score = (int)value;
            if (score == 0)
                return "tie game";
            else if (score > 0)
                return "black is winning by " + score;
            else
                return "white is winning by " + score;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
