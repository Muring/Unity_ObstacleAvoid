using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float startingPoint;

    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;

    // Start is called before the first frame update
    void Start()
    {

        Rigidbody myrigidbody = GetComponent<Rigidbody>();
        //Debug.Log("UseGravity?: " + myrigidbody.useGravity);

        Debug.Log("start");
        startingPoint = transform.position.z;
    }

    // Update is called once per frame
    void Update() //�� �����Ӹ��� �����
    {
        float distance;
        distance = transform.position.z - startingPoint;

        if (Input.GetKeyDown(KeyCode.Space)) //Ű�� ������ ����
            //Input.GetKeyUp Ű�� ���� ����
        {
            //GetComponent<Rigidbody>().AddForce(Vector3.up*300);
            Rigidbody ballRigid;
            ballRigid = gameObject.GetComponent<Rigidbody>();
            ballRigid.AddForce(Vector3.up * 300);
        }
    }
}
