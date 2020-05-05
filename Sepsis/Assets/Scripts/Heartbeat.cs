using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Heartbeat : MonoBehaviour
{
    public AudioSource audioData;
    public GameObject monitorText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Steth"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            monitorText.GetComponent<TextMeshPro>().text = "BP: 120/80\nTemp: 98F";
            print("sounding");
        }
    }
}
