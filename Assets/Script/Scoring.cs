using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scoring : MonoBehaviour
{
    public GameObject[] scoreText;
    public AudioSource audio;

    private float x;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("TongOrganik"))
        {
            if (gameObject.CompareTag("Organik"))
            {
                Debug.Log("Berhasil");
            }
        }
    }
}
