using System;
using System.Collections.Generic;
using Avalonia.Controls;

namespace CellPanelDemo
{
    public class ColumnData
    {
        public GridLength Width { get; set; }

        public double ActualWidth { get; set; }

        public List<double> SharedWidth { get; set; }

        public ColumnData()
        {
            SharedWidth = new();
        }
    }
}
