using SAIB.Cbor.Serialization;
using Xunit;
using System;
using SAIB.Cbor.ObjectModel;
using SAIB.Cbor.Serialization.Converters;
using SAIB.Cbor.Tests.Extensions;

namespace SAIB.Cbor.Tests.Issues;

public class Issue0144
{
    [Theory]
    [InlineData("1A5D2A3DDB", null)]
    [InlineData("C01A5D2A3DDB", 0ul)]
    [InlineData("D8641A5D2A3DDB", 100ul)]
    public void ReadSemanticTag(string hexBuffer, ulong? expectedTag)
    {
        byte[] buffer = hexBuffer.HexToBytes();
        
        CborReader reader = new CborReader(buffer.AsSpan());
        CborValue value = new CborValueConverter(new CborOptions()).Read(ref reader);
        
        Assert.Equal(value.SemanticTag, expectedTag);
    }
}