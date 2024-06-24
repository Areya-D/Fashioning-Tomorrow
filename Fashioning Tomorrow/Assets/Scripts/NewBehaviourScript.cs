using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void onMouseDown() { //when mouse is pressed
        SceneManager.LoadScene("Dressup"); //change the scene from CustomerSelect to Dressup Screen
    }
}
