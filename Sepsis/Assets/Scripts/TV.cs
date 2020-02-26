using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class TV : MonoBehaviour
{
    public TextMeshPro temp;
    public GameObject tvScreen;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TutorialSteps());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TutorialSteps(){
        yield return new WaitForSeconds(5);
        tvScreen.GetComponent<TextMeshPro>().text = "First we are going to show you how to move around the room";
    }
}
