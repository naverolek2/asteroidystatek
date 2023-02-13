using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_Script : MonoBehaviour
{
    public float worldWidth;
    public float worldHeight;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        worldHeight = 2.0f * Camera.main.transform.position.y 
            * Mathf.Tan(Camera.main.fieldOfView * 0.5f * Mathf.Deg2Rad);
        worldWidth = worldHeight * mainCamera.aspect;

        //Debug.Log($"Wielkoœæ pola gry: {worldWidth} x {worldHeight} ");
    }
}
