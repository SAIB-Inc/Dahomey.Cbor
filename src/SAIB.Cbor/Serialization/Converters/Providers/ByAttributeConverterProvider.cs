using SAIB.Cbor.Attributes;
using System;
using System.Reflection;

namespace SAIB.Cbor.Serialization.Converters.Providers
{
    public class ByAttributeConverterProvider : CborConverterProviderBase
    {
        public override ICborConverter? GetConverter(Type type, CborOptions options)
        {
            CborConverterAttribute? converterAttribute = type.GetCustomAttribute<CborConverterAttribute>();
            if (converterAttribute != null)
            {
                return CreateConverter(options, converterAttribute.ConverterType);
            }

            return null;
        }
    }
}
