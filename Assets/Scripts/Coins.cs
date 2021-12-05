using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,30 * Time.deltaTime,0);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<CoinCountres>().CoinCounter();
        Destroy(gameObject);
    }
}
