using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour {


    //Submarine controller is a class we have created for submarine controller
    public SubmarineController subController;
    public TorpedoController torpedocontroller;
   // public Transform otherObject;


    private void OnTriggerEnter(Collider otherObject)
    {
        Debug.LogWarning("SUB HIT A OBJECT");

        if (otherObject.tag == "Coin")
        {

            subController.speed = 20;
        }
       else
        {
            GameManager.instance.Lose();

        }//  subController.canMove = false;
        
    }


}
