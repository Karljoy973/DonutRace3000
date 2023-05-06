using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExemple : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsVisibleInCamera()
    {
        Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        if (Camera.main.WorldToScreenPoint(this.gameObject.transform.position).x > Screen.width ||
                       Camera.main.WorldToScreenPoint(this.gameObject.transform.position).x < 0 ||
                                  Camera.main.WorldToScreenPoint(this.gameObject.transform.position).y > Screen.height ||
                                             Camera.main.WorldToScreenPoint(this.gameObject.transform.position).y < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
