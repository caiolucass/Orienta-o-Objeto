using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresso
{
    class camaroteInf: VIP
    {
        private string local;

        public string Local
        {
            get { return local; }
            set { this.local = value; }
        }
	}
}

