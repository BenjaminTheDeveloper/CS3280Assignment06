using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowEngine
{

    interface IActivity<T>
    {
        public void Execute();
    }

}
