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
    
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinCountres>().CoinCounter();
        Destroy(gameObject);
    }
}
