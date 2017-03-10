using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Needed to use SceneManager Class and it's functions

//TODO: Episode X time XX:XX

public class GameManager : MonoBehaviour
{

	public static GameManager Instance{
		get{
			if(_instance != null){
				return _instance;	
			}
			else{
				GameObject gameManager = new GameObject ("GameManager");
				_instance = gameManager.AddComponent<GameManager> ();
				return _instance;
			}
		}
	}

	public float pointsPerUnitTravelled = 1.0f;
	public float gameSpeed = 10.0f;
	public string titleScreenName = "TitleScreen";

	[HideInInspector] //This hides the public variable in the editor.
	public int previousScore = 0;

	private static GameManager _instance; //Static so that there is only one instance at a time.
	private bool gameOver = false;
	private float score = 0.0f;
	private static float highScore = 0.0f;
	private bool hasSaved = false;

	void Start () {
		
		if (_instance != this) {
			if (_instance == null) {
				_instance = this;
			}
			else {
				Destroy (gameObject);
			}
		}

		LoadHighScore ();
		DontDestroyOnLoad (gameObject);
	}

	void Update () {

		if(SceneManager.GetActiveScene().name != titleScreenName) {
			if (GameObject.FindGameObjectWithTag ("Player") == null) {
				gameOver = true;
			}

			if (gameOver) {

				if (!hasSaved) {
					SaveHighScore ();
					previousScore = (int)score;
					hasSaved = true;
				}

				if (Input.anyKeyDown) {
					SceneManager.LoadScene (titleScreenName);
				}
			} 
			else {
				score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
				if (score > highScore) {
					highScore = score;
				}
			}
		}
		else {
			//Reset stuff for next game
			ResetGame();
		}
	}

	void ResetGame(){
		score = 0.0f;
		gameOver = false;
		hasSaved = false;

	}

	void SaveHighScore(){
		PlayerPrefs.SetInt("HighScore", (int)highScore); //saves highscore regardless of platform
		PlayerPrefs.Save();	
	}

	void LoadHighScore(){
		highScore = PlayerPrefs.GetInt ("HighScore"); //Get highscore from saved data
	}

	void OnGUI() {

		if( SceneManager.GetActiveScene().name != titleScreenName) {
			
			//Casts the float score to a an int then to a string.
			GUILayout.Label ( "Score: " + ((int)(score)).ToString());
			GUILayout.Label ( "HighScore: " + ((int)(highScore)).ToString());

			if (gameOver) {
				GUILayout.Label ("Game Over! Press any key to quit!");
			}
		}
	}
}
