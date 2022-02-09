using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //LoadInGameMenu();
            BackToMainMenu();
        }
    }

    void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void LoadInGameMenu()
    {

    }
}
