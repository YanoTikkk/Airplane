using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mina : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        AirplaneMover healt = new AirplaneMover();
        healt.Healt();
        collision.rigidbody.AddForce(transform.up,ForceMode.Acceleration);
        Destroy(gameObject);
    }
}
