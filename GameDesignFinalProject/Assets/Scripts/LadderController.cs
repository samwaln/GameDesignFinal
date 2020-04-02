using System.Collections;
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
            //this.transform.position += this.transform.right * Time.deltaTime * speed;
            //move += Vector3.right;
            Vector2 move = new Vector2(0.03f, 0f);
            transform.Translate(move);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //move -= Vector3.right;
            Vector2 move = new Vector2(-0.03f, 0f);
            transform.Translate(move);
        }
    }
}
