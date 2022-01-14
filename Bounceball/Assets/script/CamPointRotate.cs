using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPointRotate : MonoBehaviour
{
    Transform playertransform;
    Vector3 Offset;

    [SerializeField]
    private Transform camPoint;
    void Awake()
    {
        playertransform = GameObject.Find("player").transform;
        camPoint.position = playertransform.position;
        Offset = transform.position - playertransform.position;
    }

    void Update()
    {
        if (Time.timeScale > 0)
            LookAround();
    }
    void LateUpdate()
    {
        transform.position = playertransform.position + Offset;
    }

    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = camPoint.rotation.eulerAngles;

        float x = camAngle.x - mouseDelta.y;

        if(x < 180f)
        {
            x = Mathf.Clamp(x, -1f, 70f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 361f);
        }

        camPoint.rotation = Quaternion.Euler(camAngle.x + mouseDelta.y, camAngle.y + mouseDelta.x, camAngle.z);
    }
}
