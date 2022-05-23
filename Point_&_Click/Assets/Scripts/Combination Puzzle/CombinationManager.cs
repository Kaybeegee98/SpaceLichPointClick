using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CombinationManager : MonoBehaviour
{
    public List<GameObject> ingredientObjects;
    private int arrayIndex;
    private List<Vector3> initialPositions;


    void Start()
    {
        setInitialPositions();
    }

    public void setArrayIndex(int index)
    {
        arrayIndex = index;
    }

    public int getArrayIndex()
    {
        return arrayIndex;
    }

    public void setInitialPositions()
    {
        for (int i = 0; i < ingredientObjects.Count; i++)
        {
            initialPositions[i] = ingredientObjects[i].transform.localPosition;
        }
    }

    public void ResetPositions()
    {
        for (int i = 0; i < ingredientObjects.Count; i++)
        {
            ingredientObjects[i].SetActive(true);
            ingredientObjects[i].transform.localPosition = initialPositions[i];
        }
    }
}