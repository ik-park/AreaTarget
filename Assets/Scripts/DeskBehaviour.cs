using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeskBehaviour : TouchableBehaviour {

    public TextMeshPro text;

    public Material available;
    public Material reserved;

    public bool isReserved;

    // Start is called before the first frame update
    void Start() {
        if (isReserved) {
            text.text = "Reserved";
            GetComponent<Renderer>().material = reserved;
        } else {
            text.text = "Available";
            GetComponent<Renderer>().material = available;
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public override void onTapped() {
        toggleReserved();
    }

    private void toggleReserved() {
        isReserved = !isReserved;

        if (isReserved) {
            text.text = "Reserved";
            GetComponent<Renderer>().material = reserved;
        } else {
            text.text = "Available";
            GetComponent<Renderer>().material = available;
        }
    }
}
