using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.scripts.Objects
{
    [System.Serializable]
    public class Character
    {
        private Sprite _icon = null;
        [SerializeField]
        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        private List<Animation> _animations = null;
        [SerializeField]
        public List<Animation> animations
        {
            get { return _animations; }
            set { _animations = value; }
        }
    }
}
