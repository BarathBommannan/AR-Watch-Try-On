using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{

    public GameObject watchmodel1;
    public GameObject watchmodel2;
    public GameObject watchmodel3;

    public GameObject w1window;
    public GameObject w2window;
    public GameObject w3window;

    Animation w1windowanimation;
    Animation w2windowanimation;
    Animation w3windowanimation;

    // Start is called before the first frame update
    void Start()
    {
        w1windowanimation = w1window.GetComponent<Animation>();
        w2windowanimation = w2window.GetComponent<Animation>();
        w3windowanimation = w3window.GetComponent<Animation>();
    }
    public void WatchOneButtonClicked(){
        watchmodel1.SetActive(true);
        watchmodel2.SetActive(false);
        watchmodel3.SetActive(false);

        w1windowanimation["w1animation"].speed=1;
        w1windowanimation.Play();
    }
    public void WatchTwoButtonClicked(){
        watchmodel1.SetActive(false);
        watchmodel2.SetActive(true);
        watchmodel3.SetActive(false);

        w2windowanimation["w2animation"].speed=1;
        w2windowanimation.Play();
    }
    public void WatchThreeButtonClicked(){
        watchmodel1.SetActive(false);
        watchmodel2.SetActive(false);
        watchmodel3.SetActive(true);

        w3windowanimation["w3animation"].speed=1;
        w3windowanimation.Play();
    }
    public void CloseButtonClicked(){
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if(buttonname == "w1close"){
            w1windowanimation["w1animation"].speed=-1;
            w1windowanimation["w1animation"].time = w1windowanimation["w1animation"].length;
            w1windowanimation.Play();
        }
        else if(buttonname == "w2close"){
            w2windowanimation["w2animation"].speed=-1;
            w2windowanimation["w2animation"].time = w2windowanimation["w2animation"].length;
            w2windowanimation.Play();
        }
        else if(buttonname == "w3close"){
            w3windowanimation["w3animation"].speed=-1;
            w3windowanimation["w3animation"].time = w3windowanimation["w3animation"].length;
            w3windowanimation.Play();
        }
    }
  
}
