using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropbox_delete : MonoBehaviour
{
  void OnTriggerEnter(Collider BookCollider){
      if(BookCollider.tag == "Book"){
           Destroy(BookCollider.gameObject);
      }
 }
}
