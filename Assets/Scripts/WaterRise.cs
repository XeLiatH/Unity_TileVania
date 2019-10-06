using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{
    [Tooltip("Game units per second")]
    [SerializeField] float riseSpeed = 0.2f;

    void Update()
    {
        transform.Translate(new Vector2(0f, riseSpeed * Time.deltaTime));
    }
}
