using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
        if (Input.GetKey("escape")){
            Application.Quit();
        }
    }

    void Resume(){
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
