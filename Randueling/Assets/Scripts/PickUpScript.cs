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

	[SerializeField]
	[Range(0.5f, 50.0f)]
	private float Rspring = 2f;
	[SerializeField]
	[Range(0.01f, 0.26f)]
	private float Rdrag = 0.06f;
	#endregion

	#region Variable Declarations
	private Vector3 targetPos;
	private Vector3 reloadPos;

	private float targetRot;
	private float reloadRot;
	
	private Vector3 velocity;
	private float rotateVelocity;
	#endregion

	#region Private Functions
	// Start is called before the first frame update
	void Start() {
		targetPos = transform.localPosition;
		reloadPos = targetPos - new Vector3(0,reloadLowerLength,0);

		targetRot = transform.localRotation.x;
		reloadRot = Quaternion.AngleAxis(-reloadDipAngle, transform.right).x;
	}

	private void FixedUpdate() {
		//Move item towards where it should be.
		velocity += (targetPos - transform.localPosition) * spring;
		velocity -= velocity * drag;
		transform.localPosition += velocity * Time.deltaTime;

		//Rotate item towards where it should be
		rotateVelocity += (targetRot - transform.localRotation.x) * Rspring;
		rotateVelocity -= rotateVelocity * Rdrag;
		transform.Rotate(rotateVelocity, 0, 0, Space.Self);
	}
	#endregion

	#region Public Access Functions (Getters and setters)

	public void React(float force)
    {
		velocity += Vector3.up * force;
    }

	public void RotReact(float force)
    {
		rotateVelocity += force;
    }

	public void Reload()
	{
		Vector3 tempVec = targetPos;
		targetPos = reloadPos;
		reloadPos = tempVec;

		float tempRot = targetRot;
		targetRot = reloadRot;
		reloadRot = tempRot;
	}


	#endregion
}
