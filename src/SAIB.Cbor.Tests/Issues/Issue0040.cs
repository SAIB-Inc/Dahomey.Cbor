using System;
using System.Net;
using SAIB.Cbor.Attributes;
using Xunit;

namespace SAIB.Cbor.Tests.Issues
{
    public class Issue0040
    {
        public class WebserviceResponse
        {
            [CborProperty("status")]
            public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
        }

        [Fact]
        public void EnumConvert()
        {
            var data = "A16673746174757318C8";

            var ex = Record.Exception(()=> {
                Helper.Read<WebserviceResponse>(data);
            });

            Assert.Null(ex);
        }
    }
}
