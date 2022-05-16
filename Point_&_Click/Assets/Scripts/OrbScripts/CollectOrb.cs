using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOrb : MonoBehaviour
{
    public Item myItem;

    [HideInInspector]
    public Collider orbCol;


    void Start()
    {
        this.enabled = false;
        orbCol = GetComponent<Collider>();
    }

    public virtual void OnMouseDown()
    {
            Interact();
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
