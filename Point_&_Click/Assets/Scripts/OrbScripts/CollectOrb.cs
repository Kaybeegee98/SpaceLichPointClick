using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOrb : MonoBehaviour
{
    public Item myItem;
    public bool activated = false;

    [HideInInspector]
    public Collider orbCol;


    void Start()
    {
        this.enabled = false;
        orbCol = GetComponent<Collider>();
    }

    public void OnMouseDown()
    {
        if (activated == true)
        {
            Interact();
        }
    }

    public void Interact()
    {
        GameManager.ins.itemsHeld.Add(myItem);
        GameManager.ins.invDisp.UpdateDisplay();
        if (GameObject.FindGameObjectWithTag("Orb"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Orb"));
        }
    }
}
