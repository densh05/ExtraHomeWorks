using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TextWorking
{
    struct Point(int x, int y, ConsoleColor color) : IFormattable
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public ConsoleColor Color { get; set; } = color;

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";

            switch (format.ToUpperInvariant())
            {
                case "G":
                    return $"(X = {X}, Y = {Y})";

                case "M":
                    return $"({X}, {Y})";

                case "FL":
                    Console.BackgroundColor = Color;
                    return $"(X = {X}, Y = {Y})";
                default:
                    throw new FormatException(String.Format($"The {format} format string is not supported."));
            }
        }
    }
}
