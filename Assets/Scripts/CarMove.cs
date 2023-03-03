using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float speedGain = 0.2f;

    private void Update()
    {
        speed += speedGain*Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
