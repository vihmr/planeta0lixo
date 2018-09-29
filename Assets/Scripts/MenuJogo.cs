using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuJogo : MonoBehaviour
{

    public void i(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("MenuPlaneta");
                break;
           
        }
    }
}
