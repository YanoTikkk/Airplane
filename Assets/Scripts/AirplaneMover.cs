using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirplaneMover : MonoBehaviour
{
    private Rigidbody airPlaneRb;
    private float h;
    private float v;
    public int health = 3;
    [SerializeField] private Text lost;
    [SerializeField] private GameObject camera;
    [SerializeField] private float speed;
    [SerializeField] private float speedRotate;

    private void Start()
    {
        airPlaneRb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        Mover();
    }

    private void LateUpdate()
    {
        camera.transform.position = transform.position;
    }

    private void Mover()
    {
       h = Input.GetAxis("Horizontal") * speedRotate;
       v = Input.GetAxis("Vertical") * speed;

       airPlaneRb.AddRelativeForce(v, 0f, 0f,ForceMode.VelocityChange);
       airPlaneRb.AddRelativeTorque(0f,0f,-h);

    }

    public void Healt()
    {
        health--;
        
        if (health == 0)
        {
            Destroy(gameObject);
            lost.text = "Вы проиграли(. Жизни закончились";
        }
    }
}
