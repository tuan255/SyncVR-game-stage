using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float cameraThreshold;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y + cameraThreshold, transform.position.z);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y + cameraThreshold, transform.position.z);
    }
}
