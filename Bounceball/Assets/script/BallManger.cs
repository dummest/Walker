using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallManger : MonoBehaviour
{
    public int itemcount;
    public Text StageCount;
    public Text PlayerCount;


    private void Awake()
    {
        StageCount.text = "/" + itemcount;
    }

    public void GetItem(int count) {
        PlayerCount.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other) //떨어졌을때 스테이지 초기화
    {
        if (other.gameObject.tag == "player")
            SceneManager.LoadScene("stage1");
    }
}
