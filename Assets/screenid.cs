using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenid : MonoBehaviour
{
    public enum screentype {
        login,
        register,
        exitpopup,
        maingameplay,
        pointrummy,
        mainmenu
        
    }
    public screentype currentscreenid;
    public float currentalpha;
    [HideInInspector]
   public Canvas canvas;
    [HideInInspector]
    public CanvasGroup mycanvasgroup;
    public int alphascreenchanged;
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        alphascreenchanged = -1;
        currentalpha = GetComponent<CanvasGroup>().alpha;
        canvas = GetComponent<Canvas> ();
        mycanvasgroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
