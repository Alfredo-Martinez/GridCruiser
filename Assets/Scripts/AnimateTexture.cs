using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour
{
	public Vector2 speed = Vector2.one;

	// TODO: Link the gameSpeed variable from the gameMangager to this script's speed variable.
	void Update ()
	{
		GetComponent<Renderer>().material.mainTextureOffset += speed * Time.deltaTime;
	}
}