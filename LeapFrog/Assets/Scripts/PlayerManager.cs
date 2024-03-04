using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}

	[SerializeField] private TextMeshProUGUI player1PointUI, player2PointUI, winTextUI;

    int player1Points, player2Points = 0;

	public void Startup() {
		Debug.Log("Player manager starting...");

		player1PointUI.text = "Player 1 score: " + player1Points.ToString();
        player2PointUI.text = "Player 2 score: " + player2Points.ToString();

		// any long-running startup tasks go here, and set status to 'Initializing' until those tasks are complete
		status = ManagerStatus.Started;
	}

	public void IncreaseScore (int playerType) {
        
		if (playerType == 1) {

            player2Points++;
            player2PointUI.text = "Player 2 score: " + player2Points.ToString();

            if (player2Points > 3) {

                winTextUI.text = "Player 2 Wins!";
            }
        } else if (playerType == 2) {

            player1Points++;
            player1PointUI.text = "Player 1 score: " + player1Points.ToString();

            if (player1Points > 3) {

                winTextUI.text = "Player 1 Wins!";
            }
        }
    }
}
