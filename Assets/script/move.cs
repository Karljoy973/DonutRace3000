using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    
    public float VitesseMarche = 10f;
    public float VitesseCourse = 16f;
    public float vitesseRotate = 60f;
    public int CoefRot = 180;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       float pitch = 1f;
        GetComponent<AudioSource>().pitch = pitch;


        if(Input.GetAxis("Vertical")>0 && Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -vitesseRotate * Time.deltaTime, 0);
            while(pitch < 10f){
                pitch += 1f;
            }
            
        }

         if(Input.GetAxis("Vertical")>0 && Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, vitesseRotate * Time.deltaTime, 0);
            while(pitch < 10f){
                pitch += 1f;
            }
            
        }
        
        
        if(Input.GetAxis("Vertical")>0 && !Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseMarche * Time.deltaTime);
            while(pitch < 20f){
                pitch += 1f;
            }
        }
        
        if(Input.GetAxis("Vertical")>0 && Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseCourse * Time.deltaTime);
            while(pitch < 30f){
                pitch += 1f;
            }
        }
       

        if(Input.GetAxis("Vertical")<0)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseMarche * Time.deltaTime);
            while(pitch < 5f){
                pitch += 1f;
            }
        }

          if(Input.GetAxis("Vertical")<0 && Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(-Vector3.up * Input.GetAxis("Horizontal") * CoefRot * Time.deltaTime);
             while(pitch < 5f){
                pitch += 1f;
            }

            
        }
       
       
    }
    
}
