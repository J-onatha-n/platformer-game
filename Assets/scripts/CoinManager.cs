using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject ColoredCoin;
    public GameObject DarkCoin; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.coinOne == true)
        {
            ColoredCoin.SetActive(true);
            DarkCoin.SetActive(false);
        }
        if (GameManager.coinOne == false)
        {
            ColoredCoin.SetActive(false);
            DarkCoin.SetActive(true);
        }
    }
}
