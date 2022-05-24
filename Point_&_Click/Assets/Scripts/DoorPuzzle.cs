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
    public GameObject progressBar;
    [SerializeField] Transform progressBarContainer;
    public static bool doorOpen;
    
    void Start() {
        Vector3 progressBarScale = progressBarContainer.localScale;
        progressBarScale.y = 0;
        progressBarContainer.localScale = progressBarScale;
        doorOpen = false;
    }

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

        // Vector3 progressBarScale = progressBarContainer.localScale;
        // progressBarScale.y = catchProgress;
        // progressBarContainer.localScale = progressBarScale;
    }

    void CheckKey() {
        if (key == "keyE") { 
            counter = 1;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.125f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 1 && key == "keyX") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.25f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 2 && key == "keyO") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.375f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 3 && key == "keyR") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.5f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 4 && key == "keyC") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.625f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 5 && key == "keyI") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.75f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 6 && key == "keyS") { 
            counter++;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0.875f;
            progressBarContainer.localScale = progressBarScale;
        }
        else if (counter == 7 && key == "keyM") { 
            door.SetActive(false);
            keyboard.SetActive(false);
            progressBar.SetActive(false);
            doorOpen = true;
            // GetComponent<Dialogue>().UpdateDisplay();
        }
        else {
            Debug.Log("reset");
            counter = 0;
            Vector3 progressBarScale = progressBarContainer.localScale;
            progressBarScale.y = 0;
            progressBarContainer.localScale = progressBarScale;
        }
        // Debug.Log(counter);
        // clickedKey.SetActive(false);
        // Debug.Log(counter + "counter");
        
    }
}
