using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie_de_voyage_mode_deconnecte
{
    class GereData
    {
        string _connection = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString ;
        public string Connction { get => _connection; }
    }
}
