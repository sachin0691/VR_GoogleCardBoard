using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIText : MonoBehaviour {


    //We made this stati so we do not have to use different for diffrente UI texxts 
    public static UIText instance;

	// Use this for initialization 
	void Start () {
        instance = this;
	}
    public void ChangeText(string newText) {
        this.GetComponent<TextMesh>().text = newText;

    }

}
