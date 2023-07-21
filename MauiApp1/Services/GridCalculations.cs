using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public static class GridCalculations
    {
        public static (int gutters, int margins, int columns) CalculateGridValues()
        {
            int gutters = 0;
            int margins = 0;
            int columns = 0;

            double screenWidth = DeviceDisplay.MainDisplayInfo.Width;
            double screenHeight = DeviceDisplay.MainDisplayInfo.Height;
            double dpi = (DeviceDisplay.MainDisplayInfo.Density) * 160;
            double dpWidth = (screenWidth / (dpi / 160f));
            double dpHeight = (screenHeight / (dpi / 160f));

            if (dpWidth > 0 && dpWidth < 600)
            {
                gutters = 16;
                margins = 16;
                columns = 4;
            }
            else if (dpWidth >= 600 && dpWidth <= 719)
            {
                gutters = 16;
                margins = 16;
                columns = 8;
            }
            else if (dpWidth >= 720 && dpWidth <= 839)
            {
                gutters = 24;
                margins = 24;
                columns = 8;
            }
            else if (dpWidth >= 840 && dpWidth <= 959)
            {
                gutters = 24;
                margins = 24;
                columns = 12;
            }
            else if (dpWidth >= 960 && dpWidth <= 1023)
            {
                gutters = 24;
                margins = 24;
                columns = 12;
            }
            else if (dpWidth >= 960 && dpWidth <= 1023)
            {
                gutters = 24;
                margins = 24;
                columns = 12;
            }

            return (gutters, margins, columns);
        }

        public static void ConfigureScreenGrid(Grid screenGrid)
        {
            (int gutters, int margins, int columns) = CalculateGridValues();

            for (int i = 0; i < columns; i++)
            {
                if (i == (columns - 1))
                {
                    ColumnDefinition newcolumn = new ColumnDefinition() { Width = GridLength.Star };
                    screenGrid.ColumnDefinitions.Add(newcolumn);
                }
                else
                {
                    ColumnDefinition newcolumn = new ColumnDefinition() { Width = GridLength.Star };
                    ColumnDefinition newmargincolumn = new ColumnDefinition() { Width = new GridLength(gutters) };
                    screenGrid.ColumnDefinitions.Add(newcolumn);
                    screenGrid.ColumnDefinitions.Add(newmargincolumn);
                }
            }

            screenGrid.Margin = new Thickness(margins, 0, margins, 0); // Margins
        }
    }
}
