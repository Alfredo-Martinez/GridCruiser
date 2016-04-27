using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelOnAnyKey : MonoBehaviour {

	public string levelName;
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			SceneManager.LoadScene (levelName);
		}
	}
}
