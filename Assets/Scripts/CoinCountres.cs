using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountres : MonoBehaviour
{
    [SerializeField] private Text win;
    private int coins;
    
    public void CoinCounter()
    {
        coins++;
        
        if (coins >= 2)
        {
            win.text = "ВЫ СОБРАЛИ ВСЕ МОНЕТЫ!";
        }
    }
}
