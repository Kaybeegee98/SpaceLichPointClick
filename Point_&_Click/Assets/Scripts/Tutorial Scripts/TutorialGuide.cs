using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialGuide : MonoBehaviour
{
    Text tutorialText;

    [HideInInspector]
    public bool orbCollected = false;
    public bool roomVisted = false;

    void Awake()
    {
        tutorialText = GetComponent<Text>();
    }

    public void Update()
    {
        if (GameManager.ins.currentNode.GetComponent<Room>() != null && orbCollected == false)
        {
            roomVisted = true;
            if (GameManager.ins.itemsHeld.Count > 0)
            {
                orbCollected = true;
                tutorialText.text = "Turn to face the pedestal, then Left Click to place the orb down";
            }
            else
            {
                tutorialText.text = "Left Click on either side of the screen to turn around and view the room";
            }
        }
        else if (GameManager.ins.currentNode.GetComponent<Prop>() != null)
        {
            tutorialText.text = "Left Click on the Orb to pick it up and add it to your inventory. Then, Right Click to back out to the previous location";
        }
        else if (GameManager.ins.currentNode.GetComponent<Location>() != null && roomVisted == true)
        {
            tutorialText.text = "Left Click on an object to inspect it, or Right Click to go back to the room";
        }
    }
}
