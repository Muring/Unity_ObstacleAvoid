using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log(collider.gameObject.name); // Ʈ���Ÿ� ������ ���� ������Ʈ�� �̸� ���

        if(collider.gameObject.name == "Ball")
        {
            // GameObject.Find("GameManager").SendMessage("RestartGame");

            // gm�̶�� ������ Unity�� Hierarchy�� GameManger�� �о�´�.
            // GameObject gm = GameObject.Find("GameManager");
            // gmComponent�� gm ���� �ȿ� �ִ� GameManager ScriptȤ�� ������Ʈ�� �о�´�.
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
