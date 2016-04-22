using Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    class BaseElement : ILoggable 
    {

        public void click()
        {

        }

        public void log()
        {
            throw new NotImplementedException();
        }

        public void setText()
        {

        }

        public override string ToString() {

            return String.Empty;
        }
    }
}
