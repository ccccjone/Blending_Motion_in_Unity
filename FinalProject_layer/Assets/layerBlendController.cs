using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerBlendController : MonoBehaviour
{
	// Animation Transitions With Booleans
	Animator animator;
	int isWalkingHash;
	int isAimingHash;
	
	// Start is called before the first frame update
	void Start()
	{
	    // set reference for animator
	    animator = GetComponent<Animator>();
	    
	    // increases performance
	    isWalkingHash = Animator.StringToHash("isWalking");
	    isAimingHash = Animator.StringToHash("isAiming");
	}
	
	// Update is called once per frame
	void Update()
	{
	    bool isAiming = animator.GetBool(isAimingHash);
	    bool isWalking = animator.GetBool(isWalkingHash);
	    
	    // get key inputs from player
	    bool forwardPressed = Input.GetKey(KeyCode.W);
	    bool aimPressed = Input.GetKey(KeyCode.F);
	    
	    // if player presses w key
	    if (!isWalking && forwardPressed)
	    {
	        // then set the isWalking boolean to be true
	        animator.SetBool(isWalkingHash, true);
	    }
	    
	    
	    // if player is not pressing w key
	    else if (isWalking && !forwardPressed)
	    {
	        // then set the isWalking boolean to be false
	        animator.SetBool(isWalkingHash, false);
	    }
	    
	    // if player presses space key and is not aiming
	    if (!isAiming && aimPressed)
	    {
	        // then set the isAiming boolean to be true
	        animator.SetBool(isAimingHash, true);
	    }
	    
	    // if player is not pressing space key but is aiming
	    if (isAiming && !aimPressed)
	    {
	        // then set the isAiming boolean to be false
	        animator.SetBool(isAimingHash, false);
	    }
	}
}
