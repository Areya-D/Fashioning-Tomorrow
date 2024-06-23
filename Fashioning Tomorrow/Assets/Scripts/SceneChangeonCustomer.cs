using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class SceneChangeonCustomer : MonoBehaviour
{
    void OnMouseDown(){
        Debug.Log("Hi guys :D");
        SceneManager.LoadScene("Dressup");
    }
}
//if customers are the same as on the first screen
