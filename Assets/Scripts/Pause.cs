using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPause = false;
    void Update() {
        if(Input.GetKeyDown(KeyCode.Home))
        {
            GamePause();
        }
    }

    public void GamePause()
    {
            if(isPause == false) 
            {
                Time.timeScale = 0;
                isPause = true;
                return;
            }
            else
            {
                Time.timeScale = 1;
                isPause = false;
                return;
            }
            
    }
}
