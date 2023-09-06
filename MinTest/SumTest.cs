using System;
using WatiMinApi.Fasades;

namespace MinTest
{
    public class SumTest
    {
        [Fact]
        public void SumOk()
        {
            var r = MinimalApiFasade.Sum(new WatiMinApi.Models.SumInDto() { Numbers = new[] { 2, 3 } }).res;
            Assert.Equal(5, r);
        }
    }
}