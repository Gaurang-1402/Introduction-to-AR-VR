using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gaze : MonoBehaviour
{
    private Vector3 originalPosition;
    private bool isGazedUpon = false;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // For VR, use the headset's forward direction
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                if (!isGazedUpon)
                {
                    OnGazeEnter();
                    isGazedUpon = true;
                }
            }
            else
            {
                if (isGazedUpon)
                {
                    OnGazeExit();
                    isGazedUpon = false;
                }
            }
        }
    }

    void OnGazeEnter()
    {
        // Levitate the bookcase
        transform.position = originalPosition + new Vector3(0, 0.5f, 0);
    }

    void OnGazeExit()
    {
        // Return the bookcase to its original position
        transform.position = originalPosition;
    }
}
