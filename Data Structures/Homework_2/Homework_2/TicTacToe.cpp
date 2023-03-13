#include "TicTacToe.h"

char board [3][3];
	
TicTacToe::TicTacToe()
{
	//Precondition:
	//Postcondition: fills the array with blank spaces
	for(int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			board[i][j] = ' ';
		}
	}
}

void TicTacToe::setBoard( char value, int row, int col)
{
	//Precondition: Send a locaton to fill and a char to fill it with.
	//Postcondition: Fills the array position with the char.
	board[row][col] = value;
	return;
}

char TicTacToe::getBoard(int row, int col)
{
	//Precondition: Call for a position
	//Postcondition: Returns the charicter in position.
	return board[row][col];
}

void TicTacToe::ShowBoard()
{
	//Precondition:
	//Postcondition: Prints the board state.
	std::cout << "   1  2  3" << std::endl 
	<< "A " << board[0][0] << " | " << board[0][1] << " | " << board[0][2] << std::endl
	<< " -----------" << std::endl
	<< "B " << board[1][0] << " | " << board[1][1] << " | " << board[1][2] << std::endl
	<< " -----------" << std::endl
	<< "C " << board[2][0] << " | " << board[2][1] << " | " << board[2][2] << std::endl;
}

bool TicTacToe::Win()
{
	//Precondition:
	//Postcondition: sends true if one pice is in a row collum or diagnal on the board. Sends false if not.
	if ((board[0][0] == board[0][1]) && (board[0][2] == board[0][1]) && (board[0][0] == board[0][2]) && board[0][1] != ' '){
		return true;
	}else if ((board[1][0] == board[1][1]) && (board[1][2] == board[1][1]) && (board[1][0] == board[1][2]) && board[1][1] != ' '){
		return true;
	}else if ((board[2][0] == board[2][1]) && (board[2][2] == board[2][1]) && (board[2][0] == board[2][2]) && board[2][1] != ' '){
		return true;
	}else if ((board[0][0] == board[1][0]) && (board[2][0] == board[1][0]) && (board[0][0] == board[2][0]) && board[1][0] != ' '){
		return true;
	}else if ((board[0][1] == board[1][1]) && (board[2][1] == board[1][1]) && (board[0][1] == board[2][1]) && board[1][1] != ' '){
		return true;
	}else if ((board[0][2] == board[1][2]) && (board[2][2] == board[1][2]) && (board[0][2] == board[2][2]) && board[1][2] != ' '){
		return true;
	}else if ((board[0][0] == board[1][1]) && (board[2][2] == board[1][1]) && (board[0][0] == board[2][2]) && board[1][1] != ' '){
		return true;
	}else if ((board[0][2] == board[1][1]) && (board[2][0] == board[1][1]) && (board[0][2] == board[2][0]) && board[1][1] != ' '){
		return true;
	}else{
		return false;
	}
}

bool GoPlayer(char piece, TicTacToe& game)
{
	//Precondition: attempts to place a pice on the board.
	//Postcondition: returs true if the piece if the space is placed in an empty user specifyed possition.
	//otherwise it returns false.
	bool rowCheck = false;
	bool colCheck = false;
	char row = ' ';
	char column = ' ';
	int rowNumb = 4;
	int colNumb = 4;
	std::cout << piece << " Players turn.  Where would you like to place your X?" << std::endl;
	while(!rowCheck)
	{
		std::cout << "Give me a row letter first [ A B C or Z for auto play]" << std::endl;
		std::cin >> row;
		if(toupper(row) == 'A' || toupper(row) == 'B' ||toupper(row) == 'C' ||toupper(row) == 'Z')
		{
			if(toupper(row) == 'A')
			{
				rowNumb = 0;
				rowCheck = true;
			}else if(toupper(row) == 'B'){
				rowNumb = 1;
				rowCheck = true;
			}else if(toupper(row) == 'C'){
				rowNumb = 2;
				rowCheck = true;
			}else if (toupper(row) == 'Z'){
				rowNumb = std::rand()/((RAND_MAX + 1u)/3);
				rowCheck = true;
			}else{
			}
		}
	}

	while(!colCheck)
	{
		std::cout << "Give me a column number next[ 1 2 3 or Z for auto play]" << std::endl;
		std::cin >> column;
		if(column == '1' || column == '2' || column == '3' ||toupper(column) == 'Z')
		{
			if(column == '1')
			{
				colNumb = 0;
				colCheck = true;
			}else if(column == '2'){
				colNumb = 1;
				colCheck = true;
			}else if(column == '3'){
				colNumb = 2;
				colCheck = true;
			}else if (toupper(column) == 'Z'){
				colNumb = std::rand()/((RAND_MAX + 1u)/3);
				colCheck = true;
			}else{
			}
		}
	}

	if(game.getBoard(rowNumb, colNumb) == ' '){
		game.setBoard( piece, rowNumb, colNumb);
		return true;
	}else{
		std::cout << "You can't put something in " << rowNumb << colNumb << " because there is already something there" << std::endl;
		return false;
	}
}