using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlanetBehavior : MonoBehaviour
{
    public float spinSpeed = 20f; 
    public string myFact = "fact"; 
    public TextMeshProUGUI infoText; 

    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }

    void OnMouseDown()
    {
        if (infoText != null)
        {
            infoText.text = myFact;
        }
    }
}
