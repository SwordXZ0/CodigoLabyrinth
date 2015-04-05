using UnityEngine;
using System.Collections;

public class WaitMenu : MonoBehaviour {

	public void Controls(){
		MenuFactoryMethod.createInstructionsGameMenu ();
		Destroy(this.gameObject);
	}
	
	public void Continue(){
		Destroy (this.gameObject);
	}
	
	public void surrender(){
		MenuFactoryMethod.createConfrimationGameMenu ();
		Destroy (this.gameObject);
	}
}

