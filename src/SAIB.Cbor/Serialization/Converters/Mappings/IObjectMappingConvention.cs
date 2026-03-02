using System;
using System.Collections.Generic;
using System.Text;

namespace SAIB.Cbor.Serialization.Converters.Mappings
{
    public interface IObjectMappingConvention
    {
        void Apply<T>(SerializationRegistry registry, ObjectMapping<T> objectMapping);
    }
}
