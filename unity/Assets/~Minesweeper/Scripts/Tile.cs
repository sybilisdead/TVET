using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper
{
    [RequireComponent(typeof(SpriteRenderer))] //will force the sprite renderer 
    //to be attached, script wont run unless the sprite renderer is attached
    //(if not it will automatically add one)
    public class Tile : MonoBehaviour
    {
        public int x, y;
        public bool isMine = false; //Is the current tile a mine? (bool is a tru/fals value
        public bool isRevealed = false; //Has the tile already been revealed?
        [Header("References")]
        public Sprite[] emptySprites; //List of empty sprites i.e, empty, 1, 2, 3, etc...
        public Sprite[] mineSprites; //The mine sprites

        private SpriteRenderer rend; //Reference to sprite renderer
        private static int adjacentMines;

        void Awake()
        {
            rend = GetComponent<SpriteRenderer>(); //At the start of the game, gets tile to reference to its own sprite renderer
        }

        void Start()
        {
            //0 - 1 random number (5
            isMine = Random.value < .05f;
        }

        void Reveal(int adjacentMines, int mineState = 0)
        {
            //Flags the tile as being revealed
            isRevealed = true;
            //Checks if mine is a tile
            if(isMine)
            {
                //Sets sprite to mine sprite
                rend.sprite = mineSprites[mineState];
            
            }
            else
            {
                //Sets sprite to appropriate texture based on adjavent mines
                rend.sprite = emptySprites[adjacentMines];
            }
        }
    }
}
