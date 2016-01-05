using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Vector3 direction = Vector3.forward; //Using Z axis is less costly!
	public float speed = 1.0f;

	void Start ()
	{
		
	}

	void Update ()
	{
		//Check to see what normalized means.
		transform.position += transform.rotation * (direction.normalized * speed * Time.deltaTime);
	}
}
