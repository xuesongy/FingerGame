using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerGame {
    class Computer {
        public string FistName {
            get;
            set;
        }

        public int showFist() {
            // 随机产生 1，2，3 中的任意整数。
            Random random = new Random();
            int result = random.Next(1, 4);

            switch (result) {
                case 1: this.FistName = "石头";break;
                case 2: this.FistName = "剪刀";break;
                case 3: this.FistName = "布";break;
                default: break;
            }
            
            return result;
        }
    }
}
