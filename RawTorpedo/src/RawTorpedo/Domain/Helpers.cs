using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RawTorpedo
{
    public static class Helpers
    {
        // cribbed from http://geeksharp.com/2011/11/02/power-up-your-enumerations/

        /// <summary>
        /// Provides access to data annotation attribute values for enums
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="e">enum to lookup</param>
        /// <param name="selector">lambda of attribute to retrieve</param>
        /// <returns>Value of the desired attribute, if present, on the current enum value</returns>
        public static string GetAttributeValue<T>(this Enum e, Func<T, object> selector) where T : Attribute
        {
            var output = e.ToString();
            var member = e.GetType().GetMember(output).First();
            var attributes = member.GetCustomAttributes(typeof(T), false);

            if (attributes.Length > 0)
            {
                var firstAttr = (T)attributes[0];
                var str = selector(firstAttr).ToString();
                output = string.IsNullOrWhiteSpace(str) ? output : str;
            }

            return output;
        }

        public static string GetDisplayName(this Enum e)
        {
            return e.GetAttributeValue<DisplayAttribute>(x => x.Name);
        }

        /// <summary>
        /// Converts an enum to a SelectListItem list, using the annotated Display(Name) values as the corresponding dropdown values
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="selectedItem">Item in the enum to be marked as selected (optional)</param>
        /// <returns>List<SelectItemList> to be used as part of an @Html Razor binding for a dropdown</returns>
        public static IEnumerable<SelectListItem> ConvertToSelectList<T>(int? selectedItem = null)
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Select(x => new SelectListItem
            {
                Text = (x as Enum).GetAttributeValue<DisplayAttribute>(y => y.Name),
                Value = Convert.ToInt32(x).ToString(),
                Selected = selectedItem.HasValue ? selectedItem == Convert.ToInt32(x) : false
            });
        }
    }
}
