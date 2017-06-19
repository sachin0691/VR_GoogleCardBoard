using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // this is the speed indicated by us, how fast we want the camera to change its position 
    public float moveSpeed=1.5f;
    public Transform cameraFacingObject;
	// Update is called once per frame
    //This function is called again and again and if we dont put delta then it just runs
	void Update () {

        //	this.GetComponent<Transform>()                           // this is another way of getting the transform 
         transform.position = transform.position + cameraFacingObject.forward * Time.deltaTime * moveSpeed ;   //delta time is the time to to comeplete the entire loop
          
    }
}
