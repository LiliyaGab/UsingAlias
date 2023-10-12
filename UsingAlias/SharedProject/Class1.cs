using System;
using System.Collections.Generic;
using System.Text;
using TestTm = (string, bool);

namespace SharedProject
{
    internal class Class1
    {
        private TestTm tm;

        public Class1(TestTm tm)
        {
            this.tm = tm;
        }

        public TestTm Tm
        {
            get => tm;
            set => tm = value;
        }
    }
}
