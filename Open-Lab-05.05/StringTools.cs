using System;
using System.Linq;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        
        public string AlternatingCaps(string original)
        {
            string temp = "";
            
            bool upper = false;
            for (int i = 0; i < original.Length; i++)
            {
                if (char.IsLetter(original[i]))
                {
                    if (upper)
                        temp += char.ToLower(original[i]);
                    else
                        temp += char.ToUpper(original[i]);

                    upper = !upper;

                }
                else
                    temp += original[i];
                
            }
            return temp;
        }


    }
}
