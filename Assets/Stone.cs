using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);
        transform.Rotate(new Vector3(0, 1, 1));
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            GameManager gmComponenet = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponenet.RestartGame();
        }
    }
}
