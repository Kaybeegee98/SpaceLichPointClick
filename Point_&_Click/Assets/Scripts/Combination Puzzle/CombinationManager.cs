using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CombinationManager : MonoBehaviour
{
    [SerializeField] private List<Object> ingredientObjects;
    private int matchAmount;
    private int currentMatches = 0;

    // Start is called before the first frame update
    void Start()
    {
        matchAmount = ingredientObjects.Count;
    }
}
