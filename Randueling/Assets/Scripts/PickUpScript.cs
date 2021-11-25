using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {
	#region Variables to assign via the unity inspector (SerializeFields)


	[SerializeField]
	private float reloadDipAngle = 40.0f;

	[SerializeField]
	private float reloadLowerLength = 0.1f;

	[SerializeField]
	[Range(0.5f, 10.0f)]
	private float spring = 2f;
	[SerializeField]
	[Range(0.01f, 0.16f)]
	private float drag = 0.06f;
	#endregion

	#region Variable Declarations
	private Vector3 targetPos;
	private Vector3 reloadPos;

	private Vector3 targetRot;
	private Vector3 reloadRot;
	float rotRot = 0.0f;
	
	private Vector3 velocity;
	private Vector3 rotateVelocity;
	#endregion

	#region Private Functions
	// Start is called before the first frame update
	void Start() {
		targetPos = transform.localPosition;
		reloadPos = targetPos - new Vector3(0,reloadLowerLength,0);

		targetRot = transform.localRotation.eulerAngles;
		reloadRot = targetRot - new Vector3(reloadDipAngle,0,0);
	}

	private void FixedUpdate() {
		//Move item towards where it should be.
		velocity += (targetPos - transform.localPosition) * spring;
		velocity -= velocity * drag;
		transform.localPosition += velocity * Time.deltaTime;

		//Rotate item towards where it should be
		
	}
	#endregion

	#region Public Access Functions (Getters and setters)

	public void React(float force)
    {
		velocity += Vector3.up * force;
    }

	public void RotReact(float force)
    {
		rotateVelocity += Vector3.right * force;
    }

	public void Reload()
	{
		Vector3 tempVec = targetPos;
		targetPos = reloadPos;
		reloadPos = tempVec;

		//tempVec = targetRot;
		//targetRot = reloadRot;
		//reloadRot = tempVec;
	}


	#endregion
}
