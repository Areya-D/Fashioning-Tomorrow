using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skirt : MonoBehaviour
{
    //public Transform Square;
    public Transform SkirtLocator;
    public Transform RuffleSet; 
    public Transform TopLocator; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //when thing clicked
    void OnMouseDown(){
        RuffleSet.position = TopLocator.position; 
        //Square.position = SkirtLocater.position;
    }

    //display on position of shirtLocator
}
