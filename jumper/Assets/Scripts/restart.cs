using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class restart : MonoBehaviour {

	void Awake() {
		Advertisement.Initialize ("19700");
	}

	
	public void Showadd(){

	
	if(Advertisement.isReady()) {
			Debug.Log ("try to show an ad");
		Advertisement.Show(null, new ShowOptions {
			pause = true,
			resultCallback = result => {
				PerformRestart();
				Debug.Log(result.ToString());
			}
		} );
		}
	else
	{
			print("no ad available");
			PerformRestart();
	}


	}







	
	void PerformRestart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
