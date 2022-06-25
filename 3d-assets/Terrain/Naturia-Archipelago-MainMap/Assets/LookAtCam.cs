using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    private Transform mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCamera);
    }
}
