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

    // public Image image;

    public static bool lichSealed;

    // Start is called before the first frame update
    void Start()
    {
        lichSealed = false;
        // image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (orbOnePurple.activeSelf && orbTwoPurple.activeSelf && orbThreePurple.activeSelf && orbFourPurple.activeSelf && orbFivePurple.activeSelf) {
            boxLid.SetActive(true);
            lichSealed = true;
            // image.enabled = true;
        }
    }
}
