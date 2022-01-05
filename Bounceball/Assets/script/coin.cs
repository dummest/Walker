using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float roatespeed;

    void Update()
    {
        transform.Rotate(Vector3.up *roatespeed * Time.deltaTime, Space.World); //È¸Àü
    }

     void OnTriggerEnter(Collider other)
    {
       

    }
}
