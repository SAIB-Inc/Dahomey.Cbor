using System;

namespace SAIB.Cbor.Serialization.Converters.Mappings
{
    public interface IObjectMappingConventionProvider
    {
        IObjectMappingConvention? GetConvention(Type type);
    }
}
