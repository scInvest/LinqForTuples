using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class SingleSetProperty<T>
    {
        private T property;
        bool wasSet;

        public T Property
        {
            get { return property; }
            set
            {
                if (wasSet)
                    throw new InvalidOperationException("Property can be set only once!");
                wasSet = true;
                property = value;
            }
        }

    }
}
