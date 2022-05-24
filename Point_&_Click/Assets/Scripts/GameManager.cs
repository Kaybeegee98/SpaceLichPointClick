using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    public IVCanvas ivCanvas;
    public ObsCamera obsCamera;
    public InventoryDisplay invDisp;
    public UIControl uiControl;

    public Node startingNode;

    [HideInInspector]
    public Node currentNode;
    public List<Item> itemsHeld;

    void Awake()
    {
        ins = this;
        ivCanvas.gameObject.SetActive(false);
        obsCamera.gameObject.SetActive(false);
    }

    private void Start()
    {
        Debug.Log("start");
        startingNode.Arrive();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Waypoint>() != null)
        {
            currentNode.GetComponent<Waypoint>().prevLocation.Arrive();
        }
        else if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Location>() != null)
        {
            currentNode.GetComponent<Location>().room.Arrive();
        }
        else if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Prop>() != null)
        {
            if (ivCanvas.gameObject.activeInHierarchy)
            {
                ivCanvas.Close();
                return;
            }
            if (obsCamera.gameObject.activeInHierarchy)
            {
                obsCamera.Close();
                return;
            }

            currentNode.GetComponent<Prop>().loc.Arrive();
        }
        else if (Input.GetMouseButtonUp(1) && uiControl.direction != "north")
        {
            Sequence seq = DOTween.Sequence();
            seq.Append(Camera.main.transform.DOMove(uiControl.north.position, 0.75f));
            seq.Join(Camera.main.transform.DORotate(uiControl.north.rotation.eulerAngles, 0.75f));

            uiControl.direction = "north";
        }
    }
}
