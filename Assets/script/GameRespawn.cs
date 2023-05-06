using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameRespawn : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;
    public float spawnValue;
    float time;
    public float timeInterval = 10f;
    float tick;

    void Awake(){
        time = (int)Time.timeSinceLevelLoad;
        tick = timeInterval;
    }

    // Start is called before the first frame update
    void Update() {
        
        time = (int)Time.timeSinceLevelLoad;
        
        if(time == tick){
            tick = time + timeInterval;
            Debug.Log("Timer");
            spawn.position = transform.position;
        }

        if(player.transform.position.y < -spawnValue){
            RespawnPoint();
        }

    }

    void RespawnPoint()
    {
        transform.position = spawn.position;
    }
    
}
