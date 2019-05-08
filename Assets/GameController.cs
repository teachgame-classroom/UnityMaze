using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Maze;

public class GameController : MonoBehaviour
{
    public GameObject[] blockPrefabs;
    Game game;

    // Start is called before the first frame update
    void Start()
    {
        game = new Game(8, 8, 1, 1, blockPrefabs);   
    }

    // Update is called once per frame
    void Update()
    {
        game.Loop();
    }
}
