using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	public GameObject character; 

	// Update is called once per frame
	void Update () {

		if (character.transform.position.x > 9.0f)
		{
			transform.position= new Vector3(character.transform.position.x - 9.0f, 0f ,0f);
		}
	
	}
}
