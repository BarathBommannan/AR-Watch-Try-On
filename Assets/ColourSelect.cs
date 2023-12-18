using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColourSelect : MonoBehaviour
{
    public Material Band1;
    public Material Band2;
    public Material Band3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColourSelect(){
        string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if(buttonname == "Black Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000",out mycolor);
            Band1.color=mycolor;
        }
        else if(buttonname == "Blue Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#103B90",out mycolor);
            Band1.color=mycolor;
        }
    }
    public void w2ColourSelect(){
        string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if(buttonname == "Black Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000",out mycolor);
            Band2.color=mycolor;
        }
        else if(buttonname == "Red Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#FF0000",out mycolor);
            Band2.color=mycolor;
        }
    }
    public void w3ColourSelect(){
        string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if(buttonname == "Black Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000",out mycolor);
            Band3.color=mycolor;
        }
        else if(buttonname == "White Button"){
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1",out mycolor);
            Band3.color=mycolor;
        }
    }

    
}
