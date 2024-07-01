using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skirt : MonoBehaviour
{
    public Transform ClothingLocator;
    public Transform RuffleSet; 
    public Transform Bottoms;
    public Transform Shoes; 
    public Transform Top; 
    public Vector3 ClothesOrigin; 
    public ClothingManager clothingManager;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void playsound(){
        
    }
    //when mouse is clicked on clothing it moves to location on avatar 
    void OnMouseDown(){

        if(RuffleSet != null ){
            RuffleSet.position = ClothingLocator.position;

        }

        if(Bottoms != null){
            Bottoms.position = ClothingLocator.position;   
        }

        if(Top != null){
            Top.position = ClothingLocator.position; 
        }
        if(Shoes != null){
            Shoes.position = ClothingLocator.position; 
        }

    
    }
    public void ResetButton(){
        if(RuffleSet != null ){
            RuffleSet.position = ClothesOrigin;
        }

        if(Bottoms != null){
            Bottoms.position = ClothesOrigin;   
        }

        if(Top != null){
            Top.position = ClothesOrigin; 
        }
        if(Shoes != null){
            Shoes.position = ClothesOrigin; 
        }
    }

    //display on position of shirtLocator
}
