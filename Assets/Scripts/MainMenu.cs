using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    public void StartButton()
    {
        GameObject.FindWithTag("NextScene").GetComponent<Text>().text = "Scene1";
        SceneManager.LoadScene("Middle");
        //LoadManager.instance.StartGame();
    }


    public void QuitButton()
    {
        Application.Quit();
    }

    public void OptionButton()
    {

    }

    public void DevelopMembersButton()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
