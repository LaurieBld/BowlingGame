using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start a game in SceneMenu :
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}