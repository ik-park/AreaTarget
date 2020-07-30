using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour {

    public GameObject target;

    private bool isHidden = true;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.LookAt(target.transform);
        transform.Rotate(new Vector3(90f, 0, 0));
    }

    public void toggleHidden() {
        isHidden = !isHidden;
        if (isHidden) {
            iTween.ScaleTo(gameObject, Vector3.zero, 0.2f);
        } else {
            iTween.ScaleTo(gameObject, new Vector3(0.1f, 0.1f, 0.1f), 0.2f);
        }
    }
}
