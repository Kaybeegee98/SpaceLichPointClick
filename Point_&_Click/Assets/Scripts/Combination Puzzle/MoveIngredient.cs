using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveIngredient : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject couldron;
    [SerializeField] private CombinationManager manager;
    private float cameraZDistance;
    private float colorChangeAmount;
    private Renderer potionMaterial;
    private Color color;
    private float numberOfObjects;
    private List<GameObject> objectsList;
    private int currentArrayIndex = 0;
   
    void Start()
    {
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
        potionMaterial = couldron.GetComponent<Renderer>();
        numberOfObjects = manager.ingredientObjects.Count;
        objectsList = manager.ingredientObjects;
        colorChangeAmount = (1 / numberOfObjects);
        //initialPosition = transform.position;
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
            currentArrayIndex = manager.getArrayIndex();
            Debug.Log(currentArrayIndex);
            if (gameObject.name == objectsList[currentArrayIndex].name)
            {
                gameObject.SetActive(false);
                color = potionMaterial.material.color;
                color.a += colorChangeAmount;
                potionMaterial.material.color = color;
                currentArrayIndex += 1;
                manager.setArrayIndex(currentArrayIndex);
            }
            else
            {
                manager.ResetPositions();
                currentArrayIndex = 0;
                manager.setArrayIndex(currentArrayIndex);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
