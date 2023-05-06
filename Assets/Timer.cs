using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   
    float time;
    public float timeInterval = 10f;
    float tick;

     
   /*  void Awake(){
        time = (int)Time.timeSinceLevelLoad;
        tick = timeInterval;
    } */

    // Update is called once per frame
    void Update() 
    {
        
        GetComponent<Text>().text = time.ToString();
        time = Time.time;
        
       /*  if(time == tick){
            tick = time + timeInterval;
            Debug.Log("Timer");
            
        } */

     
    }
}
