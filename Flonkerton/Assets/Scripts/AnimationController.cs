﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Connects bounce/movement script to its respective jump animation
public class AnimationController : MonoBehaviour
{
    Animator anim;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Bounce bounceScript = player.GetComponent<Bounce>();
        if (bounceScript.jumped)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }
}
