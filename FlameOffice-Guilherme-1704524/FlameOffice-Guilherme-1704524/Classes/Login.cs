using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameOffice_Guilherme_1704524.Classes
{
    public class Login
    {
        private int id;
        public int ID { get { return id; }  set { { id = value;} } }
        public string login { get; set; }
        public string senha { get; set; }
    }
}
