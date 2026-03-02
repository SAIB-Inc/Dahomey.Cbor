using SAIB.Cbor.Util;
using System.Collections.Generic;

namespace SAIB.Cbor.Serialization.Converters.Mappings
{
    public interface ICreatorMapping
    {
        IReadOnlyCollection<RawString>? MemberNames { get; }
        IReadOnlyCollection<int>? MemberIndexes { get; }
        object CreateInstance(Dictionary<RawString, object> values);
        object CreateInstance(Dictionary<int, object> values);
    }
}
