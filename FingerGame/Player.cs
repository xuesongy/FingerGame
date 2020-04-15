using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerGame {
    class Player {
        // 普通玩家类
        public string FistName {
            get;
            set;
        }
        public int showFist(string fistName) {

            int result = -1;
            switch (fistName) {
                case "石头": result = 1; break;
                case "剪刀": result = 2; break;
                case "布": result = 3; break;
            }

            this.FistName = fistName;

            return result;
        }
    }
}
