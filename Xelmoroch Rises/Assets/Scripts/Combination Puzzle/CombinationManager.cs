using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CombinationManager : MonoBehaviour
{
    public List<GameObject> ingredientObjects;
    private int arrayIndex;
    private Color color;
    [SerializeField] Text invText;
    public bool potionComplete;


    void Start()
    {

    }
    void Update() {
        if (color.a == 1) {
            invText.text = "Potion complete: Recharge Orbs";
            potionComplete = true;
        }
    }

    public void setArrayIndex(int index)
    {
        arrayIndex = index;
    }

    public int getArrayIndex()
    {
        return arrayIndex;
    }

    public void setColor(Color chosenColor) {
        color.a = chosenColor.a;
    }
}
