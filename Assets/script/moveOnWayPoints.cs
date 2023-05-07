using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOnWayPoints : MonoBehaviour
{
    public List<GameObject> waypoints;
    public GameObject road;
    public float speed = 10;
    int index = 0;
     public int CoefRot = 180;
    public bool isLoop = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake() {
       road = GameObject.FindGameObjectWithTag("gauche");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if(distance <= 5)
        {
            if(index < waypoints.Count - 1){
                index++;
                print(index);
            }else{
                if(isLoop){
                    index = 0;
                }
            }
            
           
        }
    }

    public void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("gauche")){
                print("Object");
                transform.Rotate(0, -speed * Time.deltaTime, 0);
                
                
        }
    }
}
