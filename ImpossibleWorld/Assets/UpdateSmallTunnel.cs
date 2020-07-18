using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSmallTunnel : MonoBehaviour
{
    public bool triggered = false;
    public GameObject disableRender;

    private void OnTriggerEnter(Collider other) {
        triggered = true;
    }

    public void updateCullingMask() {
        LayerMask someStuffCullingMask = ~(1 << 9 & 10);
        this.GetComponent<Camera>().cullingMask = someStuffCullingMask;
        disableRender.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (triggered) {
            //print("Triggered..");
            updateCullingMask();
            triggered = false;
        }
    }
}
