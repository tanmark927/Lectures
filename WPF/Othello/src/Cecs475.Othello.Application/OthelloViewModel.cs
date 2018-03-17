using System;
using System.Collections.Generic;
using System.Linq;
using Cecs475.Othello.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Globalization;

namespace Cecs475.Othello.Application {
	public class OthelloSquare : INotifyPropertyChanged {
		private int mPlayer;
		public int Player {
			get { return mPlayer; }
			set {
				if (value != mPlayer) {
					mPlayer = value;
					OnPropertyChanged(nameof(Player));
				}
			}
		}

		public BoardPosition Position {
			get; set;
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}

	public class OthelloViewModel : INotifyPropertyChanged, IValueConverter {
		private OthelloBoard mBoard;
        public int CurrentPlayer { get { return mBoard.CurrentPlayer; } }
		private ObservableCollection<OthelloSquare> mSquares;

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string name) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public OthelloViewModel() {
			mBoard = new OthelloBoard();
			mSquares = new ObservableCollection<OthelloSquare>(
				BoardPosition.GetRectangularPositions(8, 8)
				.Select(p =>new OthelloSquare() {
					Position = p,
					Player = mBoard.GetPlayerAtPosition(p)
				})
			);

			PossibleMoves = new HashSet<BoardPosition>(mBoard.GetPossibleMoves().Select(m => m.Position));
		}


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int player = (int)value;
            if (player == 0)
            {
                return null;
            }
            return (player == 1) ? "Black" : "White";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string piece = (string)value;
            if (piece == null)
                return null;
            return (piece.Equals("Black")) ? 1 : 2;
        }

        public void ApplyMove(BoardPosition position) {
			var possMoves = mBoard.GetPossibleMoves() as IEnumerable<OthelloMove>;
			foreach (var move in possMoves) {
				if (move.Position.Equals(position)) {
					mBoard.ApplyMove(move);
					break;
				}
			}

			PossibleMoves = new HashSet<BoardPosition>(mBoard.GetPossibleMoves().Select(m => m.Position));
			var newSquares = BoardPosition.GetRectangularPositions(8, 8);
			int i = 0;
			foreach (var pos in newSquares) {
				mSquares[i].Player = mBoard.GetPlayerAtPosition(pos);
				i++;
			}
            OnPropertyChanged(nameof(CurrentPlayer));
			OnPropertyChanged(nameof(CurrentAdvantage));
		}

		public ObservableCollection<OthelloSquare> Squares {
			get { return mSquares; }
		}

		public HashSet<BoardPosition> PossibleMoves {
			get; private set;
		}

		public GameAdvantage CurrentAdvantage { get { return mBoard.CurrentAdvantage; } }

        public void UndoLastMove()
        {
            mBoard.UndoLastMove();

            PossibleMoves = new HashSet<BoardPosition>(mBoard.GetPossibleMoves().Select(m => m.Position));
            var newSquares = BoardPosition.GetRectangularPositions(8, 8);
            int i = 0;
            foreach (var pos in newSquares)
            {
                mSquares[i].Player = mBoard.GetPlayerAtPosition(pos);
                i++;
            }
            OnPropertyChanged(nameof(CurrentPlayer));
            OnPropertyChanged(nameof(CurrentAdvantage));
        }
	}
}