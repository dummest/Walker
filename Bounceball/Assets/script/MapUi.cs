using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapUi : MonoBehaviour
{
    public int totalCount;
    public Text stage1Star;
    public Text stage2Star;

    // Start is called before the first frame update
    void Start()
    {
        switch (totalCount)
        {
            case 1:
                stage1Star.text = "*";
                break;
            case 2:
                stage1Star.text = "* *";
                break;
            case 3:
                stage1Star.text = "* * *";
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetTimeCount(int count) {
        totalCount += count;
    }
    public void GetCount(int count)
    {
        totalCount += count;
    }
    public void OnClickstage1() {
        Debug.Log("stage1");
        SceneManager.LoadScene("stage1");
        
    }

    public void OnClickstage2()
    {
        Debug.Log("stage2");
        SceneManager.LoadScene("world");
    }

    public void OnClickBack()
    {
        Debug.Log("main");
        SceneManager.LoadScene("TitleScreen");

    }
}
