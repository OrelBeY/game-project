using System.Collections.Generic;
using System.Linq;

using WebAPI.Models;
using WebAPI.Models.Games.TicTacToe;

namespace WebAPI.Models.Games.TicTacToe.AI {
    public class GameManager : BaseGameManager {
        public GameManager(IPlayer player1, IPlayer player2)
        : base(player1, player2)
        { }
    }
}
