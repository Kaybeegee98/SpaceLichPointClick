using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class MatchSystemManager : MonoBehaviour
{
    [SerializeField] private List<Material> colorMaterials;
    private List<MatchEntity> matchEntities;
    private int targetMatchCount;
    private int currentMatchCount = 0;
    // Start is called before the first frame update
    void Start()
    {
      matchEntities = transform.GetComponentsInChildren<MatchEntity>().ToList();
      targetMatchCount = matchEntities.Count;
      SetEntityColors();
      RandomizeMovablePairPlacement();
    }

    void SetEntityColors() {
      Shuffle(colorMaterials);

      for (int i = 0; i < matchEntities.Count; i++) {
        matchEntities[i].SetMaterialToPairs(colorMaterials[i]);
      }
    }

    void RandomizeMovablePairPlacement() {
      List<Vector3> movablePairPositions = new List<Vector3>();

      for (int i = 0; i < matchEntities.Count; i++) {
        movablePairPositions.Add(matchEntities[i].GetMovablePairPosition());
      }

      Shuffle(movablePairPositions);

      for (int i = 0; i < matchEntities.Count; i++) {
        matchEntities[i].SetMovablePairPosition(movablePairPositions[i]);
      }
    }

    public void NewMatchRecord(bool MatchConnected) {
      if (MatchConnected) {
        currentMatchCount++;
      } else {
        currentMatchCount--;
      }
      Debug.Log("Currently, there are " + currentMatchCount + " matches");

      if (currentMatchCount == targetMatchCount) {
        Debug.Log("WELL DONE! ALL PAIRED!");
      }
    }

    public static void Shuffle<T>(IList<T> list) {
      int n = list.Count;
      while (n > 1) {
        n--;
        int k = Random.Range(0, n);
        T value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
