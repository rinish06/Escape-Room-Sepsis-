using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
     
     public class PlayBeat: MonoBehaviour
     {
     
         public AudioSource HeartBeat;
     
         void OnTriggerEnter(Collider other)
         {
             gameObject.GetComponent<AudioSource> ().Play ();
         }
     }
 