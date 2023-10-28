// Example usage in GameSim project
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using DataAccess;
using Utils;
using Serilog;
using GameSim;

namespace GameSim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new service collection
            var services = new ServiceCollection();

            // Configure database services
            services.AddDbContext<GameContext>(options =>
                options.UseNpgsql("Host=localhost;Database=sim;Username=postgres;Password=pass1234;")
                        .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddSerilog(Logger.Instance))));

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();        
            Logger.LogInformation("Game simulation started.");
            var gameState = new GameState();
            var buffDebuffHandler = new BuffDebuffHandler();
            var gameLogic = new GameLogic(gameState, buffDebuffHandler);

            while (!gameLogic.IsWinnerDetermined())
            {
                gameLogic.ExecuteRound();
                // Optionally log the game state after each round
                Logger.LogInformation($"Round {gameState.RoundNumber} completed.");
            }
            Logger.LogInformation("Game simulation ended.");
        }
    }
}

