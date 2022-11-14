using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour
{
    Vector3 movement;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(0, 0, 1);
        animator = GetComponent<Animator>();
        animator.SetBool("walk", true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
        //transform.Rotate(movement * Time.deltaTime);
        
    }
}
