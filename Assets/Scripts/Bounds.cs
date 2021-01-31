using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour

    // Stop player movement if they move outside Z and X axis.
{
    public Camera MainCamera;
    private Vector3 screenBounds;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        objectWidth = transform.GetComponent<BoxCollider>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<BoxCollider>().bounds.extents.z; //extents = size of height / 2

        Debug.Log(objectWidth);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.y));
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.z = Mathf.Clamp(viewPos.z, screenBounds.z * -1 + objectHeight, screenBounds.z - objectHeight);
        transform.position = viewPos;
    }
}
