using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    public IVCanvas ivCanvas;
    public ObsCamera obsCamera;
    public Node startingNode;

    [HideInInspector]
    public Node currentNode;

    void Awake()
    {
        ins = this;
        ivCanvas.gameObject.SetActive(false);
        obsCamera.gameObject.SetActive(false);
    }

    private void Start()
    {
        startingNode.Arrive();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(1) && currentNode.GetComponent<Location>() != null)
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
    }
}
