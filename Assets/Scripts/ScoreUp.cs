using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // 트리거를 통과했을 때 실행되는 메소드
    private void OnTriggerEnter2D(Collider2D other) {
        Score.score ++;
    }
}
