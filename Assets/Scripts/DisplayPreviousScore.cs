using UnityEngine;
using System.Collections;

public class DisplayPreviousScore : MonoBehaviour {

	private string label;

	void Start () {
		TextMesh textMesh = GetComponent<TextMesh> ();
		label = textMesh.text;
		textMesh.text = label + GameManager.Instance.previousScore;
	}
}
