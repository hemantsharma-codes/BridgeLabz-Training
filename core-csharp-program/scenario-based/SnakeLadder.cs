using System;
class SnakeLadder{
	static Random random = new Random();
	static int RollDice(){
		return random.Next(1,7);
	}
	static void ApplySnakeOrLadder(int[] board,int[] score,int turn){
		if(board[score[turn]] != 0){
			score[turn] = board[score[turn]];
		}

	}
	static void MovePlayer(int[] score,int point,int turn){
		score[turn] += point;
	}
	static bool CheckWin(int[] score,int turn,int point){
		if(score[turn] > 100){
			score[turn] -= point;
			return falsE;
		}
		return score[turn] == 100;
	}
	static void Main(String[] args){

		// take input for number of player
		Console.WriteLine("Enter the number of player :");
		int player = int.Parse(Console.ReadLine());

		// creating an array to store the players point
		int[] score = new int[player];

		// take an input of array to create board of 100 cells
		int[] board = new int[101];

		// assigning 0 for safe place
		for(int i=0;i<=100;i++){
			board[i] = 0;
		}

		int numberOfSnake = 6;
		int numberOfLadder = 6;

		// assign snake's bite places
		for(int i=1;i<=numberOfSnake;i++){
			 int randomIdx = random.Next(20,100);
			 if(board[randomIdx] == 0){
				 int snakeBite = random.Next(1,randomIdx);
				 board[randomIdx] = snakeBite;
			 }
	        }

		// assing ladder's places
		for(int i=1;i<=numberOfLadder;i++){
			int randomIdx = random.Next(1,80);
			if(board[randomIdx] == 0){
				int ladderPoint = random.Next(randomIdx+1,100);
				board[randomIdx] = ladderPoint;
			}
		}

		int idx = 0;
		while(true){
			Console.WriteLine("Turn of player :"+(idx+1));
			// roll to dice
			int dicePoint = RollDice();
			Console.WriteLine("Dice : "+dicePoint);

			// Move Player
			MovePlayer(score,dicePoint,idx);

			// check win
			if(CheckWin(score,idx,dicePoint) == true){
			           Console.WriteLine("Player "+(idx+1)+" is the winner.");
				   break;
		        }
			if(score[idx] <= 100){
				ApplySnakeOrLadder(board,score,idx);
			}

			Console.WriteLine("Positio: "+score[idx]);
			idx = (idx+1)%player;
		}
	}
}
			         
