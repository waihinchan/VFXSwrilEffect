using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;
using System;
public class DebuggerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider SizeMaxer;
    public Slider SpeedMaxer;
    public Slider SizeMiner;
    public VisualEffect VFX;
    public GameObject thepannel;
    public Text CurrentWidth;
    public Text CurrentHeight;
    public InputField WidthResolution;
    public InputField HeightResolution;
    public Dropdown ScreenMode;
    void Awake(){
        WidthResolution.text = "3840";
        HeightResolution.text = "1200";
        ScreenMode.value = 1;
        Screen.SetResolution(Convert.ToInt32(WidthResolution.text),Convert.ToInt32(HeightResolution.text),FullScreenMode.ExclusiveFullScreen);
        SizeMaxer.onValueChanged.AddListener(delegate {ChangeMaxSize(); });
        SizeMiner.onValueChanged.AddListener(delegate {ChangeMinSize(); });
        SpeedMaxer.onValueChanged.AddListener(delegate {ChangeMaxSpeed(); });
        WidthResolution.onValueChanged.AddListener(delegate {setre(); });
        HeightResolution.onValueChanged.AddListener(delegate {setre(); });
        ScreenMode.onValueChanged.AddListener(delegate {setre(); });
        

    }

    void Start()
    {
        // Screen.SetResolution(3840, 1200, true);
        
    }

    // Update is called once per frame
    void Update()
    {   



        if(Input.GetKeyDown(KeyCode.Alpha0)){
            ScreenMode.value = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1)){
            ScreenMode.value = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            ScreenMode.value = 2;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
            ScreenMode.value = 3;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thepannel.SetActive(!thepannel.activeSelf);
        }
        CurrentWidth.text =  (Screen.width).ToString();
        CurrentHeight.text =  (Screen.height).ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thepannel.SetActive(!thepannel.activeSelf);
        }


        // in case of our mouse lost
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            HeightResolution.text = (Convert.ToInt32(HeightResolution.text) + 10).ToString();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            HeightResolution.text = (Convert.ToInt32(HeightResolution.text) - 10).ToString();
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            WidthResolution.text = (Convert.ToInt32(WidthResolution.text) + 10).ToString();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            WidthResolution.text = (Convert.ToInt32(WidthResolution.text) - 10).ToString();
        }
        // in case of our mouse lost
    }
    public void ChangeMaxSize()
    {
        
        VFX.SetFloat("_SizeMax",SizeMaxer.value);
    }
    public void ChangeMinSize()
    {
        
        VFX.SetFloat("_SizeMin",SizeMiner.value);
    }
    public void ChangeMaxSpeed()
    {
        
        VFX.SetFloat("_MaxSpeed",SpeedMaxer.value);
    }
    public void setre(){
        
        Screen.SetResolution(Convert.ToInt32(WidthResolution.text),Convert.ToInt32(HeightResolution.text),(FullScreenMode)ScreenMode.value);
        
        

    }

}
