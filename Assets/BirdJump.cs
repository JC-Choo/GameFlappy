using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{

    Rigidbody2D rigid;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");

        // 0 -> 마우스 왼쪽 버튼을 누른다.
        if (Input.GetMouseButtonDown(0))
        {
            // Vector2 = (x, y) 이란 의미이며, Vector3 = (x, y, z) 이다.
            rigid.velocity = Vector2.up * jumpPower; // Vector2.up 은 (0, 1)이며, * x 는 (0, x)이다.
        }
    }
}
