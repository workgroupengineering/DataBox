﻿using Avalonia;
using Avalonia.Controls;

namespace CellPanelDemo.Controls
{
    public class Cell : Panel
    {
        internal static readonly AttachedProperty<double> ItemWidthProperty = 
            AvaloniaProperty.RegisterAttached<IAvaloniaObject, double>("ItemWidth", typeof(Cell));

        internal static double GetItemWidth(IAvaloniaObject obj)
        {
            return obj.GetValue(ItemWidthProperty);
        }

        internal static void SetItemWidth(IAvaloniaObject obj, double value)
        {
            obj.SetValue(ItemWidthProperty, value);
        }
    }
}