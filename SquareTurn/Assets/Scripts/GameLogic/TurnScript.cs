using UnityEngine;
using System.Collections;

public class TurnScript : MonoBehaviour
{

    private Animation animationComponent;

    private int row;
    private int column;
    private GameObject managerObject;
    private GameObject userStatistics;

    //----------------INITIALIZATION-----------------------------------------
    void Start()
    {
        managerObject = GameObject.Find("gameManager");
        userStatistics = GameObject.Find("UserStatistics");
        animationComponent = this.GetComponent<Animation>();

    }

    //---------------FUNCTIONS-------------------------------
    public void StartSquareTurn()
    {

        bool gameWon = managerObject.GetComponent<GameLogic>().ReturnWinningState();

        if (!gameWon)
        { //only turn squares if game not won

            userStatistics.GetComponent<UserStatistics>().UpdateStatistic("Move++", 1); //Update the turn statistics (Script: UserStatistics.cs)
            managerObject.SendMessage("TurnOtherSquares", gameObject.name);
        }
    }

    public void TurnSquare(int squareState)
    {
        switch (squareState)
        {
            case 0:
                animationComponent.Play("reverseTurnAnimation");
                break;
            case 1:
                animationComponent.Play("turnAnimation");
                break;
        }
    }
}
