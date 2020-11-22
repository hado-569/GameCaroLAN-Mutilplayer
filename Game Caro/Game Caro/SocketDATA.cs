using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    [Serializable]
   public class SocketDATA
    {
        private int command;

        private Point point;
        private string mess;

        public int Command { get => command; set => command = value; }
        public Point Point { get => point; set => point = value; }
        public string Mess { get => mess; set => mess = value; }

        public SocketDATA(Point point, string mess, int command)
        {
            this.Point = point;
            this.Command = command;
            this.Mess = mess;
        }
       
    }
    public enum SocketCommand
    {
        SEND_POINT,
        NEW_GAME,
        NOTIFY,
        END_GAME,
        QUIT,
        UNDO
    }
}
