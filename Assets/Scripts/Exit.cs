using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // PC에서는 esc, 안드로이드에서는 백버튼 누를 경우 실행되는 메소드
        if(Input.GetKeyDown(KeyCode.Escape)) GameExit();
    }

    // 프로그램 종료
    public void GameExit() {
        {
            Application.Quit();
        }
    }
}
