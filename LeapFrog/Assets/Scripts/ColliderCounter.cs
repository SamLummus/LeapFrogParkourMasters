using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColliderCounter : MonoBehaviour
{
    CapsuleCollider capsuleCollider;
    [SerializeField] private TextMeshProUGUI playerPointUI;
    int points = 0;
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        gameObject.tag = "Player1";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player2") {

            Debug.Log("Triggered by Player 2");
        }
    }
    void OnTriggerExit(Collider other) {

        playerPointUI.text = "Player 1: " + points++;
    }
}
