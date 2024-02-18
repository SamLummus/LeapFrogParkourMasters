using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColliderCounter2 : MonoBehaviour
{
    CapsuleCollider capsuleCollider;
    [SerializeField] private TextMeshProUGUI playerPointUI;
    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        gameObject.tag = "Player2";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player1") {

            Debug.Log("Triggered by Player 1");
        }
    }
    void OnTriggerExit(Collider other) {

        if (other.gameObject.tag == "Player1") {

            playerPointUI.text = "Player 2: " + points++;
        }
        
    }
}
