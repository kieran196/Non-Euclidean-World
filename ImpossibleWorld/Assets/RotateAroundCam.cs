using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundCam : MonoBehaviour
{

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 targetPostition = new Vector3(cam.transform.position.x,
        //                                0f,
        //                                cam.transform.position.z);
        Vector3 target = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        transform.LookAt(target);
        transform.localEulerAngles = new Vector3(-transform.localEulerAngles.x, transform.localEulerAngles.y + 180f, transform.localEulerAngles.z);
        //transform.RotateAround(cam.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
