using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchEntity : MonoBehaviour
{
    [SerializeField] private MatchFeedback feedback;
    [SerializeField] private MovablePair movablePair;
    [SerializeField] private Renderer fixedPairRenderer;
    [SerializeField] private MatchSystemManager matchSystemManager;

    private bool matched;

    public Vector3 GetMovablePairPosition() {
      return movablePair.GetPosition();
    }

    public void SetMovablePairPosition(Vector3 NewMovablePairPosition) {
      movablePair.SetInitialPosition(NewMovablePairPosition);
    }

    public void SetMaterialToPairs(Material PairMaterial) {
        movablePair.GetComponent<Renderer>().material = PairMaterial;
        fixedPairRenderer.material = PairMaterial;
    }

    public void PairObjectInteraction(bool IsEnter, MovablePair movable) {
      if (IsEnter && !matched) {
        matched = (movable == movablePair);
        if (matched) {
          matchSystemManager.NewMatchRecord(matched);
          feedback.ChangeMaterialWithMatch(matched);
        }
      } else if (!IsEnter && matched) {
        matched = !(movable == movablePair);
        if (!matched) {
          matchSystemManager.NewMatchRecord(matched);
          feedback.ChangeMaterialWithMatch(matched);
        }
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
