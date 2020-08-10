using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
        public new static void UpdatePosition(string key, out int x, out int y)
        {
            switch (key)
            {
                case "DownArrow":
                    y = 1;
                    x = 0;
                    break;
                case "UpArrow":
                    y = -1;
                    x = 0;
                    break;
                case "LeftArrow":
                    x = -1;
                    y = 0;
                    break;
                case "RightArrow":
                    x = 1;
                    y = 0;
                    break;
                default:
                    x = 0;
                    y = 0;
                    break;
            }
        }

            public static new char UpdateCursor(string key)
        {
            switch(key)
            {
                case "LeftArrow":
                    return '<';
                case "RightArrow":
                    return '>';
                case "UpArrow":
                    return '^';
                case "DownArrow":
                    return 'v';
                default:
                    return '<';
            }
        }
        public new static int KeepInBounds(int coordinate, int maximum)
        {
            if (coordinate < 0)
            {
                return 0;
            } else if(coordinate > maximum)
            {
                return maximum - 1;
            } else
            {
                return coordinate;
            }
        }

        public new static bool DidScore(int x, int y, int fruit_x, int fruit_y)
        {
            if (x == fruit_x && y == fruit_y) {
                return true;
            } else
            {
                return false;
            }
        }
   }
 }
