using System;

namespace projLeds1.Core
{
    internal class NumeroLed
    {
        private byte dado;
        public NumeroLed()
        {
            this.dado = 0;
        }

        public NumeroLed(byte dado)
        {
            this.dado = dado;
        }

        public byte getDado()
        {
            return this.dado;
        }
        public void acender(int led)
        {
            int ou = (int)(Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) | ou);
        }

        public void apagar(int led)
        {
            int e = (int)(255 - Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) & e);
        }

        public bool getLed(int led)
        {
            byte checar;
            int e = (int)(Math.Pow(2, led - 1));
            checar = (byte)((int)(this.dado) & e);
            return (checar > 0);
        
        }
    }
}

