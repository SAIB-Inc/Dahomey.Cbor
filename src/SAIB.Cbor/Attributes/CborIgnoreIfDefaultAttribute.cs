using System;

namespace SAIB.Cbor.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class CborIgnoreIfDefaultAttribute : Attribute
    {
    }
}
