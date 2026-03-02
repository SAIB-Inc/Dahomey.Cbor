using System.Reflection;

namespace SAIB.Cbor.Serialization.Conventions
{
    public interface INamingConvention
    {
        string GetPropertyName(MemberInfo member);
    }
}
