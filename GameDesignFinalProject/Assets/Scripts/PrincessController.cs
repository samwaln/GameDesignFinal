using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincessController : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject deadText;
    public static bool dead;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.SetActive(false);
        deadText.SetActive(false);
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Hazard")
        {
            dead = true;
            Debug.Log(dead);
            restartButton.SetActive(true);
            deadText.SetActive(true);
        }
        if (coll.tag == "Safety")
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            int level = (int)(name[name.Length - 1]);
            if (sceneName == "Level1")
            {
                SceneManager.LoadScene("EndScreen");
            }
            SceneManager.LoadScene("Level" + (level + 1).ToString());
        }
    }
}
