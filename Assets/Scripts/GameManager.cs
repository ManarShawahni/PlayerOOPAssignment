using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();


        player1.InitializePlayer("Manar", 50);
        player1.Heal(20);

        player2.InitializePlayer("Namaa", 70);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }
}
