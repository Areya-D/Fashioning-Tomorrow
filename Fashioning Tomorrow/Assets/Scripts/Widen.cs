using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Widen : MonoBehaviour
{

    void OnMouseOver()
    {
        // Widen the object by 0.1
        transform.localScale += new Vector3(0.1F, 0, 0);
    }
}