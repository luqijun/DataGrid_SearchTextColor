using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataGrid_SearchTextColor
{
    public class CellInfoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string searchText = MainWindow.SearchText;
            List<TextInfo> lstTi = new List<TextInfo>();

            if (value != null)
            {
                string content = value.ToString();
                string[] arrSplit = content.Split(searchText);
                for (int i = 0; i < arrSplit.Length; i++)
                {
                    TextInfo ti = new() { Color = "#000", Text = arrSplit[i] };
                    lstTi.Add(ti);
                    if (i != arrSplit.Length - 1)
                    {
                        ti = new() { Color = "#F00", Text = searchText };
                        lstTi.Add(ti);
                    }
                }
            }

            return lstTi;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}
