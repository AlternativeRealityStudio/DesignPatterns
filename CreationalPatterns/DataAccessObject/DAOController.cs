using UnityEngine;

public class DAOController : MonoBehaviour
{
    private IGameStateDAO gameStateDAO;
    [SerializeField] private int levelNum;
    [SerializeField] private int levelScore;
    [SerializeField] private Vector3 playerPos;
    private void Start()
    { 
        gameStateDAO = new PlayerPrefsGameStateDAO();
        LoadGameState();
    }
    private void OnApplicationQuit()
    {
        SaveGameState(levelNum,levelScore,playerPos);
    }
    public void SaveGameState(int _levelNum,int _score,Vector3 _playerPos)
    {
        GameState gameState = new GameState();
        gameState.level = 1;
        gameState.score = _score;
        gameState.playerPositionX = _playerPos.x;
        gameState.playerPositionY = _playerPos.y;
        gameState.playerPositionZ = _playerPos.z;
        gameStateDAO.SaveGameState(gameState);
        Debug.Log("Game state saved.");
    }

    public void LoadGameState()
    {
        GameState gameState = gameStateDAO.LoadGameState();

        if (gameState != null)
        {
            Debug.Log($"Loaded game state: Level {gameState.level}, Score {gameState.score}, Player Position ({gameState.playerPositionX}, {gameState.playerPositionY}, {gameState.playerPositionZ})");
            levelNum = gameState.level;
            levelScore = gameState.score;
            playerPos.x = gameState.playerPositionX;
            playerPos.y = gameState.playerPositionY;
            playerPos.z = gameState.playerPositionZ;
        }
        else
        {
            Debug.Log("No saved game state found.");
        }
    }
}
