using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRing : MonoBehaviour
{
    public Vector3 rotation;
    public Vector3 transformation;
    public GameObject ringClicked;
    public GameObject ringInner;
    public GameObject ringMiddle;
    public GameObject ringOuter;
    public GameObject orb;
    public bool complete;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        // when aligned print console msg and set rotation value to 0 to stop moving
        // if (Mathf.Round(ringInner.transform.localRotation.eulerAngles.y) == 180 && Mathf.Round(ringMiddle.transform.localRotation.eulerAngles.y) == 90 && Mathf.Round(ringOuter.transform.localRotation.eulerAngles.y) == 180) {
        if (Mathf.Round(ringInner.transform.localRotation.eulerAngles.y) == Mathf.Round(ringMiddle.transform.localRotation.eulerAngles.y) && Mathf.Round(ringOuter.transform.localRotation.eulerAngles.y) == Mathf.Round(ringMiddle.transform.localRotation.eulerAngles.y) && !complete) {
            Debug.Log("all aligned");
            rotation.Set(0, 0, 0);
            orb.transform.Translate(transformation);
            complete = true;
        }
    }

    void OnMouseDown()
    {
        // rotated clicked ring
        ringClicked.transform.Rotate(rotation);
        
        // print rotation to the console
        Debug.Log("rotation is " + Mathf.Round(ringClicked.transform.localRotation.eulerAngles.y));
    }
}
