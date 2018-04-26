using System;
using Xunit;

namespace FodyExample
{
    public class NullGuardTest
    {
        [Fact]
        public void Allow_Null_Works()
        {
            new NullClass("Me");
        }

        [Fact]
        public void Disallow_Null_Works()
        {
            Assert.Throws<ArgumentNullException>(() => new NullClass(null));
        }
    }
}
