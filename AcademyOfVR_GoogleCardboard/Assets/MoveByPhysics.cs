using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByPhysics : MonoBehaviour {


    public float movementspeed = 50f;
    public float jumpForce = 400f;
    public Transform faceDirectionObject;
    private Rigidbody myBody;
	// Use this for initialization 
	void Start () {

        myBody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newForce = faceDirectionObject.forward *movementspeed * Time.deltaTime;
        myBody.AddForce(new Vector3(newForce.x, 0f, newForce.z));

        //if (GvrViewer.Instance.Triggered)
        if(Input.GetMouseButtonDown(0))
        {
            ApplyjumpForce();
        }
	}



    void ApplyjumpForce() {

        myBody.AddForce(this.transform.up * jumpForce);

    }

}
