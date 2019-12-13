using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectMenuScr : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level-Scene");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Leve2-Scene");
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("Level3Scene");
    }
}
