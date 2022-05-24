using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DullOrbSwap : MonoBehaviour
{
    public GameObject orbDull;
    public GameObject orbPurple;
    [SerializeField] private Text invText;
    [SerializeField] CombinationManager manager;
    private bool potionDone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(manager.potionComplete);
        if (manager.potionComplete)
        {
            potionDone = true;
        }
    }

    void OnMouseDown()
    {
        if (potionDone)
        {
            orbDull.SetActive(false);
            orbPurple.SetActive(true);
        }
    }
}
