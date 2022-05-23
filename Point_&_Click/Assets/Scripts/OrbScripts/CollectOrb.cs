using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOrb : MonoBehaviour
{
    public Item myItem;
    public GameObject orb;
    public AudioSource pickup;

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
        orb.SetActive(false);
    }

    public void Interact()
    {
        GameManager.ins.itemsHeld.Add(myItem);
        GameManager.ins.invDisp.UpdateDisplay();

        if (pickup != null)
        {
            pickup.Play();
        }
    }
}
