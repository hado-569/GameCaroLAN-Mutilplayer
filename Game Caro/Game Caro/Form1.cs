using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class CaroWithYourFrends : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        #endregion
        public CaroWithYourFrends()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            ChessBoard = new ChessBoardManager(pnlChessBoard,txtNamePlayer,picMarkPlayer,undoToolStripMenuItem);
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            newGame();
            socket = new SocketManager();
        }
        #region Methods        
        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            pnlChessBoard.Enabled = false;
            socket.Send(new SocketDATA(e.ClickedPoint, "", (int)SocketCommand.SEND_POINT));
           
            Listen();
        }

        void newGame()
        {
            ChessBoard.drawChessBoard();
            undoToolStripMenuItem.Enabled = true;
        }
        
        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            ChessBoard.undoGame();
            
        }
        void Listen()
        {
            
                Thread listenThread = new Thread(() => {
                    try
                    {
                        SocketDATA data = (SocketDATA)socket.Receive();
                        ProcessDATA(data);
                    }
                    catch (Exception)
                    {
                         
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            
            

        }
        private void ProcessDATA(SocketDATA data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Mess);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(()=> {
                        newGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() => {
                        pnlChessBoard.Enabled = true;
                        ChessBoard.OtherPlayerMarked(data.Point);
                       
                    }));

                    break;
                case (int)SocketCommand.UNDO:
                    this.Invoke((MethodInvoker)(()=> {
                        Undo();
                    }));
                   
                    break;
                case (int)SocketCommand.END_GAME:
                    
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show("Other player has disconnected");
                    break;
                default:
                    break;
            }
            Listen();
        }


        private void PicGame_Click(object sender, EventArgs e)
        {

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            socket.Send(new SocketDATA(new Point(), "", (int)SocketCommand.NEW_GAME));

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketDATA(new Point(), "", (int)SocketCommand.UNDO));
            pnlChessBoard.Enabled = true;

        }

        private void QuitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?!","Notice",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketDATA(new Point(), "", (int)SocketCommand.QUIT));

                }
                catch
                {

                   
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            socket.IP = txtIP.Text;
            if (!socket.ConnectServer())
            {
                socket.CreatedServer();
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                
                button1.Text = "Connected";
               
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                button1.Text = "Connected";
                Listen();
                
            }
        }
        

        private void CaroWithYourFrends_Shown(object sender, EventArgs e)
        {
            txtIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txtIP.Text))
            {
                txtIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        #endregion
    }
}
