using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixeiraplastico : MonoBehaviour
{

    public Animator anim;

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Jack")
        {
            anim.SetTrigger("jackattack2");

        }
    }
}
