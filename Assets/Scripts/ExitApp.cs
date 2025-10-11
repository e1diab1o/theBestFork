using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("app quit");
        Application.Quit();
    }
}