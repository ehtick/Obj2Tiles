﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SilentWave.Obj2Gltf.Gltf
{
    /// <summary>
    /// The root `Node`s of a scene.
    /// </summary>
    public class Scene
    {
        /// <summary>
        /// The indices of each root node.
        /// </summary>
        [JsonProperty("nodes")]
        public List<int> Nodes { get; set; } = new List<int>();
    }
}
