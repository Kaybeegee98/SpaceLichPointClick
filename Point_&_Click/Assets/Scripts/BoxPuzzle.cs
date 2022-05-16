using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPuzzle : MonoBehaviour
{
    public GameObject orbLocOne;
    public GameObject orbLocTwo;
    public GameObject orbLocThree;
    public GameObject orbLocFour;
    public GameObject orbLocFive;

    public GameObject orbOne;
    public GameObject orbTwo;
    public GameObject orbThree;
    public GameObject orbFour;
    public GameObject orbFive;

    public GameObject boxLid;

    void Start()
    {
        orbOne.SetActive(true);
        orbTwo.SetActive(false);
        orbThree.SetActive(false);
        orbFour.SetActive(false);
        orbFive.SetActive(false);
    }

    void Update()
    {
        Debug.Log(GameManager.ins.itemsHeld.Count);

        if (orbOne.activeSelf && orbTwo.activeSelf && orbThree.activeSelf && orbFour.activeSelf && orbFive.activeSelf)
        {
            boxLid.SetActive(false);
        }
    }
}
