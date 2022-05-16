using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOrb : MonoBehaviour
{
    public Item myItem;
    public GameObject orb;

    [HideInInspector]
    public Collider orbCol;


    void Start()
    {
        this.enabled = false;
        orbCol = GetComponent<Collider>();
    }

    public void OnMouseDown()
    {
        GameManager.ins.itemsHeld.Add(myItem);
        GameManager.ins.invDisp.UpdateDisplay();
        orb.SetActive(false);
        // Destroy(orb);
        // Interact();
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
