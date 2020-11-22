using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        private Stack<playInfo> playTimeLine;
        private ToolStripMenuItem undoMenu;
        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add {
                playerMarked += value;
            }
            remove {
                playerMarked += value;
            }
        }

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<playInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
        public ToolStripMenuItem UndoMenu { get => undoMenu; set => undoMenu = value; }



        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox playerMark, ToolStripMenuItem undoMenu)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;
            this.UndoMenu = undoMenu;
            this.Player = new List<Player> {
                    new Player("P1",Image.FromFile(Application.StartupPath+"\\X.jpg")),
                    new Player("P2",Image.FromFile(Application.StartupPath+"\\O.jpg"))
                };
            PlayTimeLine = new Stack<playInfo>();
        }
        
        #endregion

        #region Methods 
        public void drawChessBoard()
        {
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            Matrix = new List<List<Button>>();
            ChessBoard.Enabled = true;
            UndoMenu.Enabled = true;
            ChessBoard.Controls.Clear();
            CurrentPlayer = 0;
            ChangePlayer();

            for (int i = 0; i < Cons.Size_Chess_Board_Height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.Size_Chess_Board_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Width,
                        Height = Cons.Chess_height,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()

                    };
                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    btn.Click += Btn_Click;
                    oldBtn = btn;

                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.Chess_height);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }
        public bool undoGame()
        {
            if (PlayTimeLine.Count <= 0)
            {
                return false;
            }

            bool undo1 = UnDo1Step();
            //bool undo2 = UnDo1Step();

            playInfo oldPoint = PlayTimeLine.Peek();
            CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            return undo1 /*&& undo2*/;

        }
        public bool UnDo1Step()
        {
            if (PlayTimeLine.Count <= 0)
            {
                return false;
            }
            playInfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;
            if (PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
                
            }

            ChangePlayer();
            return true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new playInfo(GetChessPoint(btn),CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
           
            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));

            if (isEndGame(btn))
            {
                endGame();
            }
        }
        public void OtherPlayerMarked(Point point)
        {
            Button btn = Matrix[point.Y][point.X];
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new playInfo(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
           
            ChangePlayer();
            
            if (isEndGame(btn))
            {
                endGame();
            }
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
        }
        private void ChangePlayer()
        {
                PlayerName.Text = Player[CurrentPlayer].Name;
                PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal,vertical);
            return point;
        }
        private void endGame()
        {
            ChessBoard.Enabled = false;
            UndoMenu.Enabled = false;
            MessageBox.Show("Game is over");
        }
        private bool isEndGame(Button btn)
        {
            return isEndGameHorizontal(btn)||isEndGamePrimary(btn)||isEndGameVertical(btn)||isEndGameSub(btn);
        }
        private bool isEndGameHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0 ; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X+1; i <Cons.Size_Chess_Board_Width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft+countRight==5;
        }
        private bool isEndGameVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.Size_Chess_Board_Height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndGamePrimary(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y-i<0||point.X-i<0)
                {
                    break;
                }
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.Size_Chess_Board_Width-point.X; i++)
            {
                if (point.Y+i>=Cons.Size_Chess_Board_Height||point.X+i>= Cons.Size_Chess_Board_Width)
                {
                    break;
                }
                if (Matrix[point.Y+i][point.X+i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndGameSub(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X + i < 0)
                {
                    break;
                }
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.Size_Chess_Board_Width - point.X; i++)
            {
                if (point.Y + i >= Cons.Size_Chess_Board_Height || point.X + i < 0)
                {
                    break;
                }
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        #endregion
    }
}
public class ButtonClickEvent : EventArgs
{
    private Point clickedPoint;

    public Point ClickedPoint
    {
        get { return clickedPoint; }
        set { clickedPoint = value; }
    }

    public ButtonClickEvent(Point point)
    {
        this.ClickedPoint = point;
    }
}
