﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace aliasBit.Utils
{
    public static class Functions
    {
        public static int GetInt(object value)
        {
            if (value == null) return 0;
            return GetInt(value.ToString());
        }
        public static int GetInt(string val)
        {
            if (string.IsNullOrEmpty(val)) return 0;
            if (val.Contains(".")) val = val.Substring(0, val.IndexOf("."));
            if (val.Equals("true", StringComparison.CurrentCultureIgnoreCase)) return 1;
            int outputVal = 0;
            int.TryParse(val, out outputVal);
            return outputVal;
        }
        public static bool IsValidInt(object value)
        {
            if (value == null) return false;
            int i;
            return int.TryParse(value.ToString(), out i);
        }
        public static bool IsValidByte(object value)
        {
            if (value == null) return false;
            byte b;
            return byte.TryParse(value.ToString(), out b);
        }
        public static byte GetByte(object value)
        {
            if (value == null) return 0;
            byte b;
            if (byte.TryParse(value.ToString(), out b))
            {
                return b;
            }
            return 0;
        }
        public static decimal GetDecimal(object value)
        {
            if (value == null) return 0;
            decimal d;
            if (decimal.TryParse(value.ToString(), out d))
            {
                return d;
            }
            return 0;
        }
        public static string parseString(object obj)
        {
            if (obj == null) return string.Empty;
            return obj.ToString();
        }

        public static string GetStringWithoutSpecialCharacters(string inputString)
        {
            return Regex.Replace(inputString, @"[^\w\.@-]", "_").TrimEnd('_');
        }


        //public static string HTMLToPlainText(string source)
        //{
        //    try
        //    {
        //        string result;

        //        // Remove HTML Development formatting
        //        // Replace line breaks with space
        //        // because browsers inserts space
        //        result = source.Replace("\r", " ");
        //        // Replace line breaks with space
        //        // because browsers inserts space
        //        result = result.Replace("\n", " ");
        //        // Remove step-formatting
        //        result = result.Replace("\t", string.Empty);
        //        // Remove repeating spaces because browsers ignore them
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                                                              @"( )+", " ");

        //        // Remove the header (prepare first by clearing attributes)
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*head([^>])*>", "<head>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"(<( )*(/)( )*head( )*>)", "</head>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(<head>).*(</head>)", string.Empty,
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // remove all scripts (prepare first by clearing attributes)
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*script([^>])*>", "<script>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"(<( )*(/)( )*script( )*>)", "</script>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        //result = System.Text.RegularExpressions.Regex.Replace(result,
        //        //         @"(<script>)([^(<script>\.</script>)])*(</script>)",
        //        //         string.Empty,
        //        //         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"(<script>).*(</script>)", string.Empty,
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // remove all styles (prepare first by clearing attributes)
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*style([^>])*>", "<style>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"(<( )*(/)( )*style( )*>)", "</style>",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(<style>).*(</style>)", string.Empty,
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // insert tabs in spaces of <td> tags
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*td([^>])*>", "\t",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // insert line breaks in places of <BR> and <LI> tags
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*br( )*>", "\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*li( )*>", "\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // insert line paragraphs (double line breaks) in place
        //        // if <P>, <DIV> and <TR> tags
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*div([^>])*>", "\r\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*tr([^>])*>", "\r\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<( )*p([^>])*>", "\r\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<!--(.|\s)*?-->", string.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        // Remove remaining tags like <a>, links, images,
        //        // comments etc - anything that's enclosed inside < >
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"<[^>]*>", string.Empty,
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // replace special characters:
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @" ", " ",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&bull;", " * ",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&lsaquo;", "<",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&rsaquo;", ">",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&trade;", "(tm)",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&frasl;", "/",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&lt;", "<",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&gt;", ">",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&copy;", "(c)",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&reg;", "(r)",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        // Remove all others. More can be added, see
        //        // http://hotwired.lycos.com/webmonkey/reference/special_characters/
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 @"&(.{2,6});", string.Empty,
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // for testing
        //        //System.Text.RegularExpressions.Regex.Replace(result,
        //        //       this.txtRegex.Text,string.Empty,
        //        //       System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //        // make line breaking consistent
        //        result = result.Replace("\n", "\r");

        //        // Remove extra line breaks and tabs:
        //        // replace over 2 breaks with 2 and over 4 tabs with 4.
        //        // Prepare first to remove any whitespaces in between
        //        // the escaped characters and remove redundant tabs in between line breaks
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\r)( )+(\r)", "\r\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\t)( )+(\t)", "\t\t",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\t)( )+(\r)", "\t\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\r)( )+(\t)", "\r\t",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        // Remove redundant tabs
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\r)(\t)+(\r)", "\r\r",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        // Remove multiple tabs following a line break with just one tab
        //        result = System.Text.RegularExpressions.Regex.Replace(result,
        //                 "(\r)(\t)+", "\r\t",
        //                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        //        // Initial replacement target string for line breaks
        //        string breaks = "\r\r\r";
        //        // Initial replacement target string for tabs
        //        string tabs = "\t\t\t\t\t";
        //        int loopBreakThreshold = 0;
        //        for (int index = 0; index < result.Length; index++)
        //        {
        //            result = result.Replace(breaks, "\r\r");
        //            result = result.Replace(tabs, "\t\t\t\t");
        //            breaks = breaks + "\r";
        //            tabs = tabs + "\t";
        //            loopBreakThreshold++;
        //            if (loopBreakThreshold > 100) break;
        //        }

        //        // That's it.
        //        return result;
        //    }
        //    catch
        //    {
        //        return source;
        //    }
        //}
	
	}
}