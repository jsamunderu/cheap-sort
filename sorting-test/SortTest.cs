using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using question_1_excercise_in_sorting;

namespace question_1_excercise_in_sorting_test
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void EmptyString_EmptyString()
        {
            string str = "";
            string result = Program.Sort(str);
            StringAssert.Contains(result, "");
        }

        [TestMethod]
        public void SortString_SortedString()
        {
            string str = "aaabcceeeeeffhiiiikllnnnnooooppprrrrssttttuuy";
            string result = Program.Sort(str);
            StringAssert.Contains(result, "aaabcceeeeeffhiiiikllnnnnooooppprrrrssttttuuy");
        }

        [TestMethod]
        public void WhitespaceString_EmptyString()
        {
            string str = " \n\t";
            string result = Program.Sort(str);
            StringAssert.Contains(result, "");
        }

        [TestMethod]
        public void PuntuationString_EmptyString()
        {
            string str = ",.'\"";
            string result = Program.Sort(str);
            StringAssert.Contains(result, "");
        }

        [TestMethod]
        public void UnicodeJapaneseString_EmptyString()
        {
            string str = new string(new char[] { 'q', '\u70B9', 'z', 'a', '\u83DC', 'n', '0', '7' });
            string result = Program.Sort(str);
            StringAssert.Contains(result, "anqz");
        }

        [TestMethod]
        public void PuntuationEmptyspaceCharactersString_SortedCharactersString()
        {
            string str = "Contrary to popular belief, the pink unicorn fies east";
            string result = Program.Sort(str);
            StringAssert.Contains(result, "aaabcceeeeeffhiiiikllnnnnooooppprrrrssttttuuy");
        }
    }
}
