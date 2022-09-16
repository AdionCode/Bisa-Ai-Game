using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0f, 1f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0f, -1f, 0f);
        }
    }
}
