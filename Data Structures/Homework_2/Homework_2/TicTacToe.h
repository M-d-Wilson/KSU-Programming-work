#ifndef TICTACTOE_HPP
#define TICTACTOE_HPP
#include <iostream>

class TicTacToe
{
public:
	char board [3][3];
	TicTacToe();
	void ShowBoard();
	bool Win();
	void setBoard( char value, int col, int row);
	char getBoard(int col, int row);
};

 bool GoPlayer(char, TicTacToe&);

#endif // TICTACTOE_HPP
