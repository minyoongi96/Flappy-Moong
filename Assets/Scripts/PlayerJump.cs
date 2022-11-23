using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))     // 마우스가 클릭되었을 때
        {
            GetComponent<AudioSource>().Play();     // AudioSource 컴포넌트의 소리를 실행
            rb.velocity = Vector2.up * jumpPower;   // (0,3)
        }
    }

// Collider들끼리 부딪혔을 때 실행되는 메소드
    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.bestScore < Score.score) Score.bestScore = Score.score;

        SceneManager.LoadScene("GameOverScene");
    }
}
