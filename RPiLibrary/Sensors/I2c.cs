using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPiLibrary
{
    public abstract class I2c : Sensor
    {
        private int _I2cAddr;
        private int I2cAddrArr;

        public I2c()
        {
            throw new System.NotImplementedException();
        }

        public int I2cAddr
        {
            get => default(int);
            set
            {
            }
        }

        public void read()
        {
            throw new System.NotImplementedException();
        }

        public void write()
        {
            throw new System.NotImplementedException();
        }
    }
}