using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClicked : MonoBehaviour
{
    public static string keyClicked;


    void OnMouseDown() { 
        // Debug.Log(this + "key pressed");
        keyClicked = this.name;
        // Debug.Log(keyClicked);

        //Get the Renderer component from the new cube
        var keyRenderer = this.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to white
        keyRenderer.material.SetColor("_Color", Color.white);

        Invoke("ChangeColour", 0.3f);
        
    }

    void ChangeColour() {
        var keyRenderer = this.GetComponent<Renderer>();
        keyRenderer.material.SetColor("_Color", Color.black);
        return;
    }



    // public GameObject clickedKey;
    // public GameObject eKey;
    // public GameObject xKey;
    // // public GameObject oKey;
    // // public GameObject rKey;
    // // public GameObject cKey;
    // // public GameObject iKey;
    // // public GameObject sKey;
    // // public GameObject mKey;

    // // public string value = "";

    // public static int counter;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // void OnMouseDown() {
    //     // if (KeyClicked == eKey) {
    //     //     value = "e";
    //     // }
    //     // if (KeyClicked == xKey) {
    //     //     value = "x";
    //     // }
    //     // else {
    //     //     value = "";
    //     // }

    //     if (counter == 0 && clickedKey == eKey) { 
    //         Debug.Log("e pressed");
    //         counter++;
    //     }
    //     else if (counter == 1 && clickedKey == xKey) { 
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
