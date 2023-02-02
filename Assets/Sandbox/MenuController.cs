using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Scene To Load")]
    public string _newScene;

    public void buttonClicked()
    {
        SceneManager.LoadScene(_newScene);
    }

    /*public void back()
    {
        
    }*/

}
