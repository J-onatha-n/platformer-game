using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public static bool coinOne;
    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        if (instance != null) //!= means not, we are checking if the instance is in the scene
        {
            Destroy(gameObject);
            return;
        }
        
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
