using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoController : MonoBehaviour {

    public float speed = 10f;
    public GameObject explosionPrefab;
    public float lifetime = 10f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject,lifetime);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += this.transform.forward * Time.deltaTime * speed;

		
	}


    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Destroyable") {
            Destroy(otherObject.gameObject);
            GameManager.instance.CheckWin();
        }

       
        //Instantiating the explosion where we hit the object
        Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
