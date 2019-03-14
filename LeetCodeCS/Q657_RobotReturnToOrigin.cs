using System;
namespace LeetCodeCS
{
    public class Q657_RobotReturnToOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < moves.Length; i++) {
                string command = moves.Substring(i, 1);
                switch (command)
                {
                    case "L":
                        x = x-1;
                        break;
                    case "R":
                        x = x + 1;
                        break;
                    case "U":
                        y = y + 1;
                        break;
                    case "D":
                        y = y - 1;
                        break;
                    default:
                        break;
                }

            }
            return x == 0 && y == 0;

        }
    }
}
