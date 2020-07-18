using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLargeTunnel : MonoBehaviour
{
    public bool triggered = false;

    private void OnTriggerEnter(Collider other) {
        triggered = true;
    }

    // Update is called once per frame
    void Update() {
        if (triggered) {
            print("Triggered..");
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 8f);
            triggered = false;
        }
    }
}
