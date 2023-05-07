using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    
    public float VitesseMarche = 100f;
    public float VitesseCourse = 200f;
    public float vitesseRotate = 50f;
    public int CoefRot = 180;
    public AudioClip pickaxeSound;
    public AudioClip axeSound;
    public GameObject highOnVisual;
    public GameObject highOffVisual;
    public AudioSource audio;
    float normal_speed;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        normal_speed = VitesseCourse;
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other);
        if(other.gameObject.CompareTag("FlaqueChocolat")){
            Debug.Log("I am triggered I am chocolat !");
            VitesseCourse *= 0.35f;
            Debug.Log(VitesseCourse);
        }
        if(other.gameObject.CompareTag("FlaqueCaramel") ) VitesseCourse *= 0.35f;
    }

    // Update is called once per frame
    void Update()
    {
       
    
       


        if(Input.GetAxis("Vertical")>0 && Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -vitesseRotate * Time.deltaTime, 0);
            highOnVisual.SetActive(true);
            
        }

         if(Input.GetAxis("Vertical")>0 && Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, vitesseRotate * Time.deltaTime, 0);
           highOnVisual.SetActive(true);
            
        }
        
        
        if(Input.GetAxis("Vertical")>0 && !Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseMarche * Time.deltaTime);
            highOnVisual.SetActive(true);
            
        }else{
            highOnVisual.SetActive(false);
        }
        
        if(Input.GetAxis("Vertical")>0 && Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseCourse * Time.deltaTime);
           highOnVisual.SetActive(true);
        }
       

        if(Input.GetAxis("Vertical")<0)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * VitesseMarche * Time.deltaTime);
           
        }

          if(Input.GetAxis("Vertical")<0 && Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(-Vector3.up * Input.GetAxis("Horizontal") * CoefRot * Time.deltaTime);
            highOnVisual.SetActive(true);

            
        }else{
            highOnVisual.SetActive(false);
        }
       
       
    }
    
}
