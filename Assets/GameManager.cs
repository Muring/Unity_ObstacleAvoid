using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int coinCount = 0;
    public Text coinText;

    void GetCoin()
    {
        coinCount++;
        coinText.text = coinCount + "개";
        Debug.Log("동전 먹은 개수: " + coinCount);
    }
    public void RestartGame()
    {
        Application.LoadLevel("Game");  //Game이라는 이름의 Scene으로 로드하라
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
            Destroy(obstacles[i]);  //해당하는 물체가 사라지는 코드
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
