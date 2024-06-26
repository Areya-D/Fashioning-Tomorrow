using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class SceneChangeonCustomer : MonoBehaviour
{
    void OnMouseDown(){
        Debug.Log("Hi guys :D");
        if (gameObject.name == "AfroAvatar") {
            SceneManager.LoadScene("AfroDressup");
        }
        else if (gameObject.name == "PonytailAvatar"){
            SceneManager.LoadScene("PonytTailDressup");
        }
        else {
            SceneManager.LoadScene("LocDressup");
            //dangerous code if we add more characters, might assume its LocDressup
        }
        
    }
}
//if customers are the same as on the first screen
