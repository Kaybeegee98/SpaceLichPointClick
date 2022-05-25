using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    Text displayText;

    void Awake()
    {
        displayText = GetComponent<Text>();
    }

    public void UpdateDisplay()
    {
        displayText.text = "Number of Orbs Collected: " + GameManager.ins.itemsHeld.Count;
    }
}
