using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 [] - Brackets
 {} - Braces/Egyptian Brackets
 () - Parenthesis

    Hot keys:
 - Clean Code: CTRL + K + D
 - Fold Code: CTRL + M + O
 - UnFold Code: CTRL + M + P
 */

public class Player : MonoBehaviour
{
    public string message = "Hello World!";
    public Rigidbody rigid;
    public float speed = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * speed);
        }
    }
}
