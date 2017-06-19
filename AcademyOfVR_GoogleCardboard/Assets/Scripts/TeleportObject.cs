using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour {


    //we  made this private so that is doesn't appear on the UI in unity
    private bool teleportFlag = false;
    public float teleportDistance = 1f;
    private Vector3 startingposition;


	// Use this for initialization
	void Start () {
        startingposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Teleport() {

        if (teleportFlag){

            transform.position = startingposition;
        }
        else {
            //. position means the global space position
            transform.position += transform.up *teleportDistance;
 //           transform.localPosition += transform.up * teleportDistance;
            //transform.position = new Vector3(0f, teleportDistance, 0f);
           // transform.localPosition += new Vector3(0f, teleportDistance, 0f);
        }
        teleportFlag = !teleportFlag;// flipping the flag

    }
    
}
