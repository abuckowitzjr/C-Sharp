// Exercise 8.22 Part D Solution: Knight3.cs
// Knight's Tour - heuristic version
using System;

public class Knight3
{
   static Random randomNumbers = new Random();

   static int[ , ] access = { { 2, 3, 4, 4, 4, 4, 3, 2 },
                       { 3, 4, 6, 6, 6, 6, 4, 3 },
                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                       { 4, 6, 8, 8, 8, 8, 6, 4 },
                       { 3, 4, 6, 6, 6, 6, 4, 3 },
                       { 2, 3, 4, 4, 4, 4, 3, 2 } };

   static int[ , ] board; // gameboard
   static int accessNumber; // the current access number   

   // moves
   static int[] horizontal = { 2, 1, -1, -2, -2, -1, 1, 2 };
   static int[] vertical = { -1, -2, -2, -1, 1, 2, 2, 1 };

   // create a board and attempt a tour
   public static void Main( string[] args )
   {
      int currentRow; // the row position on the chessboard
      int currentColumn; // the column position on the chessboard
      int moveNumber = 0; // the current move number

      int testRow; // row position of next possible move
      int testColumn; // column position of next possible move
      int minRow = -1; // row position of move with minimum access
      int minColumn = -1; // row position of move with minimum access

      board = new int[ 8, 8 ];

      // randomize initial board position
      currentRow = randomNumbers.Next( 8 );
      currentColumn = randomNumbers.Next( 8 );

      board[ currentRow, currentColumn ] = ++moveNumber;
      bool done = false;

      // continue touring until finished traversing
      while ( !done )
      {
         accessNumber = 99;

         // try all possible moves
         for ( int moveType = 0; moveType < board.GetLength( 0 );
            moveType++ )
         {
            // new position of hypothetical moves
            testRow = currentRow + vertical[ moveType ];
            testColumn = currentColumn + horizontal[ moveType ];

            if ( ValidMove( testRow, testColumn ) )
            {
               // obtain access number
               if ( access[ testRow, testColumn ] < accessNumber )
               {
                  // if this is the lowest access number thus far,
                  // then set this move to be our next move
                  accessNumber = access[ testRow, testColumn ];

                  minRow = testRow;
                  minColumn = testColumn;
               } // end if
               else if
                  ( access[ testRow, testColumn ] == accessNumber )
               {
                  // if the lowest access numbers are the same,
                  // look ahead to the next move to see which has the
                  // lower access number
                  int lowestTest = NextMove( testRow, testColumn );
                  int lowestMin = NextMove( minRow, minColumn );

                  if ( lowestTest <= lowestMin )
                  {
                     accessNumber = access[ testRow, testColumn ];

                     minRow = testRow;
                     minColumn = testColumn;
                  } // end if
               } // end else if

               // position access number tried
               --access[ testRow, testColumn ];
            } // end if
         } // end for

         // traversing done
         if ( accessNumber == 99 )
            done = true;
         else // make move
         {
            currentRow = minRow;
            currentColumn = minColumn;
            board[ currentRow, currentColumn ] = ++moveNumber;
         } // end else
      } // end while

      Console.WriteLine( "The tour ended with {0} moves.", moveNumber );

      if ( moveNumber == 64 )
         Console.WriteLine( " This was a full tour!" );
      else
         Console.WriteLine( " This was not a full tour." );

      PrintTour();
   } // end method Tour

   // checks for next move
   public static int NextMove( int row, int column )
   {
      int tempRow, tempColumn;
      int tempAccessNumber = accessNumber;
      int[ , ] tempAccess = new int[ 8, 8 ];

      for ( int i = 0; i < access.GetLength( 0 ); i++ )
         for ( int j = 0; j < access.GetLength( 1 ); j++ )
            tempAccess[ i, j ] = access[ i, j ];

      // try all possible moves
      for ( int moveType = 0; moveType < board.GetLength( 0 );
         moveType++ )
      {
         // new position of hypothetical moves
         tempRow = row + vertical[ moveType ];
         tempColumn = column + horizontal[ moveType ];

         if ( ValidMove( tempRow, tempColumn ) )
         {
            // obtain access number
            if ( access[ tempRow, tempColumn ] < tempAccessNumber )
               tempAccessNumber = tempAccess[ tempRow, tempColumn ];

            // position access number tried
            --tempAccess[ tempRow, tempColumn ];
         } // end if
      } // end for

      return tempAccessNumber;
   } // end method NextMove

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
} // end class Knight3


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
