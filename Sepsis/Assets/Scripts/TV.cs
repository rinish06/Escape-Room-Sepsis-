using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class TV : MonoBehaviour
{
    public GameObject monitorScreen;
    public GameObject tvScreen;
    public GameObject ball;
    private int TVTextIndex = 0;
    private List<string> TVTexts = new List<string>() {"Welcome to Sepsis VR", "First we are going to show you how to move around the room", "Press and hold the trackpad with your thumb", "This allows you to teleport around the room!"
    , "Today we are going to learn how to detect sepsis in a patient", "Your first task is to obtain the patients information"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextText(){
        TVTextIndex++;
        tvScreen.GetComponent<TextMeshPro>().text = TVTexts[TVTextIndex];
    }

    public void BackText(){
        if(TVTextIndex==0){
            TVTextIndex++;
        }
        TVTextIndex--;
        tvScreen.GetComponent<TextMeshPro>().text = TVTexts[TVTextIndex];
    }

    public void BeginTutorial(){
        Destroy(ball);
        StartCoroutine(TutorialSteps());
    }

    IEnumerator TutorialSteps(){
        tvScreen.GetComponent<TextMeshPro>().text = "Welcome to Sepsis VR";
        yield return new WaitForSeconds(5);
        tvScreen.GetComponent<TextMeshPro>().text = "First we are going to show you how to move around the room";
        yield return new WaitForSeconds(5);
        tvScreen.GetComponent<TextMeshPro>().text = "Press and hold the trackpad with your thumb";
        yield return new WaitForSeconds(5);
        tvScreen.GetComponent<TextMeshPro>().text = "This allows you to teleport around the room!";
        yield return new WaitForSeconds(10);
        tvScreen.GetComponent<TextMeshPro>().text = "Today we are going to learn how to detect sepsis in a patient";
        yield return new WaitForSeconds(6);
        tvScreen.GetComponent<TextMeshPro>().text = "Your first task is to obtain the patients information";
        yield return new WaitForSeconds(6);

    }
}
