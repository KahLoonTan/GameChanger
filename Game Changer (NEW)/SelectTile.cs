﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez;
using Nez.Tiled;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game_Changer__NEW_
{
    public class SelectTile : RenderableComponent, IUpdatable
    {
        TiledMap tiledmap;
        Point location;

        public SelectTile(TiledMap ref_tiledmap)
        {
            location = new Point(0,0);
            tiledmap = ref_tiledmap;
            var layer = tiledmap.getLayer<TiledTileLayer>("maplayer");
        }



        void IUpdatable.update()
        {
            if (Input.leftMouseButtonPressed)
            {
                location = tiledmap.worldToTilePosition(Input.mousePosition);
                System.Diagnostics.Debug.WriteLine(location);
            }

        }

        public override void render(Graphics graphics, Camera camera)
        {
            //    //throw new NotImplementedException();
            System.Diagnostics.Debug.WriteLine("hello");
            camera = null;
            graphics = null;
            return;

        }

    }
}