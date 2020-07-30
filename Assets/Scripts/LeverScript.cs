using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeverScript : TouchableBehaviour {

    public GameObject lever;
    public TextMeshPro text;

    private bool isOn = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public override void onTapped() {
        isOn = !isOn;
        float angle = 0f;
        if (isOn) {
            angle = 38f;
            text.text = "Projecter is reserved.";
        } else {
            angle = -38f;
            text.text = "Projecter is available.";
        }

        Hashtable hash = iTween.Hash("x", angle, "isLocal", true);

        iTween.RotateTo(lever, hash);
    }

}