using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.scripts.Objects
{
    [System.Serializable]
    public class Animation
    {
        private List<Sprite> _animationSprites;
        [SerializeField]
        public List<Sprite> AnimationSprites
        {
            get { return _animationSprites; }
            set { _animationSprites = value; }
        }
        public void Add(Sprite sprite)
        {
            _animationSprites.Add(sprite);
        }

        public void Remove (Sprite sprite)
        {
            _animationSprites.Remove(sprite);
        }
        [SerializeField]
        public int Length()
        {
            return _animationSprites.Count;
        }
    }
}
