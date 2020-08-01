using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D _Rdb;

    public float _Up_Force;

    public string _Tileset_Name;

    public Transform _Initial_Position;

    void Start()
    {
        _Rdb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _Rdb.velocity = new Vector2(0, _Up_Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name == "Yellow Tileset")
        {
            _Tileset_Name = collision.gameObject.name;
        }

        if (collision.gameObject.name == "Red Tileset")
        {
            _Tileset_Name = collision.gameObject.name;
        }

        if (collision.gameObject.name == "Green Tileset")
        {
            _Tileset_Name = collision.gameObject.name;
        }

        if (collision.gameObject.name == "Blue Tileset")
        {
            _Tileset_Name = collision.gameObject.name;
        }

        if (collision.gameObject.name == "Orange Tileset")
        {
            _Tileset_Name = collision.gameObject.name;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Blue Tileset")
        {
            transform.position = _Initial_Position.position;
        }
    }

}
