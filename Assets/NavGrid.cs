using UnityEngine;
using System.Collections;

namespace ImmuneDefense
{

    public class NavGrid : MonoBehaviour
    {
        [SerializeField]
        private int Width;

        [SerializeField]
        private int Height;

        private NavGridCell[,] _cells;

        // Use this for initialization
        void Start()
        {
            _cells = new NavGridCell[Width, Height];
        }

        // Update is called once per frame
        void Update()
        {
            // Assuming that the object in question is a flat plane
            var collider = this.GetComponent<MeshCollider>();
            var min = collider.bounds.min;
            var dx = collider.bounds.size.x / Width;
            var dz = collider.bounds.size.z / Height;
            var dxy = collider.bounds.size.y / Width;
            var dzy = collider.bounds.size.y / Height;

            // Debug grid lines
            for (int x = 0; x <= Width; x++)
            {
                var start = min + new Vector3(x * dx, x * dxy, 0);
                var end = min + new Vector3(x * dx, Height * dzy - x * dxy , Height * dz);

                Debug.DrawLine(start, end, Color.black);
            }

            for (int z = 0; z < Height + 1; z++)
            {
                var start = min + new Vector3(0, z * dzy, z * dz);
                var end = min + new Vector3(Width * dx, z * dzy - Width * dxy, z * dz);

                Debug.DrawLine(start, end, Color.black);
            }

        }
    }

    class NavGridCell
    {

    }
};