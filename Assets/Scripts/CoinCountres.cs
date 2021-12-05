using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountres : MonoBehaviour
{
    private int coins;
    
    public void CoinCounter()
    {
        coins++;
        
        if (coins >= 5)
        {
            Text text = FindObjectOfType<Text>();
            text.color = Color.green;
            text.text = "Вы выйграли!";
        }
    }
}
