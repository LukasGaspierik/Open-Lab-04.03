using System;
using System.Linq;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (!(original.Length < 3))
            {
                string temp = original;
                temp = String.Join(String.Empty, temp.Skip(1));
                try
                {
                    temp = temp.Remove(temp.Length - 1);
                }
                catch (IndexOutOfRangeException)
                {
                    return "";
                }

                return temp;
            }
            else if (original.Length == 2)
            {
                return "";
            }
            else
            {
                return original;
            }
        }
    }
}
