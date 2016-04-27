using UnityEngine;
using System.Collections;

public class MoveBasedOnGameSpeed: MonoBehaviour {

	public Vector3 direction = Vector3.forward; //Using Z axis is less costly! Strange but true!


	/*
	void Start ()
	{
		
	}
	*/

	void Update ()
	{
		//Check to see what normalized means.
		transform.position += transform.rotation * (direction.normalized * GameManager.Instance.gameSpeed * Time.deltaTime);
	}
}