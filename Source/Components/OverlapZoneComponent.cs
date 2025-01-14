﻿#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
#endregion
namespace DoD_23_24
{
    public class OverlapZoneComponent : Component
    {
        NPC parentNPC;
        //Farm addition
        Rock parentRock;

        public OverlapZoneComponent(Entity entity, NPC parent) : base(entity)
        {
            parentNPC = parent;
        }

        //Farm addition
        public OverlapZoneComponent(Entity entity, Rock rock) : base(entity)
        {
            parentRock = rock;
        }

        public override void Update(GameTime gameTime)
        {

        }

        public NPC GetParentNPC()
        {
            return parentNPC;
        }

        //Farm addition
        public Rock GetParentRock()
        {
            return parentRock;
        }
    }
}