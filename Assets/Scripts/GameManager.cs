using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Neede to use SceneManager Class and it's functions

public class GameManager : MonoBehaviour
{
	public static GameManager Instance; //Static so that there is only one instance at a time.
	public float pointsPerUnitTravelled = 1.0f;
	public float gameSpeed = 10.0f;

	private bool gameOver = false;
	private float score = 0.0f;
	private static float highScore = 0.0f;
	private bool hasSaved = false;

	void Start () {
		Instance = this;
		LoadHighScore ();
	}

	void Update () {
		if (GameObject.FindGameObjectWithTag ("Player") == null) {
			gameOver = true;
		}

		if (gameOver) {

			if(!hasSaved) {
				SaveHighScore ();
				hasSaved = true;
			}

			if (Input.anyKeyDown) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
		} 
		else {
			score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
			if (score > highScore) {
				highScore = score;
			}
		}
	}

	void SaveHighScore(){
		PlayerPrefs.SetInt("HighScore", (int)highScore); //saves highscore regardless of platform
		PlayerPrefs.Save();	
	}

	void LoadHighScore(){
		highScore = PlayerPrefs.GetInt ("HighScore"); //Get highscore from saved data
	}

	void OnGUI() {

		//Casts the float score to a an int then to a string.
		GUILayout.Label ( "Score: " + ((int)(score)).ToString());
		GUILayout.Label ( "HighScore: " + ((int)(highScore)).ToString());

		if (gameOver) {
			GUILayout.Label ("Game Over! Press any key to reset!");
		}
	}
}
