using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    private const float STEP = 1.1f;

    public float maxTop { get; private set; }
    public float maxBottom { get; private set; }
    public float maxLeft { get; private set; }
    public float maxRight { get; private set; }

    private GameObject _rubiksCube;

    // Start is called before the first frame update
    void Start()
    {
        _rubiksCube = GameObject.Find("AllCubes");


        var posMarker = gameObject.transform.position;
        var posRubiksCube = _rubiksCube.transform.position;

        gameObject.transform.position = new Vector3
        {
            x = posRubiksCube.x,
            y = posRubiksCube.y + 2.0f * STEP,
            z = posMarker.z
        };

        maxTop = posRubiksCube.y + 2.0f * STEP;
        maxBottom = posRubiksCube.y - STEP;
        maxLeft = posRubiksCube.x - 2.0f * STEP;
        maxRight = posRubiksCube.x + STEP;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: marker moving right/up
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            var posMarker = gameObject.transform.position;
            var posRubiksCube = _rubiksCube.transform.position;
            Debug.Log($"Rubik: {posRubiksCube.x}/{posRubiksCube.y}/{posRubiksCube.z}");
            Debug.Log($"Marker: {posMarker.x}/{posMarker.y}/{posMarker.z}");

            var pos = gameObject.transform.position;
            pos = new Vector3
            {
                x = Mathf.Max(pos.x - STEP, maxLeft),
                y = pos.y,
                z = pos.z
            };

            if (Math.Abs(pos.x - maxLeft) < 0.01f)
            {
                pos = new Vector3
                {
                    x = pos.x,
                    y = Mathf.Max(pos.y - STEP, maxBottom),
                    z = pos.z
                };
            }

            gameObject.transform.position = pos;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {


            var pos = this.gameObject.transform.position;

            pos = new Vector3
            {
                x = pos.x,
                y = Mathf.Min(pos.y + STEP, maxTop),
                z = pos.z
            };

            if (Math.Abs(pos.y - maxTop) < 0.01f)
            {
                pos = new Vector3
                {
                    x = Mathf.Min(pos.x + STEP, maxRight),
                    y = pos.y,
                    z = pos.z
                };
            }
            gameObject.transform.position = pos;
        }
    }
}
