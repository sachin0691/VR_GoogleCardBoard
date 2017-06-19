using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour {
    public float enginePower = 200f;
    public GameObject explosionPreFab;
    public float explosionHeight = 7f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (GvrViewer.Instance.Triggered|| Input.GetKeyDown(KeyCode.Space))
       // {
        //    ApplyJetEngine();
       // }

       // if (Input.GetKeyDown(KeyCode.A) || this.transform.position.y > explosionHeight)
        //{
       //     TrunIntoExplosion();
      //  }
	}

    public void TrunIntoExplosion() {

        GameObject newExplosion=Instantiate(explosionPreFab) as GameObject;
        newExplosion.transform.position = this.transform.position;
        newExplosion.transform.rotation = this.transform.rotation;
        Destroy(this.gameObject);

    }

    void ApplyJetEngine() {

     //   GetComponent<Rigidbody>().AddForce();
        GetComponent<Rigidbody>().AddForce(enginePower*(this.transform.up));
        Debug.Log("Engine Fired");
    }
}
