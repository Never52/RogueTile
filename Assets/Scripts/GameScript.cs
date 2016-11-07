using UnityEngine;
using System.Collections;


public class GameScript : MonoBehaviour {

    public GameObject HealthPrefab;
    public GameObject CoinPrefab;
    public GameObject SwordPrefab;
    public Vector2 position;
    public Tile[,] board = new Tile[6, 6];
    public float spacing = 0.08F;
	void Start () 
    {
        fillBoard();
        displayBoard();
	}
	
    void display(Tile tile)
    {
        float X = 0.5F + tile.mCol + (tile.mCol * spacing);
        float Y = -2.9F - tile.mRow - (tile.mRow * spacing);
        Vector3 position = new Vector3(X, Y, 0.0F);
       
        if(tile.mType == "health")
        {
            Tile health = (Tile)Instantiate(HealthPrefab, position, transform.rotation);
            health.mRow = tile.mRow;
            health.mCol = tile.mCol;
            health.mType = tile.mType;
        }
        else if (tile.mType == "coin")
        {
            Tile coin = (Tile)Instantiate(CoinPrefab, position, transform.rotation);
            coin.mRow = tile.mRow;
            coin.mCol = tile.mCol;
            coin.mType = tile.mType;
        }
           
        else if(tile.mType == "sword")
        {
            Tile sword = (Tile)Instantiate(SwordPrefab, position, transform.rotation);
            sword.mRow = tile.mRow;
            sword.mCol = tile.mCol;
            sword.mType = tile.mType;
        }
            
    }

    void fillBoard()
    {
        int temp = 0;
        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                temp = Random.Range(1, 10);
                board[i, j] = new Tile(temp, i, j);
            }
        }
    }

    void displayBoard()
    {
        for(int i = 0; i < 6; i++)
            for(int j = 0; j < 6; j++)
                display(board[i, j]);
    }

}
