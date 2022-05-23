using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPuzzle : MonoBehaviour
{
    public int counter = 0;
    public static string key;
    public string previousKey;
    public GameObject door;
    public GameObject keyboard;
    
    void Update() {
        previousKey = key;
        key = KeyClicked.keyClicked;

        if (previousKey != key) {
            CheckKey();
        }
        // Debug.Log(key + "door");
        // if (previousKey != key)
        // {
        //     if (key == "keyE") { 
        //         Debug.Log(counter);
        //         counter++;
        //     }
        //     else if (counter == 1 && key == "keyX") { 
        //         Debug.Log(counter);
        //         counter++;
        //     
        //     // else {
        //     //     Debug.Log("reset");
        //     //     counter = 0;
        //     // }
        //     // clickedKey.SetActive(false);
        //     // Debug.Log(counter + "counter");
        // }

    }

    void CheckKey() {
        if (counter == 0 && key == "keyE") { 
            counter++;
        }
        else if (counter == 1 && key == "keyX") { 
            counter++;
        }
        else if (counter == 2 && key == "keyO") { 
            counter++;
        }
        else if (counter == 3 && key == "keyR") { 
            counter++;
        }
        else if (counter == 4 && key == "keyC") { 
            counter++;
        }
        else if (counter == 5 && key == "keyI") { 
            counter++;
        }
        else if (counter == 6 && key == "keyS") { 
            counter++;
        }
        else if (counter == 7 && key == "keyM") { 
            door.SetActive(false);
            keyboard.SetActive(false);
        }
        else {
            Debug.Log("reset");
            counter = 0;
        }
        Debug.Log(counter);
        // clickedKey.SetActive(false);
        // Debug.Log(counter + "counter");
    }









    // // public GameObject clickedKey;
    // // public GameObject eKey;
    // // public GameObject xKey;
    // // public GameObject oKey;
    // // public GameObject rKey;
    // // public GameObject cKey;
    // // public GameObject iKey;
    // // public GameObject sKey;
    // // public GameObject mKey;

    // public string keyClicked;

    // public int counter = 0;
    
    // // Start is called before the first frame update
    // void Start()
    // {
    //     // counter = 0;
    // }

    // // Update is called once per frame
    // void ThisNeedsToChangeToUpdate()
    // {
    //     //keyClicked = GetComponent<KeyClicked>().value;
    //     if (keyClicked == "e") {
    //         Debug.Log("yay");
    //     }
    // }

    // // void OnMouseDown()
    // // {
    // //     if (counter == 0 && clickedKey == eKey) { 
    // //         Debug.Log("e pressed");
    // //         counter++;
    // //     }
    // //     else if (counter == 0 && clickedKey == xKey) { 
    // //         Debug.Log("x pressed");
    // //         counter++;
    // //     }
    // //     // else {
    // //     //     Debug.Log("reset");
    // //     //     counter = 0;
    // //     // }
    // //     // clickedKey.SetActive(false);
    // //     Debug.Log(counter + "counter");
    // // }
}
