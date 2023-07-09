
using Microsoft.AspNetCore.SignalR;

namespace SignalRIntro.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSignalR();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapPost("broadcast", async (string message, IHubContext<ChatHub, IChatClient> context) =>
            {
                await context.Clients.All.ReceivedMessage(message);
                return Results.NoContent();
            });

            app.UseHttpsRedirection();
            app.MapHub<ChatHub>("chat-hub");     
            app.Run();
        }
    }
}