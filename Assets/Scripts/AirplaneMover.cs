using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMover : MonoBehaviour
{
    private Rigidbody airPlaneRb;
    private float h;
    private float v;
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
       h = Input.GetAxis("Horizontal");
       v = Input.GetAxis("Vertical");
       
       airPlaneRb.AddRelativeForce(v * speed,0,0,ForceMode.Impulse);
       airPlaneRb.AddRelativeTorque(0,0,-h * speedRotate,ForceMode.Force);

    }
}
