using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject orbOneDull;
    public GameObject orbTwoDull;
    public GameObject orbThreeDull;
    public GameObject orbFourDull;
    public GameObject orbFiveDull;

    public GameObject boxLid;
    public Image image;

    public GameObject wall;
    public GameObject border;
    public GameObject door;
    public GameObject keyboard;


    void Start()
    {
        orbOne.SetActive(true);
        orbTwo.SetActive(false);
        orbThree.SetActive(false);
        orbFour.SetActive(false);
        orbFive.SetActive(false);
        image.enabled = false;
    }

    void Update()
    {
        Debug.Log(GameManager.ins.itemsHeld.Count);

        if (orbOne.activeSelf && orbTwo.activeSelf && orbThree.activeSelf && orbFour.activeSelf && orbFive.activeSelf)
        {
            boxLid.SetActive(false);
            //maybe on mouse down on box
            image.enabled = true;
            wall.SetActive(false);
            border.SetActive(true);
            door.SetActive(true);
            keyboard.SetActive(true);

            orbOne.SetActive(false);
            orbTwo.SetActive(false);
            orbThree.SetActive(false);
            orbFour.SetActive(false);
            orbFive.SetActive(false);

            orbOneDull.SetActive(true);
            orbTwoDull.SetActive(true);
            orbThreeDull.SetActive(true);
            orbFourDull.SetActive(true);
            orbFiveDull.SetActive(true);
        }
    }
}
