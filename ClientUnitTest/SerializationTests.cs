using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient;
using ConsoleClient.Helpers;
using ConsoleClient.Models;
using ConsoleClient.Serializers;
using FluentAssertions;
using NUnit.Framework;

namespace ClientUnitTest
{
    [TestFixture]
    public class SerializationTests
    {
        private List<HmdfEntity> hmdfEntities;
        [OneTimeSetUp]
        public void OnInit()
        {
            hmdfEntities = SerializarionHelpers.GenerateRecords(10);
        }
        [Test]
        public void JsonShouldMatchFields()
        {
            var records = JsonSerialization.Deserialize(JsonSerialization.Serialize(hmdfEntities));
            records.Count.Should().Be(10);
            foreach (var r in records)
            {
                r.RowId.Should().Be(1);
            }

        }

        [Test]
        public void ProtoBufShouldMatchFields()
        {
            var records = ProtoBufSerialization.Deserialize(ProtoBufSerialization.Serialize(hmdfEntities));
            records.Count.Should().Be(10);
            foreach (var r in records)
            {
                r.RowId.Should().Be(1);

            }

        }

        [Test]
        public void MsgPackShouldMatchFields()
        {
            var records = MessagePackSerialization.Deserialize(MessagePackSerialization.Serialize(hmdfEntities));
            records.Count.Should().Be(10);
            foreach (var r in records)
            {
                r.RowId.Should().Be(1);

            }

        }
    }
}
