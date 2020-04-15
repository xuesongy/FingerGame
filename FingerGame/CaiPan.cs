using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerGame {
    public enum UserState {
        PlayerWin,
        PlayerLose,
        PingShou
    }
    static class CaiPan {
        // 判断普通玩家是：输、赢、平手
        public static UserState CaiDing(int playerFist, int computerFist) {

            if (playerFist == computerFist) {
                return UserState.PingShou;
            } else if (playerFist - computerFist == -1 || playerFist - computerFist == 2) {
                return UserState.PlayerWin;
            } else {
                return UserState.PlayerLose;
            }

        }
    }
}
