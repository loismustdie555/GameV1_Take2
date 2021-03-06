﻿using UnityEngine;
using System.Collections;

public class MagePlayer : MonoBehaviour
{

    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //bool fire = Input.GetButtonDown("Fire1");

        animator.SetFloat("Y_Axis", v);
        animator.SetFloat("X_Axis", h);
        //animator.SetBool("Fire", fire);
    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Die");
        }
    }*/
}