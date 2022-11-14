using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HirschRubiksCube : MonoBehaviour
{
    private GameObject _marker;
    private float _angle = 0.0f;
    private float _angleU = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _marker = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        // check if key "rotate-left" is pressed and there is no rotation left to animate
        if (Input.GetKeyUp(KeyCode.A) && _angle == 0.0f)
        {
            _angle = 90.0f;
        }

        // check if key "rotate-left" is pressed and there is no rotation left to animate
        if (Input.GetKeyUp(KeyCode.D) && _angle == 0.0f)
        {
            _angle = -90.0f;
        }

        if (Input.GetKeyUp(KeyCode.S) && _angle == 0.0f)
        {
            _angleU = 90.0f;
        }

        if (Input.GetKeyUp(KeyCode.W) && _angle == 0.0f)
        {
            _angleU = -90.0f;
        }

        if (_angleU > 0.0f)
        {
            var markerScript = _marker.GetComponent<HirschMarker>();

            // and the marker is on the left side of the rubiks cube
            if (Math.Abs(_marker.transform.position.y - markerScript.maxTop) < 0.1f)
            {
                // calculate a segment of 90 degrees in consideration of current fps-rate
                var angleToRotate = Mathf.Min(Time.deltaTime * 100.0f, _angleU);

                // and reduce the initial angle by the calculated segment
                _angleU -= angleToRotate;

                // foreach child
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    var child = gameObject.transform.GetChild(i);

                    // check if its on the same y-coordinate (line)
                    if (Math.Abs(child.transform.position.x - _marker.transform.position.x) < 0.01f)
                    {
                        Debug.Log($"angle: {_angleU}, angleToRotate:{angleToRotate}");

                        // and rotate around the axis with the rubiks center as origin and an up-vector defining the axis
                        child.RotateAround(transform.position, Vector3.right, angleToRotate);
                    }
                }
            }
        }


        if (_angleU < 0.0f)
        {
            var markerScript = _marker.GetComponent<HirschMarker>();

            // and the marker is on the left side of the rubiks cube
            if (Math.Abs(_marker.transform.position.y - markerScript.maxTop) < 0.1f)
            {
                // calculate a segment of 90 degrees in consideration of current fps-rate
                var angleToRotate = Mathf.Max(Time.deltaTime * -100.0f, _angleU);

                // and reduce the initial angle by the calculated segment
                _angleU -= angleToRotate;

                // foreach child
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    var child = gameObject.transform.GetChild(i);

                    // check if its on the same y-coordinate (line)
                    if (Math.Abs(child.transform.position.x - _marker.transform.position.x) < 0.01f)
                    {
                        Debug.Log($"angle: {_angleU}, angleToRotate:{angleToRotate}");

                        // and rotate around the axis with the rubiks center as origin and an up-vector defining the axis
                        child.RotateAround(transform.position, Vector3.right, angleToRotate);
                    }
                }
            }
        }


        // if there is something left to rotate
        if (_angle > 0.0f)
        {
            var markerScript = _marker.GetComponent<HirschMarker>();

            // and the marker is on the left side of the rubiks cube
            if (Math.Abs(_marker.transform.position.x - markerScript.maxLeft) < 0.01f)
            {
                // calculate a segment of 90 degrees in consideration of current fps-rate
                var angleToRotate = Mathf.Min(Time.deltaTime * 100.0f, _angle);

                // and reduce the initial angle by the calculated segment
                _angle -= angleToRotate;

                // foreach child
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    var child = gameObject.transform.GetChild(i);

                    // check if its on the same y-coordinate (line)
                    if (Math.Abs(child.transform.position.y - _marker.transform.position.y) < 0.01f)
                    {
                        Debug.Log($"angle: {_angle}, angleToRotate:{angleToRotate}");

                        // and rotate around the axis with the rubiks center as origin and an up-vector defining the axis
                        child.RotateAround(transform.position, Vector3.up, angleToRotate);
                    }
                }
            }
        }

        // if there is something right to rotate
        if (_angle < 0.0f)
        {
            var markerScript = _marker.GetComponent<HirschMarker>();

            // and the marker is on the left side of the rubiks cube
            if (Math.Abs(_marker.transform.position.x - markerScript.maxLeft) < 0.01f)
            {
                // calculate a segment of 90 degrees in consideration of current fps-rate
                var angleToRotate = Mathf.Max(Time.deltaTime * -100.0f, _angle);

                // and reduce the initial angle by the calculated segment
                _angle -= angleToRotate;

                // foreach child
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    var child = gameObject.transform.GetChild(i);

                    // check if its on the same y-coordinate (line)
                    if (Math.Abs(child.transform.position.y - _marker.transform.position.y) < 0.01f)
                    {
                        Debug.Log($"angle: {_angle}, angleToRotate:{angleToRotate}");

                        // and rotate around the axis with the rubiks center as origin and an up-vector defining the axis
                        child.RotateAround(transform.position, Vector3.up, angleToRotate);
                    }
                }
            }
        }
    }
}