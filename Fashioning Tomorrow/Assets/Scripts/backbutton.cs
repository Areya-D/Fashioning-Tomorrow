using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

//onlick go back to dressup screen
public class backbutton : MonoBehaviour
{

public void MoveToScene(){
    SceneManager.LoadScene("CustomerSelect");
}   
}
