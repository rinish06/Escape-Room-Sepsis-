using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollision : MonoBehaviour
{
    public GameObject TV_Screen;

    void Start() {
        // TV tscript = TV_Screen.GetComponent<TV>();
        // tscript.BeginTutorial();
        // this.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            TV tscript = TV_Screen.GetComponent<TV>();
            tscript.BeginTutorial();
            this.gameObject.SetActive(false);
        }
    }


}
