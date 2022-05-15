using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbFloat : MonoBehaviour
{
    public float frequancy = 0.3f;
    public float amplitude = 0.1f;

    Vector3 posOffSet = new Vector3();
    Vector3 tempPos = new Vector3();

    private void Start()
    {
        posOffSet = transform.position;
    }

    private void Update()
    {
        tempPos = posOffSet;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequancy) * amplitude;

        transform.position = tempPos;
    }
}
