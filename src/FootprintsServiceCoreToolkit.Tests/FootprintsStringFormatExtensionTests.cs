using System;
using NUnit.Framework;

namespace FootprintsServiceCoreToolkit.Tests
{
    [TestFixture]
    public class FootprintsStringFormatExtensionTests
    {
        [Test]
        public void FromFootprintsStringShouldDecodeToExpected()
        {
            const string @null = null;
            Assert.IsNull(@null.FromFootprints());
            Assert.AreSame(String.Empty, String.Empty.FromFootprints());

            Assert.AreEqual("_HISTORY_LINE_BREAK_".FromFootprints(), "\\n");

            Assert.AreEqual("__b".FromFootprints(), " ");

            Assert.AreEqual("__a".FromFootprints(), "'");
            Assert.AreEqual("__q".FromFootprints(), "\"");
            Assert.AreEqual("__t".FromFootprints(), "`");
            Assert.AreEqual("__m".FromFootprints(), "@");
            Assert.AreEqual("__d".FromFootprints(), ".");
            Assert.AreEqual("__u".FromFootprints(), "-");

            Assert.AreEqual("__s".FromFootprints(), ";");
            Assert.AreEqual("__c".FromFootprints(), ":");
            Assert.AreEqual("__p".FromFootprints(), ")");
            Assert.AreEqual("__P".FromFootprints(), "(");
            Assert.AreEqual("__3".FromFootprints(), "#");
            Assert.AreEqual("__4".FromFootprints(), "$");
            Assert.AreEqual("__5".FromFootprints(), "%");
            Assert.AreEqual("__6".FromFootprints(), "^");
            Assert.AreEqual("__7".FromFootprints(), "&");
            Assert.AreEqual("__8".FromFootprints(), "*");

            Assert.AreEqual("__0".FromFootprints(), "~");
            Assert.AreEqual("__f".FromFootprints(), "/");
            Assert.AreEqual("__F".FromFootprints(), "\\");
            Assert.AreEqual("__Q".FromFootprints(), "?");
            Assert.AreEqual("__e".FromFootprints(), "]");
            Assert.AreEqual("__E".FromFootprints(), "[");

            Assert.AreEqual("__g".FromFootprints(), ">");
            Assert.AreEqual("__G".FromFootprints(), "<");
            Assert.AreEqual("__B".FromFootprints(), "!");
            Assert.AreEqual("__W".FromFootprints(), "{");
            Assert.AreEqual("__w".FromFootprints(), "}");
            Assert.AreEqual("__C".FromFootprints(), "=");
            Assert.AreEqual("__A".FromFootprints(), "+");
            Assert.AreEqual("__I".FromFootprints(), "|");
            Assert.AreEqual("__M".FromFootprints(), ",");
        }

        [Test]
        public void ToFootprintsStringShouldEncodeToExpected()
        {
            const string @null = null;
            Assert.IsNull(@null.ToFootprints());
            Assert.AreEqual(String.Empty, String.Empty.ToFootprints());

            Assert.AreEqual(" ".ToFootprints(), "__b");

            Assert.AreEqual("'".ToFootprints(), "__a");
            Assert.AreEqual("\"".ToFootprints(), "__q");
            Assert.AreEqual("`".ToFootprints(), "__t");
            Assert.AreEqual("@".ToFootprints(), "__m");
            Assert.AreEqual(".".ToFootprints(), "__d");
            Assert.AreEqual("-".ToFootprints(), "__u");

            Assert.AreEqual(";".ToFootprints(), "__s");
            Assert.AreEqual(":".ToFootprints(), "__c");
            Assert.AreEqual(")".ToFootprints(), "__p");
            Assert.AreEqual("(".ToFootprints(), "__P");
            Assert.AreEqual("#".ToFootprints(), "__3");
            Assert.AreEqual("$".ToFootprints(), "__4");
            Assert.AreEqual("%".ToFootprints(), "__5");
            Assert.AreEqual("^".ToFootprints(), "__6");
            Assert.AreEqual("&".ToFootprints(), "__7");
            Assert.AreEqual("*".ToFootprints(), "__8");

            Assert.AreEqual("~".ToFootprints(), "__0");
            Assert.AreEqual("/".ToFootprints(), "__f");
            Assert.AreEqual("\\".ToFootprints(), "__F");
            Assert.AreEqual("?".ToFootprints(), "__Q");
            Assert.AreEqual("]".ToFootprints(), "__e");
            Assert.AreEqual("[".ToFootprints(), "__E");

            Assert.AreEqual(">".ToFootprints(), "__g");
            Assert.AreEqual("<".ToFootprints(), "__G");
            Assert.AreEqual("!".ToFootprints(), "__B");
            Assert.AreEqual("{".ToFootprints(), "__W");
            Assert.AreEqual("}".ToFootprints(), "__w");
            Assert.AreEqual("=".ToFootprints(), "__C");
            Assert.AreEqual("+".ToFootprints(), "__A");
            Assert.AreEqual("|".ToFootprints(), "__I");
            Assert.AreEqual(",".ToFootprints(), "__M");
        }
    }
}