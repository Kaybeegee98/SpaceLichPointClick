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

    public GameObject orbOneDull;
    public GameObject orbTwoDull;
    public GameObject orbThreeDull;
    public GameObject orbFourDull;
    public GameObject orbFiveDull;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (secondHalf) {
            orbOnePurple.SetActive(true);
            orbTwoPurple.SetActive(true);
            orbThreePurple.SetActive(true);
            orbFourPurple.SetActive(true);
            orbFivePurple.SetActive(true);

            orbOneDull.SetActive(false);
            orbTwoDull.SetActive(false);
            orbThreeDull.SetActive(false);
            orbFourDull.SetActive(false);
            orbFiveDull.SetActive(false);     
        // }
        
   
    }

}
