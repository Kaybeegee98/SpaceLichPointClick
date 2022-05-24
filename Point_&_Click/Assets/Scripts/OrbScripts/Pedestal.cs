using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    public GameObject orb;
    public AudioSource pickup;

    [HideInInspector]
    public Collider pedestalCol;
    public bool completed = false;

    void Awake()
    {
        pedestalCol = GetComponent<Collider>();
        orb.SetActive(false);
    }

    void OnMouseDown()
    {
        if (!orb.activeInHierarchy)
        {
            if (GameManager.ins.itemsHeld.Count != 0)
            {
                PlaceOrb();
                pickup.Play();
            }
        }
    }

    public void PlaceOrb()
    {
        GameManager.ins.itemsHeld.RemoveAt(GameManager.ins.itemsHeld.Count - 1);
        GameManager.ins.invDisp.UpdateDisplay();

        orb.SetActive(true);
        completed = true;
    }
}
