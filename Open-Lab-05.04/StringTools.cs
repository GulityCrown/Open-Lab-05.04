using System;
using System.Text;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            StringBuilder modified = new StringBuilder();
            modified.Capacity = original.Length;
            for (int i = 0; i < original.Length; i++)
            {
                if ((original[i] >= 65 && original[i] <= 90)
                    || (original[i] >= 97 && original[i] <= 122
                        || (original[i] >= 48 && original[i] <= 57
                            || (original[i] == '-' || original[i] == '_' || original[i] == ' '))))
                {
                    modified.Append(original[i]);
                }
            }

            return modified.ToString();
        }
    }
}
