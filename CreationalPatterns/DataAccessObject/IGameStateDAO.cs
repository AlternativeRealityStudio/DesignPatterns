public interface IGameStateDAO
{
    void SaveGameState(GameState gameState);
    GameState LoadGameState();
}
