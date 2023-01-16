using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_PartialClass
{
    public partial class NumberPartial
    {
        private int _smallerNumber;
        private int _largerNumber;

        public int SmallerNumber
        {
            get
            {
                return _smallerNumber;
            }
            set
            {
                _smallerNumber = value;
            }
        }

        public int LargerNumber
        {
            get
            {
                return _largerNumber;
            }
            set

            {
                _largerNumber = value;
            }
        }
    }
}
