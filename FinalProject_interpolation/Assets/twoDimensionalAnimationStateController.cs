using System;
using UnityEngine;

public class twoDimensionalAnimationStateController : MonoBehaviour
{
	private Animator _animator;
	float _velocityZ = 0.0f;
	float _velocityX = 0.0f;
	private const float DeltaVelocity = 0.05f;
	private const float AccelerationWalk = 1.0f;
	private const float AccelerationRun = 2.0f;
	// public float acceleration = 2.0f;
	// public float deceleration = 2.0f;
	private const float MaximumWalkVelocity = 0.5f;
	private const float MaximumRunVelocity = 2.0f;
    
	// Start is called before the first frame update
	void Start()
	{
		// search the gameobject this script is attached to and get the animator component
		_animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		// input will be true if the player is pressing on the passed in key parameter
		// get key inputs from player
		bool forwardPressed = Input.GetKey(KeyCode.W);
		bool runPressed = Input.GetKey(KeyCode.LeftShift);
		bool backPressed = Input.GetKey(KeyCode.S);
		bool leftPressed = Input.GetKey(KeyCode.A);
		bool rightPressed = Input.GetKey(KeyCode.D);
		// Input.anyKey();
        
        
		// Debug.Log("Velocity Z: " + velocityZ + " Velocity X: " + velocityX);
		_velocityZ = CalculateVelocity(_velocityZ, forwardPressed, backPressed, runPressed);
		_velocityX = CalculateVelocity(_velocityX, rightPressed, leftPressed, runPressed);
		
		_animator.SetFloat("VelocityZ", _velocityZ);
		_animator.SetFloat("VelocityX", _velocityX);
	}

	private float CalculateVelocity(float currentVelocity, bool positive, bool negative, bool runPressed)
	{
		if (positive && negative)
		{
			if (runPressed) return currentVelocity;
			if (currentVelocity > MaximumWalkVelocity)
					return ToTargetVelocity(currentVelocity, MaximumWalkVelocity, AccelerationWalk);
			if (currentVelocity < -MaximumWalkVelocity)
					return ToTargetVelocity(currentVelocity, -MaximumWalkVelocity, AccelerationWalk);
			return currentVelocity;
		} 
		else if (positive)
		{
			return ToTargetVelocity(currentVelocity, 
				runPressed ? MaximumRunVelocity : MaximumWalkVelocity, 
				runPressed ? AccelerationRun : AccelerationWalk);
		} 
		else if (negative)
		{
			return ToTargetVelocity(currentVelocity, 
				runPressed ? -MaximumRunVelocity : -MaximumWalkVelocity, 
				runPressed ? AccelerationRun : AccelerationWalk);
		} 
		else
		{
			return ToTargetVelocity(currentVelocity, 
				0.0f, 
				runPressed ? AccelerationRun : AccelerationWalk);
		}
	}

	private float ToTargetVelocity(float currentVelocity, float targetVelocity, float acceleration)
	{
		if (DeltaVelocity < Math.Abs(targetVelocity - currentVelocity))
			currentVelocity += targetVelocity > currentVelocity ? Time.deltaTime * acceleration : -Time.deltaTime * acceleration; 
		else
			currentVelocity = targetVelocity;
		return currentVelocity;
	}
}