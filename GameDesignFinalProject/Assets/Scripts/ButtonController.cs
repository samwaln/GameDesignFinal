using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonController : MonoBehaviour
{
    public Rigidbody2D princess;
    bool moving;
    Vector3 move;

    private void Start()
    {
        moving = false;
        //princess = GetComponent<Rigidbody2D>();
    }

    public void RunGame()
    {
        moving = true;
    }

    public void Update()
    {
        move = Vector3.zero;
        if (moving)
        {
            move += transform.right;
        }
    }

    private void FixedUpdate()
    {
        princess.transform.position += this.transform.right * Time.deltaTime * 0.7f;
        //princess.AddForce(move * 3);
    }
}
