﻿using System;

namespace EnthusiasticMoose
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine();

      // Let the moose speak!
      // Let the moose speak!
      MooseSays("H I, I'M  E N T H U S I A S T I C !");
      MooseSays("I really am enthusiastic");
    }

    static void MooseSays(string message)
    {
      Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
    }
  }
}
