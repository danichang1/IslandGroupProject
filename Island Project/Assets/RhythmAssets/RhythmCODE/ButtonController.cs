using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Material myMaterial;
    public Material notPressed;
    public Material pressed;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
