using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PathManager : MonoBehaviour
{
    private GameObject[] pathObjects;
    private Vector3[] pathPositions;
    float time;
    float normal_speed;
    private int currentIndex = 0;
    [SerializeField]
    float speed;

    void Start()
    {
        normal_speed = speed;
        // Find all objects in the scene with the "Path" tag
        pathObjects = GameObject.FindGameObjectsWithTag("Path");

        // Initialize the pathPositions array with the correct size
        pathPositions = new Vector3[pathObjects.Length];

        // Loop through all the path objects and store their positions in the pathPositions array
        for (int i = 0; i < pathObjects.Length; i++)
        {
            pathPositions[i] = pathObjects[i].transform.position;
        }
    time = pathPositions.Length/speed;
        LeanTween.moveSpline ( gameObject, pathPositions,  time);

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other);
        if(other.gameObject.CompareTag("FlaqueChocolat")){
            Debug.Log("I am triggered I am chocolat !");
            speed *= 0.35f;
            Debug.Log(speed);
        }
        if(other.gameObject.CompareTag("FlaqueCaramel") ) speed *= 0.35f;
    }
    void Update()
    {
        if(speed <normal_speed) {
            speed *= 1.02f;
            Debug.Log(speed);
        }
        else speed = normal_speed;
    }
}
