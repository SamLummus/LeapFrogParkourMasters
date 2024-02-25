using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColliderCounter : MonoBehaviour
{
    public enum PlayerType { Player1, Player2 };
    public PlayerType playerType;

    CapsuleCollider capsuleCollider;
    [SerializeField] private TextMeshProUGUI player1PointUI, player2PointUI, winTextUI;

    int player1Points, player2Points = 0;

    private void Start() {
        player1PointUI.text = "Player 1 score: " + player1Points.ToString();
        player2PointUI.text = "Player 2 score: " + player2Points.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            IncreaseScore();
        }
    }

    private void IncreaseScore() {
        if (playerType == PlayerType.Player1) {
            player2Points++;
            player2PointUI.text = "Player 2 score: " + player2Points.ToString();

            if (player2Points > 3) {

                winTextUI.text = "Player 2 Wins!";
            }
        } else {
            player1Points++;
            player1PointUI.text = "Player 1 score: " + player1Points.ToString();

            if (player1Points > 3) {

                winTextUI.text = "Player 1 Wins!";
            }
        }
    }

}
