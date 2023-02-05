using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonKeyboard : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene("Play");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Setting");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
