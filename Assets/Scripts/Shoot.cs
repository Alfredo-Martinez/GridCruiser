using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public GameObject bullet;

	/*
	void Start ()
	{
	
	}
	*/

	void Update ()
	{

		if(Input.GetButtonDown("Fire1"))
		{
			Instantiate (bullet, transform.position, transform.rotation);	
		}
	}
}