using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// we marked this as "Fixed"Update because we are using it to mess with physics
	void FixedUpdate () {
		// add a forward force
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		// add a forward force to right
		if( Input.GetKey("d") ){
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// add a forward force to left
		if( Input.GetKey("a") ){
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
}
