using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour {
	public bool gameover; //check if game is over
	public GUIStyle style2; 
	public GUIStyle style3; 
	public Texture imagerbutton; 


	void Start () {
		gameover = false;//game should not be over at start of game 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "QuadRedoClone") {
			Time.timeScale = 0; 
			gameover = true; //if there is a cacti collision, gameover=true
		}
	}
	void OnGUI(){
		if (gameover) {
			GUI.Label (new Rect (Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "GAME OVER!", style2); 
			GUI.Label (new Rect (Screen.width * 0.60f, Screen.height * 0.63f, 50, 50), "Click Gray Button to Restart", style3); 
			if (GUI.Button (new Rect (Screen.width * 0.50f, Screen.height * 0.60f, 50,50), imagerbutton)){ //this is going to be the restart button

				//Application.LoadLevel ("Dino_Run_Scene"); //apparently this is obsolete?
				SceneManager.LoadScene("Dino_Run_Scene"); //reload the scene
				Time.timeScale = 1; //set time back to 1 because earlier time was set to 0 at game
			}
		}
	}
}
