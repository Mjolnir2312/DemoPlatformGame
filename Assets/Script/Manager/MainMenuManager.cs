using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuManager : MonoBehaviour
{
   

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }
}
