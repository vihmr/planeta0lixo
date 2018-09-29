using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackControl : MonoBehaviour {

    public Animator anim;

 
    private void OnTriggerEnter2D(Collider2D co)
        {
        
        if (co.name == "Jack")
            {
            Destroy(gameObject);
            anim.SetTrigger("jackattack");
            }
        }
    }





