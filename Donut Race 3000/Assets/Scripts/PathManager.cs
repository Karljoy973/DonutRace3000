using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PathManager : MonoBehaviour
{
    private GameObject[] pathObjects;
    private Vector3[] pathPositions;
    float time = 5f;
    private int currentIndex = 0;

    void Start()
    {
        // Find all objects in the scene with the "Path" tag
        pathObjects = GameObject.FindGameObjectsWithTag("Path");

        // Initialize the pathPositions array with the correct size
        pathPositions = new Vector3[pathObjects.Length];

        // Loop through all the path objects and store their positions in the pathPositions array
        for (int i = 0; i < pathObjects.Length; i++)
        {
            pathPositions[i] = pathObjects[i].transform.position;
        }

        LeanTween.moveSpline ( gameObject, pathPositions,  time);

    }

    void Update()
    {
    
    }
}
