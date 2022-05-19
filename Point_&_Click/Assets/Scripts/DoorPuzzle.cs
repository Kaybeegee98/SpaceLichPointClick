using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPuzzle : MonoBehaviour
{
    // public GameObject clickedKey;
    // public GameObject eKey;
    // public GameObject xKey;
    // public GameObject oKey;
    // public GameObject rKey;
    // public GameObject cKey;
    // public GameObject iKey;
    // public GameObject sKey;
    // public GameObject mKey;

    public string keyClicked;

    public int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        // counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // keyClicked = GetComponent<KeyClicked>().value;
        if (keyClicked == "e") {
            Debug.Log("yay");
        }
    }

    // void OnMouseDown()
    // {
    //     if (counter == 0 && clickedKey == eKey) { 
    //         Debug.Log("e pressed");
    //         counter++;
    //     }
    //     else if (counter == 0 && clickedKey == xKey) { 
    //         Debug.Log("x pressed");
    //         counter++;
    //     }
    //     // else {
    //     //     Debug.Log("reset");
    //     //     counter = 0;
    //     // }
    //     // clickedKey.SetActive(false);
    //     Debug.Log(counter + "counter");
    // }
}
