using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log(collider.gameObject.name); // 트리거를 지나간 게임 오브젝트의 이름 출력

        if(collider.gameObject.name == "Ball")
        {
            // GameObject.Find("GameManager").SendMessage("RestartGame");

            // gm이라는 변수에 Unity의 Hierarchy의 GameManger를 읽어온다.
            // GameObject gm = GameObject.Find("GameManager");
            // gmComponent에 gm 변수 안에 있는 GameManager Script혹은 컴포넌트를 읽어온다.
            // GameManager gmComponent = gm.GetComponenet<GameManager>;

            GameManager gmComponenet = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponenet.RestartGame();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
