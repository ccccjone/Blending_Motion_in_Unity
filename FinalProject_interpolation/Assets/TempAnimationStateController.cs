using System;
using UnityEngine;


public class TempAnimationStateController : MonoBehaviour
{
	// private Animator animator;
	// float velocityZ = 0.0f;
	// float velocityX = 0.0f;
	// public const float acceleration = 2.0f;
	// public const float deceleration = 2.0f;
	// private const float maximumWalkVelocity = 0.5f;
	// private const float maximumRunVelocity = 2.0f;
 //    
	// // Start is called before the first frame update
	// void Start()
	// {
	// 	// search the gameobject this script is attached to and get the animator component
	// 	animator = GetComponent<Animator>();
	// }
	//
	// // Update is called once per frame
	// void Update()
	// {
	// 	// input will be true if the player is pressing on the passed in key parameter
	// 	// get key inputs from player
	// 	bool forwardPressed = Input.GetKey("w");
	// 	bool runPressed = Input.GetKey("left shift");
	// 	bool backPressed = Input.GetKey("s");
	// 	bool leftPressed = Input.GetKey("a");
	// 	bool rightPressed = Input.GetKey("d");
 //        
	// 	// set current velocity
	// 	float currentMaxVelocity = runPressed ? maximumRunVelocity : maximumWalkVelocity;
	//
	//
	// 	// if player presses forward, increase velocity in z direction
	// 	if (forwardPressed && velocityZ < 0.5f && !runPressed)
	// 	{
	// 	    velocityZ += Time.deltaTime * acceleration;
	// 	}
	// 	// if player presses back, decrease velocity in z direction
	// 	if (backPressed && velocityZ > -0.5f && !runPressed)
	// 	{
	// 	    velocityZ -= Time.deltaTime * acceleration;
	// 	}
	// 	
	// 	// increase velocity in left direction
	// 	if (leftPressed && velocityX > -currentMaxVelocity )
	// 	{
	// 	    velocityX -= Time.deltaTime * acceleration;
	// 	}
	// 	
	// 	// increase velocity in right direction
	// 	if (rightPressed && velocityX < currentMaxVelocity )
	// 	{
	// 	    velocityX += Time.deltaTime * acceleration;
	// 	}
	// 	
	// 	// decrease velocityZ
	// 	if (!forwardPressed && velocityZ > 0.0f)
	// 	{
	// 	    velocityZ -= Time.deltaTime * deceleration;
	// 	}
	// 	
	// 	if (!backPressed && velocityZ < 0.0f)
	// 	{
	// 	    velocityZ += Time.deltaTime * deceleration;
	// 	}
	// 	
	// 	// decrease velocity in x direction
	// 	if (!leftPressed && velocityX < 0.0f)
	// 	{
	// 	    velocityX += Time.deltaTime * deceleration;
	// 	}
	// 	
	// 	// reset velocityZ
	// 	if (!forwardPressed && !backPressed && velocityZ != 0.0f && velocityZ > -0.05f && velocityZ < 0.05f)
	// 	{
	// 	    velocityZ = 0.0f;
	// 	}
	// 	
	// 	// increase velocityX if left is not pressed and velocityX < 0
	// 	if (!leftPressed && velocityX < 0.0f)
	// 	{
	// 	    velocityX += Time.deltaTime * deceleration;
	// 	}
	// 	
	// 	// decrease velocityX if right is not pressed and velocityX > 0 
	// 	if (!rightPressed && velocityX > 0.0f)
	// 	{
	// 	    velocityX -= Time.deltaTime * deceleration;
	// 	}
	// 	
	// 	// reset velocityX
	// 	if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.05f && velocityX < 0.05f))
	// 	{
	// 	    velocityX = 0.0f;
	// 	}
 //        
	// 	// Debug.Log("Velocity Z: " + velocityZ + " Velocity X: " + velocityX);
	// 	velocityZ = CalculateVelocity(_velocityZ, forwardPressed, backPressed, runPressed);
	// 	velocityX = CalculateVelocity(_velocityX, rightPressed, leftPressed, runPressed);
	// 	
	// 	animator.SetFloat("Velocity Z", _velocityZ);
	// 	animator.SetFloat("Velocity X", _velocityX);
	// }

}