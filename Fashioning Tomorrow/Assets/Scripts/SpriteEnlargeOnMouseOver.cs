using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteEnlargeOnMouseOver : MonoBehaviour
{
    private Vector3 originalScale;
    public float scaleFactor = 5f; // Adjust this value to control the scale factor

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseEnter()
    {
        Debug.Log("Mouse entered");
        GetComponent<Animator>().enabled = false;
        transform.localScale = originalScale * scaleFactor;
    }

    void OnMouseExit()
    {
        GetComponent<Animator>().enabled = true;
        transform.localScale = originalScale;
    }
}