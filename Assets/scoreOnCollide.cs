using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreOnCollide : MonoBehaviour
{
    public Text scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreasePerSecond = 1f; // Changed "Increased" to "Increase" for clarity

    void FixedUpdate()
    {
        // Update score based on time elapsed and point increase per second
        scoreValue += pointIncreasePerSecond * Time.fixedDeltaTime;

        // Display the score as an integer in the Text UI element
        scoreValueText.text = ((int)scoreValue).ToString();
    }
}
