using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    private int player1points = 0;
    private int player2points = 0;

    // Timer
    int Round = 1;

    private bool _p1IsFacingRight;
    //private bool _hasFlipped;

    // Start is called before the first frame update
    void Start()
    {
        _p1IsFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.transform.position.x < Player2.transform.position.x)
        {
            //Debug.Log("Player 1 is on the left");
            //Player1.gameObject.GetComponent<FighterStats>().facingright = true;
            //Player2.gameObject.GetComponent<FighterStats>().facingright = false;

            if (!_p1IsFacingRight)
            {
                Flip(Player1.transform);
                Flip(Player2.transform);
                _p1IsFacingRight = true;
            }
        }
        else
        {
            //Player1.gameObject.GetComponent<FighterStats>().facingright = false;
            //Player2.gameObject.GetComponent<FighterStats>().facingright = true;

            if (_p1IsFacingRight)
            {
                Flip(Player2.transform);
                Flip(Player1.transform);
                _p1IsFacingRight = false;
            }
        }

        //if (Player1.GetComponent(FighterStats.health =< 0) || (Player2.GetComponent(FighterStats.health =< 0))
        //{
        //}

        if (Player1.GetComponent<FighterStats>().health <= 0 || Player2.GetComponent<FighterStats>().health <= 0)
        {
            //TODO DO stuff
            if (Player1.GetComponent<FighterStats>().health < (Player1.GetComponent<FighterStats>().health))
            //If Player 1 has less health (died first? lol) than player 2
            {
                player1points = player1points++;
            }
            else
                player2points = player1points++; 
            if (Round != 3)
            // if it's already Round 3 we don't want to go to Round 4
            {
                Round = Round++;
            }

        }
    }

    void Flip(Transform player)
    {
        player.localScale = new Vector3(-player.localScale.x, player.localScale.y, 1);
    }
}
