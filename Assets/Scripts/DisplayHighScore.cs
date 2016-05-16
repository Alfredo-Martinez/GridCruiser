using UnityEngine;
using System.Collections;

public class DisplayHighScore : MonoBehaviour {

	private string label;

	void Start () {
		TextMesh textMesh = GetComponent<TextMesh> ();
		label = textMesh.text;
		textMesh.text = label + PlayerPrefs.GetInt ("HighScore");
	}
}
