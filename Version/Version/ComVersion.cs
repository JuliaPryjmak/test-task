using System;
using System.Collections.Generic;
using System.Linq;

namespace Version
{
 public   class  ComVersion
    {
      
      public int CompareVersion(string a, string b)
        {
            List<int> list1 = new List<int>(a.Split('.').Select(int.Parse));
            List<int> list2 = new List<int>(b.Split('.').Select(int.Parse));

            while (list1.Count < list2.Count)
            {
                list1.Add(0);
            }
            while (list2.Count < list1.Count)
            {
                list2.Add(0);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] > list2[i])
                {
                    return 1;
                }
                else if (list1[i] < list2[i])
                {
                    return -1;
                }
            }
            return 0;

        }

        static void Main(string[] args)
        {
            ComVersion cv = new ComVersion();
        }


    }

}

