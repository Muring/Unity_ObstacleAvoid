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
        coinText.text = coinCount + "��";
        Debug.Log("���� ���� ����: " + coinCount);
    }
    public void RestartGame()
    {
        Application.LoadLevel("Game");  //Game�̶�� �̸��� Scene���� �ε��϶�
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
            Destroy(obstacles[i]);  //�ش��ϴ� ��ü�� ������� �ڵ�
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
