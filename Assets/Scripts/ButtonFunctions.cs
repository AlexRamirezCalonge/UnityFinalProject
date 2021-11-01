using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        GameManager._Punctuation = 0;
        SceneManager.LoadScene("MainGameScene", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        GameManager._Punctuation = 0;
        Application.Quit();
    }
}
