using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixeiravidro : MonoBehaviour
{

    public Animator anim;
    private Vector3 startPosition;

    void Update()
    {
        if (GameObject.FindWithTag("vidro"))
        {
        }
    }
    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Jack")
        {
        anim.SetTrigger("jackattack2");

    }
    }
}

