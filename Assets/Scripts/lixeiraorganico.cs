using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixeiraorganico : MonoBehaviour {

    public Animator anim;

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("jackattack")
        {
            anim.SetTrigger("jackattack2");
            

        }
        else { Application.Quit(); }
    }
}
