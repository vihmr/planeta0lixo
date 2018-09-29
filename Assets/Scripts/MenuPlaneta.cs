using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuPlaneta : MonoBehaviour
{

    public void i(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("LevelOne");
                break;
            case (1):
                SceneManager.LoadScene("LevelTwo");
                break;
            case (2):
                SceneManager.LoadScene("LevelThree");
                break;
            case (3):
                SceneManager.LoadScene("Inicial");
                break;
        }
    }
}
