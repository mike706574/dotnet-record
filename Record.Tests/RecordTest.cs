using System.Collections.Generic;
using Xunit;

namespace Mike.Data.Tests
{
    public class RecordTest
    {
        [Fact]
        public void Equality()
        {
            Record record1 = Record.Of("one", "two", "three", "four");
            Record record2 = Record.Of("one", "two", "three", "four");

            IDictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"one", "two"},
                {"three", "four"}
            };

            Assert.True(record1.Equals(dict));

            Assert.False(record1.Equals(null));
            Assert.True(record1.Equals(record1));
            Assert.True(record1.Equals(record2));
            Assert.True(record2.Equals(record1));

            Assert.True(record2.Equals(dict));
        }

        [Fact]
        public void GetString()
        {
            Record record = Record.Of("foo", "bar");
            Assert.Equal("bar", record.GetString("foo"));
        }

        [Fact]
        public void GetNullString()
        {
            Record record = Record.Of("foo", null);
            Assert.Null(record.GetString("foo"));
        }

        [Fact]
        public void GetMissingString()
        {
            Record record = Record.Of();
            Assert.Null(record.GetString("foo"));
        }

        [Fact]
        public void GetInteger()
        {
            Record record = Record.Of("foo", 1);
            Assert.Equal(1, record.GetInteger("foo"));
        }

        [Fact]
        public void GetNullInteger()
        {
            Record record = Record.Of("foo", null);
            Assert.Null(record.GetInteger("foo"));
        }

        [Fact]
        public void GetMissingInteger()
        {
            Record record = Record.Of();
            Assert.Null(record.GetInteger("foo"));
        }

        [Fact]
        public void GetList()
        {
            Record record = Record.Of("list", new List<string> {"foo", "bar"});
            Assert.Equal(new List<string> {"foo", "bar"},
                record.GetList<string>("list"));
        }

        [Fact]
        public void GetNullList()
        {
            Record record = Record.Of("list", null);
            Assert.Null(record.GetList<string>("list"));
        }

        [Fact]
        public void GetDictionary()
        {
            Record record = Record.Of("dictionary", new Dictionary<string, string> {{"foo", "bar"}});
            Assert.Equal(new Dictionary<string, string> {{"foo", "bar"}},
                record.GetDictionary<string, string>("dictionary"));
        }

        [Fact]
        public void GetMissingDictionary()
        {
            Record record = Record.Empty();
            Assert.Null(record.GetDictionary<string, string>("dictionary"));
        }

        [Fact]
        public void Formatting()
        {
            Record record = Record.Of("foo", 1,
                "bar", "baz");

            Assert.Equal("{foo=1, bar=baz}", record.ToString());
        }
    }
}