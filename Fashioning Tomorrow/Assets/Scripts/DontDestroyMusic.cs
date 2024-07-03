using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
   private void Awake(){

    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
    if (musicObj.Length > 1){
        Destroy(this.gameObject);
    }

    DontDestroyOnLoad(this.gameObject);

   }

   void Update(){
    if (Input.GetKey("escape")){
        Debug.Log("Goodbye");
        Application.Quit();
    }
   }
}
