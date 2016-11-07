using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour 
{

    public int mRow = 0;
    public int mCol = 0;
    public string mType;
    public int mHealth = 0;
    public int mDamage = 0;
    public int mDamageTaken = 0;
    public int mBonusDamageTaken = 0;
    public bool frozen = false;

	public Tile(string type, int row, int col)
    {
        mType = type;
        mRow = row;
        mCol = col;
    }

    public Tile(int rand, int row, int col)
    {
        mCol = col;
        mRow = row;

        if (rand < 3)
            mType = "health";
        else if (rand < 6)
            mType = "coin";
        else if (rand < 10)
            mType = "sword";
        /*
         else if (rand <= 10)						
          {
             mType = "goblin";
	        			
             mHealth = 4;
             mDamage = 2;
          }
             else if (rand < 11) 
             mType = "helix tile";
         */
    }
           
    
    
}
