using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 move = new Vector2(0.05f, 0f);
            //Debug.Log(move);
            //move += transform.right;
            transform.Translate(move);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector2 move = new Vector2(-0.05f, 0f);
            transform.Translate(move);
        }
    }
}
