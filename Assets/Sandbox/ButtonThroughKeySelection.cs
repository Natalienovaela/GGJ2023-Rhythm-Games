using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonThroughKeySelection : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
