using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FSCSharp
{
    public class Hitbox : VisibleGameObject
    {
        #region Constructors
        public Hitbox(Vector2 pos, Vector2 bottomCorner) : base()
        {
            Pos = pos;
            BottomCorner = bottomCorner;
        }

       
        #endregion

        #region Methods
        public override void Update(float delta)
        {
            
        }
        public bool IsColliding(Hitbox other)
        {
            if((other.BottomCorner.X > this.Pos.X) && !(this.BottomCorner.X < other.Pos.X))
            {
                if ((other.BottomCorner.Y > this.Pos.Y) && !(this.BottomCorner.Y < other.Pos.Y))
                {
                    return true;
                }
            }
            return false;
        }

        public override void Draw(float delta)
        {
            Raylib.BeginDrawing();
            Raylib.DrawRectangle((int)(Pos.X), (int)(Pos.Y), (int)(BottomCorner.X - Pos.X),(int)(BottomCorner.Y - Pos.Y), Color.Black);
            Raylib.EndDrawing();
        }
        #endregion

        #region Properties
        public Vector2 Pos { get; set; }

        public Vector2 BottomCorner { get; set; }
        #endregion
    }
}
