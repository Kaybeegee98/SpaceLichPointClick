using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePair : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private float cameraZDistance;
    private Vector3 initialPosition;
    private bool connected;

    private const string portTag = "Port";
    private const float dragResponseThreshold = 0.5f;

    void OnMouseDrag() {
      Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
      Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);

      if (!connected) {
        transform.position = NewWorldPosition;
      } else if (Vector3.Distance(transform.position, NewWorldPosition) > dragResponseThreshold) {
        connected = false;
      }
    }

    private void OnMouseUp() {
      if (!connected) {
        ResetPosition();
      }
    }

    public Vector3 GetPosition() {
      return transform.position;
    }

    public void SetInitialPosition(Vector3 NewPosition) {
      initialPosition = NewPosition;
      transform.position = initialPosition;
    }

    private void ResetPosition() {
      transform.position = initialPosition;
    }

    private void OnTriggerEnter(Collider other) {
      if (other.gameObject.CompareTag(portTag)) {
        connected = true;
        transform.position = other.transform.position;
      }
    }

    // Start is called before the first frame update
    void Start()
    {
      //mainCamera = Camera.main;
      cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
