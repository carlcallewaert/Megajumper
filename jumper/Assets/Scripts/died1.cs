using UnityEngine;
using System.Collections;

public class died1 : MonoBehaviour {

	//public Animator childAnimtor;

	private Animator anim;	
	public GameObject endmenu;
	public GameObject ingamedisplay;
	public GameObject buttonup;
	public GameObject buttondown;
	public AudioClip died;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}


	void OnTriggerEnter2D(Collider2D col)
	{

		//tag
		if(col.gameObject.tag == "Lazer")
		{
		anim.SetTrigger("died");

		rigidbody2D.isKinematic = true;
		collider2D.enabled = false;

		endmenu.SetActive(true);
		ingamedisplay.SetActive(false);
		buttonup.SetActive(false);
		buttondown.SetActive(false);

		audio.PlayOneShot(died, 3.0F);

			// wait 2 second to stop recording
			Invoke ("StopRecording", 2f);
			
		}
	}
	
	void StopRecording()
	{
		Everyplay.StopRecording();
	}
}
