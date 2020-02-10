﻿using System;
using System.ComponentModel;

namespace WpfEssentials.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="Type"/> class.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Gets a value indicating whether this type implements <see cref="INotifyPropertyChanged"/>.
        /// </summary>
        /// <param name="t">The type to check.</param>
        /// <returns>True if the type is observable, false otherwise.</returns>
        public static bool IsObservable(this Type t)
        {
            return t.GetInterface(nameof(INotifyPropertyChanged)) != null;
        }
    }
}
