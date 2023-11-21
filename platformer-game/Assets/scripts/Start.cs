using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public string sceneName;
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("scene has been changed");
    }
}
