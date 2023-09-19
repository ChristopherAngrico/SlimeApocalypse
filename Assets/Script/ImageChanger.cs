using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public ScrollingText CurrentDisplayText;
    public Image image1;
    public Image image2;
    public Image image3;

    private void Start(){
            image1.enabled = true;
            image2.enabled = false;
            image3.enabled = false;
    }

    private void Update(){
        if(CurrentDisplayText.currentDisplayText >= 3 && CurrentDisplayText.currentDisplayText<6){
            image1.enabled = false;
            image2.enabled = true;
            image3.enabled = false;
        }else if(CurrentDisplayText.currentDisplayText >= 6 && CurrentDisplayText.currentDisplayText<10){
            image1.enabled = false;
            image2.enabled = false;
            image3.enabled = true;
        }else if(CurrentDisplayText.currentDisplayText >=10){
            SceneManager.LoadScene(2);
        }
    }
}
