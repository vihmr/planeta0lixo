using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 20f;
    public float padding = 1f;


    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-100f * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(100f * Time.deltaTime, 0, 0);
        }

        float vInput = Input.GetAxis("Vertical");



        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

        float newX = Mathf.Clamp(transform.position.x, 10 + padding, 473 - padding);
        float newY = Mathf.Clamp(transform.position.y, 23 + padding, 242 - padding);
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
    

}
