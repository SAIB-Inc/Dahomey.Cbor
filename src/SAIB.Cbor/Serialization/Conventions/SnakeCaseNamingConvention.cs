using System.Reflection;

namespace SAIB.Cbor.Serialization.Conventions;

public class SnakeCaseNamingConvention : INamingConvention
{
    public string GetPropertyName(MemberInfo member)
    {
        return NamingConventionExtensions.GetPropertyName(member.Name, (byte)'_');
    }
}
