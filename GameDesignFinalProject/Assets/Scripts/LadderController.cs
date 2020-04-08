﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * Time.deltaTime;
        }
    }
}
