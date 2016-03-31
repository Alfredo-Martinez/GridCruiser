using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRight : MonoBehaviour
{
	public float speed = 1.0f;

	// Update is called once per frame
	void Update ()
	{
		GetComponent<Renderer>().material.mainTextureOffset += Input.GetAxis("Horizontal") * Vector2.right * speed * Time.deltaTime;
	}
}