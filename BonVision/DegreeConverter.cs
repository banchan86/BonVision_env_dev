﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVision
{
    class DegreeConverter : SingleConverter
    {
        public static float RadianToDegree(float value)
        {
            return (float)(value * (180.0 / Math.PI));
        }

        public static float DegreeToRadian(float value)
        {
            return (float)(value * (Math.PI / 180.0));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                value = ((string)value).TrimEnd('°');
            }

            value = base.ConvertFrom(context, culture, value);
            return DegreeToRadian((float)value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            value = RadianToDegree(Convert.ToSingle(value));
            var result = base.ConvertTo(context, culture, value, destinationType);
            if (destinationType == typeof(string))
            {
                return (string)result + "°";
            }

            return result;
        }
    }
}