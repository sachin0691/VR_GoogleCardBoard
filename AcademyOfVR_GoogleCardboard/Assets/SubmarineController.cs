using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineController : MonoBehaviour {


    //Tranform hold position and rotation
    public Transform faceObject;
    public float speed = 5f;
    public float rotationSpeed = 10f;
    public bool canMove = true;
  //  public Transform cameraDirection;
    public Transform submarineArt;
    public Transform firingPoint;
    public GameObject torpedoPrefab;
    public bool isActive = true; //This tells whether we are able to do things or not i.e able to move and fire missels
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (isActive) {
            MoveSubForward();
            // if (GvrViewer.Instance.Triggered)
            if(Input.GetMouseButtonDown(0))
            {
           
            FireZeeMissels();
                }
    }
    }

    //we want this to be able to float and not follow rigid concepts like gravity whereas we want it to strike and stop if collide with other 
    //sobjects
    private void MoveSubForward() {
        if (canMove)
        {
            if (faceObject != null)
            {
                this.transform.position += faceObject.forward * Time.deltaTime * speed;
                //lerp is linear interpolation
                //slerp is spheriacal interpolation
                //Using Quaternion to avoid Gimbal Lock
                submarineArt.rotation = Quaternion.Slerp(submarineArt.rotation, faceObject.rotation, Time.deltaTime * rotationSpeed);
            }
            else
            {
                Debug.LogWarning("You forgot to assign the camera");
            }
        }
    }
        

    public void DisableSub(string message) {
        //  canMove = false;          //cant move but can wire
        isActive = false;          //from this we would not be able to mova and fire missles
        UIText.instance.ChangeText(message);
    }

    public void FireZeeMissels() {
        (Instantiate(torpedoPrefab, firingPoint.position, firingPoint.rotation)as GameObject).GetComponent<TorpedoController>().speed += speed;


    }


}
