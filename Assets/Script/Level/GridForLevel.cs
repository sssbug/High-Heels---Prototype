using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridForLevel : MonoBehaviour
{

    [SerializeField]
    private GameObject gridCellPrefab;

    private int _height;
    private int _width;
    
    private float _gridSpaceSizeX = 1.03f;
    private float _gridSpaceSizeY = 1.03f;
    private int y, x, z;
    int number;

    private GameObject[,] _gameGrid;





    private void Start()
    {
        number = Random.Range(2,5);
        _height = number;
        _width = number;
        CreateGrid();
    }







    private void CreateGrid()
    {
        _gameGrid = new GameObject[_height, _width];


        for (y = 0; y < _height; y++)
        {
            for (x = 0; x < _width; x++)
            {
                _gameGrid[x, y] = Instantiate(gridCellPrefab, new Vector3(x * _gridSpaceSizeX, y * _gridSpaceSizeY), Quaternion.identity);



                if (_gameGrid[x, y] != null)
                {
                    _gameGrid[x, y].transform.parent = this.transform;
                    _gameGrid[x, y].gameObject.name = "Game Space( X: " + x.ToString() + ", Y: " + y.ToString() + ", Z: " + z.ToString() + ")";
                }
            }
        }
    }
}