using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class screenmanager : MonoBehaviour
{
    public int current_id;
    public int next_id;
    public List<screenid> myscreenidlist;
    public Canvas currentcanvas;
    public Canvas nextcanvas;
    public int alphascreenchanged;
    private void Start()
    {
        myscreenidlist = FindObjectsOfType<screenid>().ToList();
    }
    
    public void currentscreenturnoff(int current_id)
    {
        this.current_id = current_id;


        

        currentcanvas=Canvasfind(current_id);
        currentcanvas.enabled = false;   
    }
    public void nextscreenturnon(int next_id)
    {
        
        this.next_id = next_id;

     //   currentcanvas = Canvasfind(current_id);
      //  currentcanvas.enabled = false;
        nextcanvas = Canvasfind(next_id);
        
        nextcanvas.GetComponent<CanvasGroup>().alpha = 1f;

        nextcanvas.enabled = true;
    }
    public int currentscreenalphachange(int current_id)
    {

        
        CanvasGroup colorcanvas = Canvasfind(current_id).gameObject.GetComponent<CanvasGroup>();
        float alpha= colorcanvas.alpha;
        colorcanvas.alpha = 0.4f;
        return current_id;
    }
    public void alphareverse()
    {
       
        if (alphascreenchanged >= 0)
        {
            //Debug.Log("here in alpha changed screennumber"+ alphascreenchanged);
            Canvas alphacanvas = Canvasfind(alphascreenchanged);
            float alpha = alphacanvas.GetComponent<CanvasGroup>().alpha;
            if (alphacanvas.enabled == true)
            {
                //Debug.Log("here " + alphacanvas.gameObject.name);
                alphacanvas.enabled = false;
                alpha = 1;
            }
            alphascreenchanged = -1;
        }
        







    }
    public Canvas Canvasfind(int id)
    {
        for (int i = 0; i <myscreenidlist.Count; i++)
        {
            int refscreenid =(int) myscreenidlist[i].currentscreenid;
            
            if (id == refscreenid)
            {
                
                return myscreenidlist[i].canvas;
            }
        }
        return null;
    }

//public void screensturnoff()
//{

//    for(int i=0;i< myscreenidlist.Count;i++)
//    {
//        if(myscreenidlist[i].GetComponent<Canvas>().enabled==true)
//        {
//            myscreenidlist[i].GetComponent<Canvas>().enabled = false;
//        }
//    }
//}
    
   

}
