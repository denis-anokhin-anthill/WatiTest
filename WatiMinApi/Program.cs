using Microsoft.AspNetCore.Http.HttpResults;
using WatiMinApi.Fasades;
using WatiMinApi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/add", Results<BadRequest<string>, Ok<SumOutDto>> (SumInDto inDto) =>
{
    if (inDto.Numbers.Count() != 2)
        return TypedResults.BadRequest($"Count of numbers dhould be equal to 2, but got {inDto.Numbers.Count()}");

    //var config = new MapperConfiguration(cfg => cfg.CreateMap<SumInDto, SumIn>().ReverseMap());
    //var inVal = config.CreateMapper().Map<SumIn>(inDto);

    var res = MinimalApiFasade.Sum(inDto);

    return TypedResults.Ok(res);
});

app.Run();
