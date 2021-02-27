using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class CoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mycam;
    public VisualEffect VFX;
    public GameObject debugobject;
    
    
    void Awake(){
        
        if(mycam == null){
            mycam = Camera.main;
        }
    }
    void Start()
    {
         
    }

    // Update is called once per frame
    float Remap (float value, float from1, float to1, float from2, float to2) {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
    void Update()
    {   
        
        if (Input.GetMouseButton(0))
        {
            VFX.SetBool("_Emit",true);
        }
        else{
            VFX.SetBool("_Emit",false);
        }
        RaycastHit hitt = new RaycastHit();
        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hitt);
        // Debug.Log(hitt.point);
        // debugobject.transform.position = hitt.point;
        VFX.SetVector3("_Core_position",new Vector3(hitt.point.x,hitt.point.y,0));
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        
    }

}
