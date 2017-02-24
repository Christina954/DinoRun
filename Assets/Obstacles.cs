using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

	public GameObject[] ob; 
	public Transform campos; 

	// Use this for initialization
	void Start () {
		ObstacleMakerLow (); //for cacti and low flying birds
		//ObstacleMakerHigh (); //for higher birds
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * PlayerPrefs.GetInt ("speed") * Time.deltaTime);
		GameObject cs = GameObject.Find ("QuadRedoClone");
		//try to destroy previous cacti objects to save memory
		//if (campos.position.x - cs.transform.position.x > 25) { //changed this from transform.x to transform.position.x 
			//Destroy (cs);
		//}
	}

	void ObstacleMakerLow(){
		GameObject clone = (GameObject)Instantiate (ob [Random.Range (0, ob.Length)], transform.position, Quaternion.identity);
		clone.name = "QuadRedoClone";
		clone.AddComponent<BoxCollider2D> (); 
		clone.GetComponent<BoxCollider2D> ().isTrigger = true; 
		float xx = Random.Range (1,10); 
		Invoke ("ObstacleMakerLow", xx);
	}

}
