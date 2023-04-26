using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public void Begin()
    {
        SceneManager.LoadScene("start");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("main");
    }


    public void Stop()
    {
        Application.Quit();
    }

    void Update()
    {

    }
}
