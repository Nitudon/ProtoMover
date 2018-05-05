
using UnityEngine;
using ProtoMover.Enums;

namespace ProtoMover
{
    public abstract class PlayerBase : MonoBehaviour
    {

        protected float _speed = 1.0f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected abstract void MovePlayer(Direction dir);
    }
}
