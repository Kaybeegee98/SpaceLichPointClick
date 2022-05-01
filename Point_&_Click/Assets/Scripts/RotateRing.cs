using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRing : MonoBehaviour
{
    public Vector3 rotation;
    public GameObject ringClicked;
    public GameObject ringOne;
    public GameObject ringTwo;
    public GameObject ringThree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when aligned print console msg and set rotation value to 0 to stop moving
        if (Mathf.Round(ringOne.transform.localRotation.eulerAngles.z) == 270 && Mathf.Round(ringTwo.transform.localRotation.eulerAngles.z) == 90 && Mathf.Round(ringThree.transform.localRotation.eulerAngles.z) == 180) {
            Debug.Log("all aligned");
            rotation.Set(0,0,0);
        }
    }

    void OnMouseDown()
    {
        // rotated clicked ring
        ringClicked.transform.Rotate(rotation);
        
        // print rotation to the console
        Debug.Log("rotation is " + Mathf.Round(ringClicked.transform.localRotation.eulerAngles.z));
    }
}
