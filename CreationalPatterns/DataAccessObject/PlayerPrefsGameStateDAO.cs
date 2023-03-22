using UnityEngine;
public class PlayerPrefsGameStateDAO : IGameStateDAO
{
    private const string gameStateKey = "gameState";

    public void SaveGameState(GameState gameState)
    {
        string json = JsonUtility.ToJson(gameState);
        PlayerPrefs.SetString(gameStateKey, json);
        PlayerPrefs.Save();
    }

    public GameState LoadGameState()
    {
        if (PlayerPrefs.HasKey(gameStateKey))
        {
            string json = PlayerPrefs.GetString(gameStateKey);
            GameState gameState = JsonUtility.FromJson<GameState>(json);
            return gameState;
        }
        else
        {
            return null;
        }
    }
}
