using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : MonoBehaviour
{
    public MatchEntity ownerMatchEntity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            ownerMatchEntity.PairObjectInteraction(true, CollidedMoveable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            ownerMatchEntity.PairObjectInteraction(false, CollidedMoveable);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
