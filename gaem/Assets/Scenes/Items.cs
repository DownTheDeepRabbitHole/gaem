using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Items",menuName = "Scriptable object/Items")]
public class Items : ScriptableObject
{

    [Header("Only Building")]
    //only needed for the placing the tile into the world(the factory building part), Anthony should not need to use this
    public TileBase tilebase;
    public Tile tile;

    [Header("Both")]
    // used for the UI, will need to use this for the factory part(items on conveyer belt) and the shop(depends on how anthony does it)
    public Sprite image;

    [Header("Only UI")]
    //only used in the UI to signal if a item is stackable(like stone, or boats(minecraft example))
    public bool stackable = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
