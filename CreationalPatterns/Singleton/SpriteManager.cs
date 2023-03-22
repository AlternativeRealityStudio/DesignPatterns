using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SpriteManager : MonoBehaviour
{
    public Image UIImage;
    private void Start()
    {
        UIImage.sprite = GameManager.Instance.spriteList[GameManager.Instance.currentLevel];
        StartCoroutine(AfterSeconds(3f));
    }

    IEnumerator AfterSeconds(float _time)
    {
        yield return new WaitForSeconds(_time);
        GameManager.Instance.currentLevel++;
        GameManager.Instance.currentLevel %= GameManager.Instance.maxLevelCount;
        PossibleErrorHandler();

    }

    void PossibleErrorHandler()
    {
        try
        {
            SceneManager.LoadScene(GameManager.Instance.levelNames[GameManager.Instance.currentLevel]);  
        }
        catch (System.Exception e)
        {
            Debug.Log("Failed to load scene" + GameManager.Instance.levelNames[GameManager.Instance.currentLevel] + ": "
               + "Please consider the adding Single and SingletonNext levels to the build settings");
            Debug.LogError(e.Message); 
        }
    }

}
