

var standing: GameObject;
var moving: GameObject;
var fuelcan : GameObject;
var lazer: GameObject;

function OnTriggerEnter2D (other: Collider2D) {

		
		var spawncan: int = Random.Range(0, 2);
		if (spawncan == 0){ 
			fuelcan.SetActive (false);
			lazer.SetActive (true);
			}
	
		if (spawncan == 1){ 
			fuelcan.SetActive (true);
			lazer.SetActive (false);
			}
	
	moving.transform.position.x = standing.transform.position.x + 35;
	moving.transform.position.y = 0;	
	
}


