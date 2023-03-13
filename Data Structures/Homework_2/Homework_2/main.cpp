#include <stdio.h>
#include <iostream>
#include <TicTacToe.h>

// Milo Wilson
// Homework 2
// Data Structurs SECT: 06

int main()
{
    TicTacToe Game1;
    
    char Turn='X';
    bool SuccessfulTurn=false;

    bool GameOver=false;
    while(GameOver==false)
    {
        Game1.ShowBoard();
        SuccessfulTurn=GoPlayer(Turn,Game1);
        if(SuccessfulTurn)
        {
            GameOver=Game1.Win();
            if(GameOver)
            { 
                std::cout<<"Final Board:"<<std::endl;
                Game1.ShowBoard();
            }
            
            if(Turn=='X')
            { Turn='O'; }
            else
            { Turn='X'; }
        }
    }
}