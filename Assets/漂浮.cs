using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 漂浮 : MonoBehaviour
{
    //User Inputs
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 0.7f;

    //positon storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3 ();

    // Start is called before the first frame update
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            // Spin object around Y-Axis
            transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

            // Float up/down with a Sin()
            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;// 只需要修改 y 坐标

            transform.position = tempPos;// 修改物体的坐标
    }

}

