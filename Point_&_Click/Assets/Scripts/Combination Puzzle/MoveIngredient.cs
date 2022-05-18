using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIngredient : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject ingredient;
    private float cameraZDistance;
    private const string potTag = "Pot";
    private int colorChangeAmount = 85;
    private Renderer potionMaterial;
    // Start is called before the first frame update
    void Start()
    {
        GameObject potion = GameObject.Find("Pot");
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
        potionMaterial = potion.GetComponent<Renderer>();
    }

    void OnMouseDrag()
    {
        Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = NewWorldPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pot")
        {
            ingredient.gameObject.SetActive(false);
            Debug.Log("Object Entered");
            //potionMaterial.material.color
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
