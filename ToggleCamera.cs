using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleCamera : MonoBehaviour
{

    public GameObject IsoCam;
    public GameObject FirstCam;
    private bool DefaultCam = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            DefaultCam = !DefaultCam;
            StartCoroutine(CameraChange());
        }
    }

    IEnumerator CameraChange()
    {
        yield return new WaitForSeconds(0.01f);
        IsoCam.SetActive(DefaultCam);
        FirstCam.SetActive(!DefaultCam);
    }
}
