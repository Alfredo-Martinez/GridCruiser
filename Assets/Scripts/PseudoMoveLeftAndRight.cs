using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRight : MonoBehaviour
{
	public float speed = 1.0f;

	// TODO: Link the gameSpeed variable from GameManager to this script's speed variable.
	void Update ()
	{
		GetComponent<Renderer>().material.mainTextureOffset += Input.GetAxis("Horizontal") * Vector2.right * speed * Time.deltaTime;
	}
}