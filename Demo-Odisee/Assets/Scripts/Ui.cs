using UnityEngine;
using System.Collections;

public class Ui : MonoBehaviour {

    private int _counter;

    public float X, Y;
    public float Width, Height;

    private Vector2 _pos;
    private Vector2 _size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        _pos = new Vector2(X, Y);
        _size = new Vector2(Width, Height);
	}

    void OnGUI()
    {
        GUI.Label(new Rect(_pos, _size), _counter.ToString());
    }

    void AddItem()
    {
        _counter++;
    }
}
