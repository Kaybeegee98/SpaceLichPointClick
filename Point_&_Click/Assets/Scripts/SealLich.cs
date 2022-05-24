using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealLich : MonoBehaviour
{
    public GameObject orbOnePurple;
    public GameObject orbTwoPurple;
    public GameObject orbThreePurple;
    public GameObject orbFourPurple;
    public GameObject orbFivePurple;

    public GameObject boxLid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (orbOnePurple.activeSelf && orbTwoPurple.activeSelf && orbThreePurple.activeSelf && orbFourPurple.activeSelf && orbFivePurple.activeSelf) {
            boxLid.SetActive(true);
        }
    }
}
