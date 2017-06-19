using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public SubmarineController player;
    public int count = 5;

	// Use this for initialization
	void Start () {
        instance = this;
        GameObject[] listOfDestroyables = GameObject.FindGameObjectsWithTag("Destroyable"); //Avoid using this as search is expensive
        count = listOfDestroyables.Length;
    } 
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckWin() {


        // GameObject[] listOfDestroyables=GameObject.FindGameObjectWithTag("Destroyable");
        count--;

        UIText.instance.ChangeText("Left with "+ count+" mines to destroy");
        if (count == 0)
        {
            Win();
        }
    }

    public void Win() {
        player.DisableSub("YOU WIN");
        Invoke("ResetGame", 5f);
    }

    public void Lose() {
        player.DisableSub("YOU LOSE");
        Invoke("ResetGame", 5f);
    }

    public void ResetGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
