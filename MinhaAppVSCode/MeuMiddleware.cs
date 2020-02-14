using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
public class MeuMiddleware
{
    private readonly RequestDelegate _next;

    public MeuMiddleware (RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("\n\r ------ ANTES ------ \n\r");

        await _next(context);

        Console.WriteLine("\n\r ------ DEPOIS ------ \n\r");
    }
}