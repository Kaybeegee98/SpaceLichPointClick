using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneScript : MonoBehaviour
{
    public GameObject orb;
    public GameObject orbDull;
    public GameObject rune;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (orb.activeSelf) {
            rune.SetActive(false);
        }
        if (!orb.activeSelf && orbDull.activeSelf) {
            rune.SetActive(false);
        }
        if (!orb.activeSelf && !orbDull.activeSelf) {
            rune.SetActive(true);
        }
    }
}
