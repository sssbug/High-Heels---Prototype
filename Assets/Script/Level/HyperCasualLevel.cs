using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperCasualLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gridCellPrefab;

    private int _length = 5;



    private float _gridSpaceSizeZ = 40;
    private int z;
    int number;

    private GameObject[] _gameGrid;





    private void Start()
    {

        CreateGrid();
    }







    private void CreateGrid()
    {
        _gameGrid = new GameObject[_length];

        for (z = 0; z < _length; z++)
        {
            number = Random.Range(0, 0);
            _gameGrid[z] = Instantiate(gridCellPrefab[number], new Vector3(0, 0f, z * _gridSpaceSizeZ), Quaternion.identity);

            if (_gameGrid[z] != null)
            {
                _gameGrid[z].transform.parent = this.transform;
            }
        }
    }
}
