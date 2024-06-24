using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skirt : MonoBehaviour
{
    public Transform SkirtLocator;
    public Transform TopLocator; 
    public Transform RuffleSet; 
    public Transform Bottoms;
    public Transform Top; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //when mouse is clicked on clothing it moves to location on avatar 
    void OnMouseDown(){
        if(RuffleSet != null ){
            RuffleSet.position = TopLocator.position;
        }
        
        if(Bottoms != null){
          Bottoms.position = SkirtLocator.position;   
        }

        if(Top != null){
        Top.position = TopLocator.position; 
        }
    }

    //display on position of shirtLocator
}
