using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DullOrbSwap : MonoBehaviour
{
    public GameObject orbDull;
    public GameObject orbPurple;
    // public bool gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameStatus = matts puzzle done
    }

    void OnMouseDown()
    {
        orbDull.SetActive(false);
        orbPurple.SetActive(true);
    }
}
