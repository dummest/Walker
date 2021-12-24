using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    Rigidbody rigid;
    public int itemcount;
    bool isjump;
    void Awake()
    {
        isjump = false;
        rigid = GetComponent<Rigidbody>();        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")&& !isjump) {
            isjump = true;
            rigid.AddForce(new Vector3(0, 40, 0), ForceMode.Impulse);
        }

    }


    void FixedUpdate()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Quad" || collision.gameObject.name == "floor")
        {
            isjump = false;
        }   
        if(collision.gameObject.name== "floor1")
            isjump = false; 
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "final")
        {
            SceneManager.LoadScene("stage1");
        }
    }
}
