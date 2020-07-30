using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureBehaviour : MonoBehaviour {
    private int count = 0;
    private float temperature = 27.2f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        count++;
        if (count == 60) {
            count = 0;

            if (temperature < 27.5f) {
                temperature += 0.1f;
            } else {
                temperature = 27.2f;
            }
            GetComponent<TextMeshPro>().text = temperature.ToString() + "°C Rainy";
        }
    }
}
