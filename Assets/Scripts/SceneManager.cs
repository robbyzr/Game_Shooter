using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Ke Menu");
    }
    public void MainScene()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Mulai Permainan");
    }
    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}

