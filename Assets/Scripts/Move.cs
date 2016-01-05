using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Vector3 direction = Vector3.forward;
	public float speed = 1.0f;

	void Start ()
	{
		
	}

	void Update ()
	{
		transform.position += direction * speed * Time.deltaTime;
	}
}
