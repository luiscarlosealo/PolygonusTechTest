using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement playerMovement;
    float magnitude = 0f;
    public bool isRunning;

    
    void Start()
    {
                
    }

    
    void Update()
    {
        magnitude = playerMovement.flatVel.magnitude;

        isRunning = magnitude >= 1.0f ? true : false;

        anim.SetBool("IsRunning", isRunning);
    }
}
