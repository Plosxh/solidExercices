using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolidExercices
{
    public class ConnecteurFichier : IConnecteurInterface
    {
        private String[] _liste = new[] { "1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", "" };

        public string[] GetOperations()
        {
            return _liste;
        }
    }
}
