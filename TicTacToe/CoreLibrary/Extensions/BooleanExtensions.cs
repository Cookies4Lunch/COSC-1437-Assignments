using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

//Spencer Johnson

namespace CoreLibrary.Extensions
{
    /// <summary>
    /// Various extension methods for boolean manipulation
    /// </summary>
    public static class BooleanExtensions
    {
        public static bool ToBool(this object content, bool defaultValue)
        {
            try
            {
                bool boolResult;

                var conversionSuccessful = (bool.TryParse(content.ToString(), out boolResult));

                return conversionSuccessful ? boolResult : defaultValue;
            }

            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return defaultValue;
            }
        }
    }
}
 