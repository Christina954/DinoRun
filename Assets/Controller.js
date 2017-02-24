#pragma strict
var jheight=5;
var falling=false; 

function Start () {
    falling=true; 
    PlayerPrefs.SetInt("speed", 10);
}

function Update () {
    transform.Translate(Vector3.right*PlayerPrefs.GetInt("speed")*Time.deltaTime); 
    if (Input.GetKeyDown(KeyCode.Space)&&falling==false){
        GetComponent.<Rigidbody2D>().velocity.y=jheight; 
    }
    falling=true; 
}

function OnCollisionStay2D(){
    Debug.Log("collided"); 
    falling=false; 
}