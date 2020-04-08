using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Loaded scene");
    }
}
