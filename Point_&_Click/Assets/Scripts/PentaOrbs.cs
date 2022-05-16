using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaOrbs : MonoBehaviour
{
    public GameObject orb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameManager.ins.itemsHeld.RemoveAt(GameManager.ins.itemsHeld.Count - 1);
        GameManager.ins.invDisp.UpdateDisplay();

        orb.SetActive(true);
    }   
}
