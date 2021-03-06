﻿// Exercise 8.22 Part B Solution: Knight1.cs
// Knight's Tour
using System;

public class Knight1
{
   static Random randomNumbers = new Random();

   static int[ , ] board; // gameboard

   // moves
   static int[] horizontal = { 2, 1, -1, -2, -2, -1, 1, 2 };
   static int[] vertical = { -1, -2, -2, -1, 1, 2, 2, 1 };

   // runs a tour
   public static void Main( string[] args )
   {
      int currentRow; // the row position on the chessboard
      int currentColumn; // the column position on the chessboard
      int moveNumber = 0; // the current move number

      board = new int[ 8, 8 ]; // gameboard

      int testRow; // row position of next possible move
      int testColumn; // column position of next possible move

      // randomize initial board position
      currentRow = randomNumbers.Next( 8 );
      currentColumn = randomNumbers.Next( 8 );

      board[ currentRow, currentColumn ] = ++moveNumber;
      bool done = false;

      // continue until knight can no longer move
      while ( !done )
      {
         bool goodMove = false;

         // check all possible moves until we find one that's legal
         for ( int moveType = 0; moveType < 8 && !goodMove; moveType++ )
         {
            testRow = currentRow + vertical[ moveType ];
            testColumn = currentColumn + horizontal[ moveType ];
            goodMove = ValidMove( testRow, testColumn );

            // test if new move is valid
            if ( goodMove )
            {
               currentRow = testRow;
               currentColumn = testColumn;
               board[ currentRow, currentColumn ] = ++moveNumber;
            } // end if
         } // end for

         // if no valid moves, knight can no longer move
         if ( !goodMove )
            done = true;
         // if 64 moves have been made, a full tour is complete
         else if ( moveNumber == 64 )
            done = true;
      } // end while

      Console.WriteLine( "The tour ended with {0} moves.", moveNumber );

      if ( moveNumber == 64 )
         Console.WriteLine( "This was a full tour!" );
      else
         Console.WriteLine( "This was not a full tour." );

      PrintTour();
   } // end Main

   // checks for valid move
   public static bool ValidMove( int row, int column )
   {
      // returns false if the move is off the chessboard, or if
      // the knight has already visited that position
      // NOTE: This test stops as soon as it becomes false
      return ( row >= 0 && row < 8 && column >= 0 && column < 8
         && board[ row, column ] == 0 );
   } // end method ValidMove

   // display Knight's tour path
   public static void PrintTour()
   {
      Console.Write( "\n  " );

      // display numbers for column
      for ( int k = 0; k < 8; k++ )
         Console.Write( "{0,3}", k );

      Console.WriteLine( "\n" );

      for ( int row = 0; row < board.GetLength( 0 ); row++ )
      {
         Console.Write( "{0,-2}", row );

         for ( int column = 0; column < board.GetLength( 1 ); column++ )
            Console.Write( "{0,3}", board[ row, column ] );

         Console.WriteLine();
      } // end for
   } // end method PrintTour
} // end class Knight1



/**************************************************************************
 * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
