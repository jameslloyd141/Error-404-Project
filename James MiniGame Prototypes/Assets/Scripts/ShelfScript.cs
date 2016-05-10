using UnityEngine;
using System.Collections;

public class ShelfScript : MonoBehaviour
{
    //public GameObject player;
    public MoveScript MoveScript1;
    public int shelfNumber;


    // Use this for initialization
    /*void start()
    {
        //player = GameObject.Find("player");
        MoveScript1 = player.GetComponent<MoveScript>();
    }*/
    void OnMouseDown()
    {
        MoveScript1.CurrentShelf = shelfNumber;
    }
}