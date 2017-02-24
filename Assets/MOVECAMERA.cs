using UnityEngine;
using System.Collections;

public class MOVECAMERA : MonoBehaviour {
	
	public int score; 
	public float score1; 
	public int highscore; 
	public GUIStyle style1; 

	// Use this for initialization
	void Start () {
		score1 = 0; 
		PlayerPrefs.SetInt ("highscore", 0); //high score should be 0 to start with
		
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime);
		score1 += Time.deltaTime * 10; 
		score = (int)score1; 
		if (highscore < score) {
			PlayerPrefs.SetInt ("highscore", score); 
		}
	}
	void OnGUI(){
		string hiScore = highscore.ToString ();
		string scoredisp = score.ToString (); 

		GUI.Label (new Rect (Screen.width * 0.83f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), scoredisp, style1); 
		//GUI.Label (new Rect (Screen.width * 0.65f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), "Score "+hiScore, style1); 
		GUI.Label (new Rect (Screen.width * 0.65f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), "Score ", style1); 
	}
}
