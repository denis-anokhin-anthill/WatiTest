using System;
using WatiMinApi.Models;

namespace WatiMinApi.Fasades
{
    public static class MinimalApiFasade
    {
        public static SumOutDto Sum(SumInDto inDto)
        {
            var sum = 0;
            inDto.Numbers.ToList().ForEach(n => sum += n);
            var res = new SumOutDto() { res = sum };
            return res;
        }
    }
}
