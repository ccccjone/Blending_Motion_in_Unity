using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    // // Animation Transitions With Booleans
    // Animator animator;
    // int isWalkingHash;
    // int isRunningHash;
    //
    // // Start is called before the first frame update
    // void Start()
    // {
    //     // set reference for animator
    //     animator = GetComponent<Animator>();
    //     
    //     // increases performance
    //     isWalkingHash = Animator.StringToHash("isWalking");
    //     isRunningHash = Animator.StringToHash("isRunning");
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     bool isRunning = animator.GetBool(isRunningHash);
    //     bool isWalking = animator.GetBool(isWalkingHash);
    //     
    //     // get key inputs from player
    //     bool forwardPressed = Input.GetKey("w");
    //     bool runPressed = Input.GetKey("left shift");
    //     
    //     // if player presses w key
    //     if (!isWalking && forwardPressed)
    //     {
    //         // then set the isWalking boolean to be true
    //         animator.SetBool(isWalkingHash, true);
    //     }
    //     
    //     
    //     // if player is not pressing w key
    //     if (isWalking && !forwardPressed)
    //     {
    //         // then set the isWalking boolean to be false
    //         animator.SetBool(isWalkingHash, false);
    //     }
    //     
    //     // if player is walking and not running and presses left shift
    //     if (!isRunning && (forwardPressed && runPressed))
    //     {
    //         // then set the isRunning boolean to be true
    //         animator.SetBool(isRunningHash, true);
    //     }
    //     
    //     // if player is running and stops running or stops walking
    //     if (isRunning && (!forwardPressed || !runPressed))
    //     {
    //         // then set the isRunning boolean to be false
    //         animator.SetBool(isRunningHash, false);
    //     }
    // }


    // Blending Tree: One Dimensional
    Animator animator;

    float Velocity = 0.0f;
    public float Acceleration = 0.3f;
    public float Deceleration = 0.5f;
    int VelocityHash;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // set reference for animator
        animator = GetComponent<Animator>();
        
        // increases performance
        VelocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        
        // get key inputs from player
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        
        
        if (forwardPressed && Velocity < 1.0f)
        {
            Velocity += Time.deltaTime * Acceleration;
        }
        
        if (!forwardPressed && Velocity > 0.0f)
        {
            Velocity -= Time.deltaTime * Deceleration;
        }
        
        if (!forwardPressed && Velocity < 0.0f)
        {
            Velocity = 0.0f;
        }
        
        animator.SetFloat(VelocityHash, Velocity);
        
    }
}
