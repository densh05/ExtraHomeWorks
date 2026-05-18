using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    static class LogginingLoger<T> where T : Employee
    {
       private static Dictionary<T, List<DateTime>> entrance = [];

        public static void Log(T someone)
        {
            if (!entrance.ContainsKey(someone))
            {
                entrance.Add(someone, new List<DateTime> { DateTime.Now });
            }
            else 
            {
                entrance[someone].Add(DateTime.Now);
            } 
        }

        public static List<DateTime> GetAllLogsBy(T who)
        {
            if (!entrance.ContainsKey(who))
            {
                return [];
            }

            var result = entrance[who];
            result.Sort();

            return result;
        }
    }

}
