using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPiLibrary
{
    public abstract class GPIODevice
    {
        private int[] pinArr;

        public GPIODeviceStatus GPIODeviceStatus
        {
            get => default(GPIODeviceStatus);
            set
            {
            }
        }

        public int pin
        {
            get => default(int);
            set
            {
            }
        }
    }
}