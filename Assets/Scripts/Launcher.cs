using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint;
    public UIController uIController;

    public float rotationSpeed = 0.25f;
    public float launchSpeed = 5f;
    public int numBalls = 10;

    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        lastMousePosition = Input.mousePosition;

        if (uIController != null)
        {
            uIController.SetNumBalls(numBalls);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotation();
        UpdateSpawning();
    }

    private void UpdateRotation()
    {
        Vector3 mouseDelta = Input.mousePosition - lastMousePosition;

        if(mouseDelta.x != 0)
        {
            float rotationAmount = mouseDelta.x * rotationSpeed;
            transform.Rotate(0f, 0f, rotationAmount);
        }

        lastMousePosition = Input.mousePosition;
    }

    private void UpdateSpawning()
    {
        if(Input.GetMouseButtonDown(0) && numBalls > 0)
        {
            GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            Vector3 spawnVelocity = spawnPoint.transform.up * -1f * launchSpeed;
            spawnedPrefab.GetComponent<Rigidbody2D>().velocity = spawnVelocity;

            if(GetComponent<AudioSource>())
            {
                GetComponent<AudioSource>().Play();
            }

            numBalls--;

            if (uIController != null)
            {
                uIController.SetNumBalls(numBalls);
            }
        }
    }
}
