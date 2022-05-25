using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : Interactable
{
    public Item myItem;

    public override void Interact()
    {
        GameManager.ins.itemsHeld.Add(myItem);
        GameManager.ins.invDisp.UpdateDisplay();
        if (GameObject.FindGameObjectWithTag("Orb"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Orb"));
        }
    }

}
