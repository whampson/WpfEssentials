﻿using System;
using System.Globalization;
using System.Windows.Data;
using WpfEssentials.Win32.Properties;

namespace WpfEssentials.Win32.Converters
{
    /// <summary>
    /// Converts an object to 'true' if not null.
    /// </summary>
    public sealed class NullBooleanConverter : IValueConverter
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException(Resources.NotSupported_ConvertBack);
        }
#pragma warning restore CS1591
    }
}
