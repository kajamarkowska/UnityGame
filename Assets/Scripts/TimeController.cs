using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 0f, 0f);
    }
}
