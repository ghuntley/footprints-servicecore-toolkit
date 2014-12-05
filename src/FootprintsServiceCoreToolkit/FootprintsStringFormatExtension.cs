namespace FootprintsServiceCoreToolkit
{
    public static class FootprintsStringFormatExtension
    {
        /// <remarks>
        ///     Based off FixFieldsInteraction.js which comes as part of Footprints ServiceCore.
        /// </remarks>
        public static string FromFootprints(this string data)
        {
            if (string.IsNullOrEmpty(data)) return data;

            data = data.Replace("_HISTORY_LINE_BREAK_", "\\n");

            data = data.Replace("__b", " ");

            data = data.Replace("__a", "'");
            data = data.Replace("__q", "\"");
            data = data.Replace("__t", "`");
            data = data.Replace("__m", "@");
            data = data.Replace("__d", ".");
            data = data.Replace("__u", "-");

            data = data.Replace("__s", ";");
            data = data.Replace("__c", ":");
            data = data.Replace("__p", ")");
            data = data.Replace("__P", "(");
            data = data.Replace("__3", "#");
            data = data.Replace("__4", "$");
            data = data.Replace("__5", "%");
            data = data.Replace("__6", "^");
            data = data.Replace("__7", "&");
            data = data.Replace("__8", "*");

            data = data.Replace("__0", "~");
            data = data.Replace("__f", "/");
            data = data.Replace("__F", "\\");
            data = data.Replace("__Q", "?");
            data = data.Replace("__e", "]");
            data = data.Replace("__E", "[");

            data = data.Replace("__g", ">");
            data = data.Replace("__G", "<");
            data = data.Replace("__B", "!");
            data = data.Replace("__W", "{");
            data = data.Replace("__w", "}");
            data = data.Replace("__C", "=");
            data = data.Replace("__A", "+");
            data = data.Replace("__I", "|");
            data = data.Replace("__M", ",");

            return data;
        }

        /// <remarks>
        ///     Based off FixFieldsInteraction.js which comes as part of Footprints ServiceCore.
        /// </remarks>
        public static string ToFootprints(this string data)
        {
            if (string.IsNullOrEmpty(data)) return data;
            data = data.Replace(" ", "__b");

            data = data.Replace("'", "__a");
            data = data.Replace("\"", "__q");
            data = data.Replace("`", "__t");
            data = data.Replace("@", "__m");
            data = data.Replace(".", "__d");
            data = data.Replace("-", "__u");

            data = data.Replace(";", "__s");
            data = data.Replace(":", "__c");
            data = data.Replace(")", "__p");
            data = data.Replace("(", "__P");
            data = data.Replace("#", "__3");
            data = data.Replace("$", "__4");
            data = data.Replace("%", "__5");
            data = data.Replace("^", "__6");
            data = data.Replace("&", "__7");
            data = data.Replace("*", "__8");

            data = data.Replace("~", "__0");
            data = data.Replace("/", "__f");
            data = data.Replace("\\", "__F");
            data = data.Replace("?", "__Q");
            data = data.Replace("]", "__e");
            data = data.Replace("[", "__E");

            data = data.Replace(">", "__g");
            data = data.Replace("<", "__G");
            data = data.Replace("!", "__B");
            data = data.Replace("{", "__W");
            data = data.Replace("}", "__w");
            data = data.Replace("=", "__C");
            data = data.Replace("+", "__A");
            data = data.Replace("|", "__I");
            data = data.Replace(",", "__M");

            return data;
        }
    }
}