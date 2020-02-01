using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    public int playerOneHealth;
    public int playerTwoHealth;

    public Sprite playerOneFullHeart;
    public Sprite playerOneEmptyHeart;
    public Sprite playerTwoFullHeart;
    public Sprite playerTwoEmptyHeart;

    public GameObject[] playerOneHearts;
    public GameObject[] playerTwoHearts;

    public Image[] playerOneHeartsImage;
    public Image[] playerTwoHeartsImage;

    public GameObject WinnerPlayerOne;
    public GameObject WinnerPlayerTwo;

    // Update is called once per frame
    void Update()
    {
        if (playerOneHealth <= 0)
        {
            playerOne.SetActive(false);
            WinnerPlayerTwo.SetActive(true);
        }
        else if (playerTwoHealth <= 0)
        {
            playerTwo.SetActive(false);
            WinnerPlayerOne.SetActive(true);
        }
    }

    public void HurtPlayerOne()
    {
        playerOneHealth -= 1;
        for (int i = 0; i < playerOneHearts.Length; i++)
        {
            if (playerOneHealth > i)
            {
                playerOneHearts[i].SetActive(true);
            }
            else
            {
                playerOneHearts[i].SetActive(false);
            }
        }
    }

    public void HurtPlayerTwo()
    {
        playerTwoHealth -= 1;
        for (int i = 0; i < playerTwoHearts.Length; i++)
        {
            if (playerTwoHealth > i)
            {
                playerTwoHearts[i].SetActive(true);
            }
            else
            {
                playerTwoHearts[i].SetActive(false);
            }
        }
    }

}
