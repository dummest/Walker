using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    Transform playertransform;
    Vector3 Offset;
    void Awake()
    {
        playertransform = GameObject.Find("player").transform;
        Offset = transform.position  - playertransform.position;
    }

    void LateUpdate()
    {
        transform.position = playertransform.position+Offset;
    }
}
