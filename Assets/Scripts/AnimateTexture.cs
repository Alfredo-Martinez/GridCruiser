using UnityEngine;
using System.Collections;

public class AnimateTexture : MonoBehaviour
{
	public Vector2 speed = Vector2.one;

	// Update is called once per frame
	void Update ()
	{
		GetComponent<Renderer>().material.mainTextureOffset += speed * Time.deltaTime;
	}
}