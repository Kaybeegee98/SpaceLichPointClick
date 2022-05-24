using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
    // public Image image;

    public GameObject wall;
    public GameObject bars;
    public GameObject border;
    public GameObject door;
    public GameObject keyboard;
    public GameObject barsGreen;
    public GameObject barsPurple;
    public GameObject progressBar;

    public UIControl uiControl;
    public AudioSource rumble;

    [HideInInspector]
    public bool activated = false;
    public bool sound = false;


    void Start()
    {
        orbOne.SetActive(true);
        orbTwo.SetActive(false);
        orbThree.SetActive(false);
        orbFour.SetActive(false);
        orbFive.SetActive(false);
        // image.enabled = false;
    }

    void Update()
    {
        //Debug.Log(GameManager.ins.itemsHeld.Count);

        if ((orbOne.activeSelf && orbTwo.activeSelf && orbThree.activeSelf && orbFour.activeSelf && orbFive.activeSelf) && activated == false)
        {
            boxLid.SetActive(false);
            //maybe on mouse down on box
            // image.enabled = true;
            wall.SetActive(false);
            bars.SetActive(false);
            border.SetActive(true);
            door.SetActive(true);
            keyboard.SetActive(true);
            barsGreen.SetActive(false);
            barsPurple.SetActive(true);
            progressBar.SetActive(true);

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

            activated = true;

            this.GetComponent<Location>().Arrive();

            if (sound == false)
            {
                SoundCheck();
            }
        }
    }

    private void SoundCheck()
    {
        if (rumble != null)
        {
            rumble.Play();
        }

        sound = true;
    }
}