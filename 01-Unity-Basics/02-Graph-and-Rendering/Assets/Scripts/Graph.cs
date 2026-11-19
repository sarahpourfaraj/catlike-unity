using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;

    [SerializeField, Range(10,100)]
    int resolution;

    void Awake()
    {
        //2f is the total length of the considered vertical axis X; From -1 to +1.
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + .5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;

            point.SetParent(transform,false);
        }
    }

}
