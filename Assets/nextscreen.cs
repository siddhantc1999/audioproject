using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextscreen : MonoBehaviour
{
    public int thenextscreenid;
    screenmanager myscreenmanager;
    public screenid.screentype currentscreenid;
    public float currentalpha;
    //public int alphachangedscreen=-1;
    //create a
    public enum nextscreentype
    {

        login,
        register,
        exitpopup,
        maingameplay,
        pointrummy,
        mainmenu
    }
    public nextscreentype mynextscreentype;
    // Start is called before the first frame update
    void Start()
    {
        //alphachangedscreen = -1;
        myscreenmanager = FindObjectOfType<screenmanager>();
        currentscreenid = GetComponentInParent<screenid>().currentscreenid;
        currentalpha = GetComponentInParent<screenid>().currentalpha;
        thenextscreenid = (int)mynextscreentype;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void screenchange()
    {
        //Debug.Log(GetComponentInParent<screenid>().gameObject.name);
        myscreenmanager.alphareverse();
        //GetComponentInParent<screenid>().alphascreenchanged = -1;
        myscreenmanager.currentscreenturnoff((int)currentscreenid);
        myscreenmanager.nextscreenturnon(thenextscreenid);
        

    }
    public void screenchange(float currentalpha)
    {
        this.currentalpha = currentalpha;
        myscreenmanager.alphascreenchanged= myscreenmanager.currentscreenalphachange((int)currentscreenid);
        //GetComponentInParent<screenid>().alphascreenchanged = myscreenmanager.currentscreenalphachange((int)currentscreenid);
        
        myscreenmanager.nextscreenturnon(thenextscreenid);
    }


}
