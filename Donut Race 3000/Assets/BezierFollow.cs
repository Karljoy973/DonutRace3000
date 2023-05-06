using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierFollow : MonoBehaviour
{
    [SerializeField]
    private Transform[] routes;
    private int routTOGO;
    private float tParam;
    private Vector2 CarPositon;
    private bool CoroutineAllowed;
    private float speedModifier;
    // Use this for initialization
    void Start()
    {
        routTOGO = 0;
        tParam = 0f;
        speedModifier = 0.5f;
        CoroutineAllowed = true;
    }
    // Update is called once per frame
    void update()
    {
        if (CoroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routTOGO));
        }
    }
    private IEnumerator GoByTheRoute(int routeNumber)
    {
        CoroutineAllowed = false;
        Vector2 p0 = routes[routeNumber].GetChild(0).position;
        Vector2 p1 = routes[routeNumber].GetChild(1).position;
        Vector2 p2 = routes[routeNumber].GetChild(2).position;
        Vector2 p3 = routes[routeNumber].GetChild(3).position;
        while (tParam < 1)
        {
            tParam += Time.deltaTime * speedModifier;
            CarPositon = Mathf.Pow(1 - tParam, 3) * p0 +
                3 * Mathf.Pow(1 - tParam, 2) * p1 +
                3 * (1 - tParam) * Mathf.Pow(tParam, 2) * p2 +
                Mathf.Pow(tParam, 3) * p3;
            transform.position = CarPositon;
            yield return new WaitForEndOfFrame();
        }
        tParam = 0f;
        routTOGO += 1;
        if(routTOGO > routes.Length - 1)
        {
            routTOGO = 0;
        }
        CoroutineAllowed=true;
    }
}
