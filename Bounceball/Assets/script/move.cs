using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    Rigidbody rigid;
    public int itemcount;
    public BallManger manger; 
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
        if(collision.gameObject.CompareTag("forest")) //점프기능 활성화
            isjump = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "item") {    
            itemcount++;
            other.gameObject.SetActive(false); 
            manger.GetItem(itemcount);
            
        }

        else if (other.tag == "final")
        {
            SceneManager.LoadScene("world");
        }
      
    }
}
