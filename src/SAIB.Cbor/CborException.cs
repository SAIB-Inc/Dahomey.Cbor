using System;

namespace SAIB.Cbor
{
    public class CborException : Exception
    {
        public CborException(string message)
            : base(message)
        {
        }
    }
}
