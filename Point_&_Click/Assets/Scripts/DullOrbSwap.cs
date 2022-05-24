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
    private bool potionComplete;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (manager.potionComplete)
        {
            potionComplete = true;
        }
    }

    void OnMouseDown()
    {
        if (potionComplete)
        {
            orbDull.SetActive(false);
            orbPurple.SetActive(true);
        }
    }
}
