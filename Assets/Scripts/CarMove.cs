using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float speedGain = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    private int steerValue;

    private void Update()
    {
        speed += speedGain*Time.deltaTime;

        transform.Rotate(0f, steerValue*turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
