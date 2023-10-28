// File: GameSim/GameLogic.cs
namespace GameSim
{
    public class GameLogic
    {
        public GameState GameState { get; }
        private readonly BuffDebuffHandler _buffDebuffHandler;
        public GameLogic(GameState gameState, BuffDebuffHandler buffDebuffHandler)
        {
            GameState = gameState;
            _buffDebuffHandler = buffDebuffHandler;
        }

        public bool IsWinnerDetermined()
        {
            // Implement logic to determine if a winner exists
            return false;
        }
        public void StartRound()
        {
            _buffDebuffHandler.ApplyBattleRulesBuffsAndDebuffs(GameState);
            _buffDebuffHandler.ApplySummonerBuffsAndDebuffs(GameState);
        }
        public void ExecuteRound()
        {
            // Implement logic for executing a round of battle
            GameState.RoundNumber++;
            // ... other game logic ...
        }
    }
}
