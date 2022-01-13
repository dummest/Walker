using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseUi;

    bool IsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseUi.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        Debug.Log("Resume() 호출");
    }
    public void Pause()
    {
        PauseUi.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
        Debug.Log("Pause() 호출");
    }
    public void Quit()
    {
        SceneManager.LoadScene("MapUI");
        Debug.Log("Quit() 호출");
    }
}
