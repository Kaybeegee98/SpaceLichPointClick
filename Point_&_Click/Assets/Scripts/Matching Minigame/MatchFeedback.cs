using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchFeedback : MonoBehaviour
{
    [SerializeField] private Material matchMaterial;
    [SerializeField] private Material mismatchMaterial;

    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
      renderer = GetComponent<Renderer>();
    }

    public void ChangeMaterialWithMatch(bool IsCorrectMatch) {
      if (IsCorrectMatch) {
        renderer.material = matchMaterial;
      } else {
        renderer.material = mismatchMaterial;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
