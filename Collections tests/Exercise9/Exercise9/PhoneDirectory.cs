using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> list = new SortedDictionary<string, string>();

        public PhoneDirectory()
        {

        }

        public string PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                return "Name and number cannot be null";
            }

            if (list.ContainsKey(name))
            {
                return "Name or number already exits!";
            }
            else
            {
                list.Add(name, number);
            }

            return "Name or number already exits!";
        }

        public string GetNumber(string name)
        {
            if (list.ContainsKey(name))
            {
                return $"{name} number is {list.Values}";
            }

            return "Found nothing!";
        }

        public string PrintOut()
        {
            foreach (var s in list)
            {
                return s.ToString();
            }

            return null;
        }
    }
}