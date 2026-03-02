using System;
using System.Collections.Generic;
using System.Text;

namespace SAIB.Cbor.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class CborIgnoreAttribute : Attribute
    {
    }
}
