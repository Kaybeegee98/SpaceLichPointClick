using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CombinationManager : MonoBehaviour
{
    public List<GameObject> ingredientObjects;
    private int arrayIndex;


    void Start()
    {

    }

    public void setArrayIndex(int index)
    {
        arrayIndex = index;
    }

    public int getArrayIndex()
    {
        return arrayIndex;
    }
}
