using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject
{
    public static class DataServiceFactory
    {
        private static bool TestMode;
        public static IContactDataService GetDataService()
        {
            if (TestMode)
            {
                return new TestContactDataService();
            }
            else
            {
                return new WebContactDataService();
            }
        }
    }
}
