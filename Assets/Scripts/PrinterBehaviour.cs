using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterBehaviour : MonoBehaviour {

    private bool isAnimating = false;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void toggleAnimation() {
        isAnimating = !isAnimating;
        if (isAnimating) {
            Hashtable hash = iTween.Hash("y", 2.0f, "isLocal", true, "loopType", "pingPong", "time", 0.2f);
            iTween.MoveTo(gameObject, hash);
        } else {
            Hashtable hash = iTween.Hash("y", 1.8f, "isLocal", true, "time", 0.2f);
            iTween.MoveFrom(gameObject, hash);
        }
    }
}
