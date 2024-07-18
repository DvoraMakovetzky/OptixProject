using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Primitives;
using System.IO;
using DAL.Dtos;
using System.Text.Json;

namespace BL
{
    public class IdValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public IdValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if ((context.Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase) ||
                 context.Request.Method.Equals("PUT", StringComparison.OrdinalIgnoreCase)) &&
                context.Request.Body != null)
            {
                context.Request.EnableBuffering(); // Enable request body buffering
                using (var reader = new StreamReader(context.Request.Body, leaveOpen: true))
                {
                    var requestBody = await reader.ReadToEndAsync();
                    context.Request.Body.Position = 0; // Reset the position of the stream for the next middleware

                    try
                    {
                        using (JsonDocument document = JsonDocument.Parse(requestBody))
                        {
                            if (document.RootElement.TryGetProperty("id", out JsonElement idElement) &&
                                idElement.TryGetInt64(out long id))
                            {
                                if (!IsValidIsraeliId(id))
                                {
                                    context.Response.StatusCode = 400; // Bad Request
                                    await context.Response.WriteAsync("Invalid Israeli ID.");
                                    return;
                                }
                            }
                            else
                            {
                                context.Response.StatusCode = 400; // Bad Request
                                await context.Response.WriteAsync("ID is missing or invalid.");
                                return;
                            }
                        }
                    }
                    catch (JsonException ex)
                    {
                        context.Response.StatusCode = 400; // Bad Request
                        await context.Response.WriteAsync($"Invalid JSON payload: {ex.Message}");
                        return;
                    }
                }
            }
            //else
            //{
            //    if ((context.Request.Method.Equals("DELETE", StringComparison.OrdinalIgnoreCase) ||
            //    context.Request.Method.Equals("GET", StringComparison.OrdinalIgnoreCase)) &&
            //    context.Request.Body != null)
            //    {

            //    }
            //}
            await _next(context);
        }

        private bool IsValidIsraeliId(long id)
        {
            var idString = id.ToString().PadLeft(9, '0'); // Ensure the ID is 9 digits
            if (idString.Length != 9 || !idString.All(char.IsDigit))
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int num = (int)char.GetNumericValue(idString[i]);
                int weight = i % 2 == 0 ? num : num * 2;
                sum += weight > 9 ? weight - 9 : weight;
            }

            return sum % 10 == 0;
        }
    }
}
