using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
        if (PrincessController.dead == false)
        {
            if (moving)
            {
                princess.transform.position += this.transform.right * Time.deltaTime * 0.7f;
                //princess.AddForce(move * 3);
            }
        }
    }

    public void RestartLevel()
    {
        Debug.Log("restart");
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        SceneManager.LoadScene(sceneName);
    }
}
