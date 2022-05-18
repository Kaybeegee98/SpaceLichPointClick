using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClicked : MonoBehaviour
{
    public GameObject clickedKey;
    public GameObject eKey;
    public GameObject xKey;
    // public GameObject oKey;
    // public GameObject rKey;
    // public GameObject cKey;
    // public GameObject iKey;
    // public GameObject sKey;
    // public GameObject mKey;

    // public string value = "";

    public static int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        // if (KeyClicked == eKey) {
        //     value = "e";
        // }
        // if (KeyClicked == xKey) {
        //     value = "x";
        // }
        // else {
        //     value = "";
        // }

        if (counter == 0 && clickedKey == eKey) { 
            Debug.Log("e pressed");
            counter++;
        }
        else if (counter == 1 && clickedKey == xKey) { 
            Debug.Log("x pressed");
            counter++;
        }
        // else {
        //     Debug.Log("reset");
        //     counter = 0;
        // }
        // clickedKey.SetActive(false);
        Debug.Log(counter + "counter");

    }
}
