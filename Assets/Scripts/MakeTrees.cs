using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTrees : MonoBehaviour
{
    public GameObject trees;
    public float timeDiff;
    float timer = 0;
    
    private float playTime = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    // 6FPS에선 6번 더해지면 timer는 1 증가
        playTime += Time.deltaTime;

        if(timer > timeDiff)
        {
            GameObject newtrees = Instantiate(trees);   // // trees 게임오브젝트 생성
            newtrees.transform.position = new Vector3(12, Random.Range(-3.4f, 2.45f), 0);
            timer = 0;              // timer 초기화

            if(playTime > 15)    // 게임 플레이 시간 15초마다 속도 높여주기
            {
                Move move =  trees.GetComponent<Move>();

                if(move.speed <= 20) // 최고 속도는 20까지
                {
                    move.speed += 1; // 15초마다 장애물 이동속도 1.5씩 증가
                    playTime = 0;       // playTime 초기화
                }
                
            }
        }

        
        
        
    }
}
