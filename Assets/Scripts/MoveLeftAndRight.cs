using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour
{
	public float speed = 1.0f;

	void Update ()
	{
		//Moves object left and right (speed/every second)
		transform.position += Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime;
	}
}