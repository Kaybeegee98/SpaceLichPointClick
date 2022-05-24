using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : MonoBehaviour
{
    public MatchEntity ownerMatchEntity;

    public bool insert = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            if (insert == false)
            {
                ownerMatchEntity.PairObjectInteraction(true, CollidedMoveable);

                insert = true;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MovablePair CollidedMoveable))
        {
            ownerMatchEntity.PairObjectInteraction(false, CollidedMoveable);

            insert = false;
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
