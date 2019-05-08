using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    class Game
    {
        public bool isRunning;

        private bool isPlayerWon;

        private ConsoleKeyInfo key;
        private string keyString;
        private string hintString = "WASD-移动，R-重新开始，ESC-退出";
        private Stage stage;

        int row;
        int col;
        int playerStartPosX;
        int playerStartPosY;

        private GameObject[] blockPrefabs;

        public Game(int row, int col, int playerPosX, int playerPosY, GameObject[] blockPrefabs)
        {
            this.row = row;
            this.col = col;
            this.playerStartPosX = playerPosX;
            this.playerStartPosY = playerPosY;
            this.blockPrefabs = blockPrefabs;

            Init();
        }

        private void Init()
        {
            isRunning = true;
            isPlayerWon = false;
            keyString = "";
            stage = new Stage(row, col, playerStartPosX, playerStartPosY, blockPrefabs);
        }

        public void Loop()
        {
            //HandleInput();
            Update();
            //Render();
        }

        public void Update()
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                keyString = "向上";
                stage.MovePlayer(Stage.UP);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                keyString = "向左";
                stage.MovePlayer(Stage.LEFT);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                keyString = "向下";
                stage.MovePlayer(Stage.DOWN);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                keyString = "向右";
                stage.MovePlayer(Stage.RIGHT);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isRunning = false;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Init();
            }

            if(stage.IsPlayerReachedGoal())
            {
                isPlayerWon = true;
            }
        }

        public void HandleInput()
        {
            key = Console.ReadKey(true);
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine(keyString);
            stage.DrawStage();
            Console.WriteLine(hintString);
            if (isPlayerWon)
            {
                Console.WriteLine("你赢了！");
            }
        }

        public void End()
        {
            Console.WriteLine("欢迎再玩，再见！");
        }
    }
}
